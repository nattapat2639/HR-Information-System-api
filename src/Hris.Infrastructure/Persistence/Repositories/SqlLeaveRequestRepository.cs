using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Hris.Application.DTOs;
using Hris.Application.DTOs.Leave;
using Hris.Application.Interfaces.Repositories;
using Hris.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hris.Infrastructure.Persistence.Repositories;

public sealed class SqlLeaveRequestRepository : ILeaveRequestRepository
{
    private readonly HrisDbContext _context;

    private static readonly LeaveTypeDto[] LeaveTypeCatalog =
    {
        new("annual", "Annual Leave", "Paid time off for planned vacations or rest.", 15m, true, true),
        new("sick", "Sick Leave", "Paid leave for illness or medical appointments.", 10m, true, false),
        new("wfh", "Work From Home", "Remote work arrangement counted against flex balance.", 24m, false, true),
        new("unpaid", "Unpaid Leave", "Unpaid time off outside of standard allowances.", 0m, true, false),
        new("family", "Family Responsibility", "Leave to support critical family matters.", 5m, true, false)
    };

    public SqlLeaveRequestRepository(HrisDbContext context)
    {
        _context = context;
    }

    public async Task<PagedResult<LeaveRequestSummaryDto>> GetMyRequestsAsync(
        Guid employeeId,
        LeaveRequestQueryDto query,
        int pageNumber,
        int pageSize,
        CancellationToken cancellationToken)
    {
        var baseQuery = _context.LeaveRequests
            .AsNoTracking()
            .Include(l => l.Employee)
            .Where(l => l.EmployeeId == employeeId);

        baseQuery = ApplyFilters(baseQuery, query);
        baseQuery = baseQuery.OrderByDescending(l => l.StartDate).ThenByDescending(l => l.RequestedOn);

        return await ProjectPagedResultAsync(baseQuery, pageNumber, pageSize, cancellationToken);
    }

    public async Task<PagedResult<LeaveRequestSummaryDto>> GetTeamRequestsAsync(
        Guid managerId,
        LeaveRequestQueryDto query,
        int pageNumber,
        int pageSize,
        CancellationToken cancellationToken)
    {
        var manager = await _context.Employees
            .AsNoTracking()
            .FirstOrDefaultAsync(employee => employee.Id == managerId, cancellationToken);

        var department = manager?.Department;

        var baseQuery = _context.LeaveRequests
            .AsNoTracking()
            .Include(l => l.Employee)
            .Where(l => l.EmployeeId != managerId);

        if (!string.IsNullOrWhiteSpace(department))
        {
            var normalizedDepartment = department.Trim();
            baseQuery = baseQuery.Where(l => l.Employee != null &&
                l.Employee.Department != null &&
                EF.Functions.ILike(l.Employee.Department, normalizedDepartment));
        }

        baseQuery = ApplyFilters(baseQuery, query);

        // For team view focus on current and future leaves plus pending decisions
        var currentDate = DateTime.UtcNow.Date;
        baseQuery = baseQuery.Where(l =>
            l.Status.Equals("Pending", StringComparison.OrdinalIgnoreCase) ||
            l.StartDate.Date >= currentDate.AddMonths(-1));

        baseQuery = baseQuery
            .OrderBy(l => l.Status.Equals("Pending", StringComparison.OrdinalIgnoreCase) ? 0 : 1)
            .ThenByDescending(l => l.StartDate)
            .ThenByDescending(l => l.RequestedOn);

        return await ProjectPagedResultAsync(baseQuery, pageNumber, pageSize, cancellationToken);
    }

    public async Task<PagedResult<LeaveRequestSummaryDto>> GetHistoryAsync(
        Guid employeeId,
        LeaveRequestQueryDto query,
        int pageNumber,
        int pageSize,
        CancellationToken cancellationToken)
    {
        var cutoff = DateTime.UtcNow.Date.AddMonths(-1);
        var baseQuery = _context.LeaveRequests
            .AsNoTracking()
            .Include(l => l.Employee)
            .Where(l => l.EmployeeId == employeeId && l.EndDate.Date <= cutoff);

        baseQuery = ApplyFilters(baseQuery, query);
        baseQuery = baseQuery.OrderByDescending(l => l.StartDate);

        return await ProjectPagedResultAsync(baseQuery, pageNumber, pageSize, cancellationToken);
    }

    public Task<LeaveRequest?> FindByIdAsync(Guid requestId, CancellationToken cancellationToken)
    {
        return _context.LeaveRequests
            .Include(l => l.Employee)
            .AsSplitQuery()
            .FirstOrDefaultAsync(l => l.Id == requestId, cancellationToken);
    }

    public async Task AddAsync(LeaveRequest request, CancellationToken cancellationToken)
    {
        await _context.LeaveRequests.AddAsync(request, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateAsync(LeaveRequest request, CancellationToken cancellationToken)
    {
        _context.LeaveRequests.Update(request);
        await _context.SaveChangesAsync(cancellationToken);
    }

    public Task<LeaveBalanceDto[]> GetBalancesAsync(Guid employeeId, int year, CancellationToken cancellationToken)
    {
        return CalculateBalancesAsync(employeeId, year, cancellationToken);
    }

    public Task<LeaveTypeDto[]> GetLeaveTypesAsync(CancellationToken cancellationToken)
    {
        return Task.FromResult(LeaveTypeCatalog);
    }

    private static IQueryable<LeaveRequest> ApplyFilters(
        IQueryable<LeaveRequest> query,
        LeaveRequestQueryDto filters)
    {
        if (!string.IsNullOrWhiteSpace(filters.LeaveType))
        {
            query = query.Where(l => l.LeaveType.ToLower() == filters.LeaveType.ToLower());
        }

        if (!string.IsNullOrWhiteSpace(filters.Status))
        {
            query = query.Where(l => l.Status.ToLower() == filters.Status.ToLower());
        }

        if (filters.StartDate.HasValue)
        {
            var start = filters.StartDate.Value.Date;
            query = query.Where(l => l.StartDate.Date >= start);
        }

        if (filters.EndDate.HasValue)
        {
            var end = filters.EndDate.Value.Date;
            query = query.Where(l => l.EndDate.Date <= end);
        }

        if (!string.IsNullOrWhiteSpace(filters.EmployeeKeyword))
        {
            var keyword = filters.EmployeeKeyword.Trim();
            query = query.Where(l =>
                l.Employee != null &&
                (EF.Functions.ILike(l.Employee.FullName, $"%{keyword}%") ||
                 EF.Functions.ILike(l.Employee.EmployeeNumber, $"%{keyword}%")));
        }

        return query;
    }

    private static LeaveRequestSummaryDto ToSummary(LeaveRequest request)
    {
        var employeeName = request.Employee?.FullName ?? "Unknown";
        return new LeaveRequestSummaryDto(
            request.Id,
            request.EmployeeId,
            employeeName,
            request.Reference,
            request.LeaveType,
            request.IsHalfDay,
            request.StartDate,
            request.EndDate,
            request.Status,
            request.RequestedOn,
            request.Reason,
            request.ContactDuringLeave,
            request.SupportingDocumentUrl,
            request.ApproverId,
            request.ApproverName,
            request.DecisionOn,
            request.ManagerComment);
    }

    private async Task<PagedResult<LeaveRequestSummaryDto>> ProjectPagedResultAsync(
        IQueryable<LeaveRequest> query,
        int pageNumber,
        int pageSize,
        CancellationToken cancellationToken)
    {
        var total = await query.CountAsync(cancellationToken);

        var items = await query
            .Skip(Math.Max(pageNumber - 1, 0) * pageSize)
            .Take(pageSize)
            .Select(request => ToSummary(request))
            .ToListAsync(cancellationToken);

        return new PagedResult<LeaveRequestSummaryDto>(items, total, pageNumber, pageSize);
    }

    private async Task<LeaveBalanceDto[]> CalculateBalancesAsync(
        Guid employeeId,
        int year,
        CancellationToken cancellationToken)
    {
        var relevantLeaves = await _context.LeaveRequests
            .AsNoTracking()
            .Where(l => l.EmployeeId == employeeId &&
                        (l.StartDate.Year == year || l.EndDate.Year == year))
            .ToListAsync(cancellationToken);

        var balances = new List<LeaveBalanceDto>(LeaveTypeCatalog.Length);

        foreach (var leaveType in LeaveTypeCatalog)
        {
            var taken = relevantLeaves
                .Where(l => string.Equals(l.LeaveType, leaveType.Name, StringComparison.OrdinalIgnoreCase) &&
                            string.Equals(l.Status, "Approved", StringComparison.OrdinalIgnoreCase))
                .Sum(GetDurationInDays);

            var pending = relevantLeaves
                .Where(l => string.Equals(l.LeaveType, leaveType.Name, StringComparison.OrdinalIgnoreCase) &&
                            string.Equals(l.Status, "Pending", StringComparison.OrdinalIgnoreCase))
                .Sum(GetDurationInDays);

            var remaining = leaveType.DefaultAllowance <= 0
                ? 0m
                : Math.Max(0m, leaveType.DefaultAllowance - taken);

            balances.Add(new LeaveBalanceDto(
                employeeId,
                year,
                leaveType.Name,
                leaveType.DefaultAllowance,
                0m,
                taken,
                pending,
                remaining));
        }

        return balances
            .OrderBy(balance => balance.LeaveType, StringComparer.OrdinalIgnoreCase)
            .ToArray();
    }

    private static decimal GetDurationInDays(LeaveRequest request)
    {
        if (request.IsHalfDay)
        {
            return 0.5m;
        }

        var duration = (decimal)(request.EndDate.Date - request.StartDate.Date).TotalDays + 1m;
        return Math.Max(0.5m, duration);
    }
}
