using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Hris.Application.DTOs;
using Hris.Application.DTOs.Leave;
using Hris.Application.Interfaces.Repositories;
using Hris.Domain.Entities;

namespace Hris.Infrastructure.Persistence.Repositories;

public sealed class InMemoryLeaveRequestRepository : ILeaveRequestRepository
{
    private readonly object _syncRoot = new();
    private readonly Dictionary<Guid, Employee> _employees;
    private readonly List<LeaveRequest> _requests;
    private readonly LeaveTypeDto[] _leaveTypes =
    {
        new("annual", "Annual Leave", "Paid time off for planned vacations or rest.", 15m, true, true),
        new("sick", "Sick Leave", "Paid leave for illness or medical appointments.", 10m, true, false),
        new("wfh", "Work From Home", "Remote work arrangement counted against flex balance.", 24m, false, true),
        new("unpaid", "Unpaid Leave", "Unpaid time off outside of standard allowances.", 0m, true, false),
        new("family", "Family Responsibility", "Leave to support critical family matters.", 5m, true, false)
    };

    public InMemoryLeaveRequestRepository()
    {
        var employeeId = Guid.Parse("00000064-0000-0001-0000-00660000309E");
        var managerId = Guid.Parse("00000064-0000-0002-0000-00600000309F");
        var teammateId = Guid.Parse("00000064-0000-0003-0000-0062000030A0");

        _employees = new Dictionary<Guid, Employee>
        {
            [employeeId] = new Employee
            {
                Id = employeeId,
                EmployeeNumber = "IT-001",
                FullName = "Alex Morgan",
                Department = "Technology",
                Position = "Software Engineer",
                Status = "Active"
            },
            [managerId] = new Employee
            {
                Id = managerId,
                EmployeeNumber = "IT-002",
                FullName = "Jamie Wong",
                Department = "Technology",
                Position = "Engineering Manager",
                Status = "Active"
            },
            [teammateId] = new Employee
            {
                Id = teammateId,
                EmployeeNumber = "IT-003",
                FullName = "Nina Chai",
                Department = "Technology",
                Position = "QA Analyst",
                Status = "Active"
            }
        };

        _requests = new List<LeaveRequest>
        {
            new()
            {
                Id = Guid.Parse("000000C8-0000-0001-0000-0070000030F1"),
                EmployeeId = employeeId,
                Reference = "LV-2025-0001",
                LeaveType = "Annual Leave",
                Reason = "Vacation recharge planned months in advance.",
                IsHalfDay = false,
                ContactDuringLeave = "+66-8123-4567",
                StartDate = new DateTime(2025, 2, 21, 0, 0, 0, DateTimeKind.Utc),
                EndDate = new DateTime(2025, 2, 24, 0, 0, 0, DateTimeKind.Utc),
                Status = "Approved",
                RequestedOn = new DateTime(2025, 1, 25, 0, 0, 0, DateTimeKind.Utc),
                ApproverId = managerId,
                ApproverName = _employees[managerId].FullName,
                DecisionOn = new DateTime(2025, 1, 27, 0, 0, 0, DateTimeKind.Utc),
                ManagerComment = "Approved - coverage confirmed.",
                SupportingDocumentUrl = null,
                Employee = _employees[employeeId]
            },
            new()
            {
                Id = Guid.Parse("000000C8-0000-0002-0000-0074000030F2"),
                EmployeeId = employeeId,
                Reference = "LV-2025-0004",
                LeaveType = "Sick Leave",
                Reason = "Medical follow-up appointment as advised by doctor.",
                IsHalfDay = true,
                ContactDuringLeave = "+66-8123-4589",
                StartDate = new DateTime(2025, 3, 3, 0, 0, 0, DateTimeKind.Utc),
                EndDate = new DateTime(2025, 3, 3, 0, 0, 0, DateTimeKind.Utc),
                Status = "Pending",
                RequestedOn = new DateTime(2025, 2, 28, 0, 0, 0, DateTimeKind.Utc),
                Employee = _employees[employeeId]
            },
            new()
            {
                Id = Guid.Parse("000000C8-0000-0003-0000-0076000030F3"),
                EmployeeId = teammateId,
                Reference = "LV-2025-0006",
                LeaveType = "Work From Home",
                Reason = "Remote work arrangement for personal project delivery.",
                IsHalfDay = false,
                ContactDuringLeave = "+66-8999-4455",
                StartDate = new DateTime(2025, 3, 10, 0, 0, 0, DateTimeKind.Utc),
                EndDate = new DateTime(2025, 3, 11, 0, 0, 0, DateTimeKind.Utc),
                Status = "Pending",
                RequestedOn = new DateTime(2025, 2, 28, 0, 0, 0, DateTimeKind.Utc),
                Employee = _employees[teammateId]
            },
            new()
            {
                Id = Guid.Parse("000000C8-0000-0004-0000-0078000030F4"),
                EmployeeId = teammateId,
                Reference = "LV-2024-0145",
                LeaveType = "Annual Leave",
                Reason = "Family commitment and caregiving support.",
                IsHalfDay = false,
                ContactDuringLeave = "+66-8999-1122",
                StartDate = new DateTime(2024, 12, 20, 0, 0, 0, DateTimeKind.Utc),
                EndDate = new DateTime(2024, 12, 24, 0, 0, 0, DateTimeKind.Utc),
                Status = "Approved",
                RequestedOn = new DateTime(2024, 11, 20, 0, 0, 0, DateTimeKind.Utc),
                ApproverId = managerId,
                ApproverName = _employees[managerId].FullName,
                DecisionOn = new DateTime(2024, 11, 22, 0, 0, 0, DateTimeKind.Utc),
                ManagerComment = "Approved - team workload covered.",
                Employee = _employees[teammateId]
            }
        };
    }

    public Task<PagedResult<LeaveRequestSummaryDto>> GetMyRequestsAsync(
        Guid employeeId,
        LeaveRequestQueryDto query,
        int pageNumber,
        int pageSize,
        CancellationToken cancellationToken)
    {
        var filtered = _requests
            .Where(r => r.EmployeeId == employeeId)
            .AsQueryable();

        filtered = ApplyFilters(filtered, query);
        var ordered = filtered
            .OrderByDescending(r => r.StartDate)
            .ThenByDescending(r => r.RequestedOn);

        return Task.FromResult(Project(ordered, pageNumber, pageSize));
    }

    public Task<PagedResult<LeaveRequestSummaryDto>> GetTeamRequestsAsync(
        Guid managerId,
        LeaveRequestQueryDto query,
        int pageNumber,
        int pageSize,
        CancellationToken cancellationToken)
    {
        var managerDepartment = _employees.TryGetValue(managerId, out var manager)
            ? manager.Department
            : null;

        var filtered = _requests
            .Where(r => r.EmployeeId != managerId)
            .Where(r =>
                managerDepartment == null ||
                (_employees.TryGetValue(r.EmployeeId, out var employee) &&
                 string.Equals(employee.Department, managerDepartment, StringComparison.OrdinalIgnoreCase)))
            .AsQueryable();

        filtered = ApplyFilters(filtered, query);
        var ordered = filtered
            .Where(r =>
                r.Status.Equals("Pending", StringComparison.OrdinalIgnoreCase) ||
                r.StartDate.Date >= DateTime.UtcNow.Date.AddMonths(-1))
            .OrderBy(r => r.Status.Equals("Pending", StringComparison.OrdinalIgnoreCase) ? 0 : 1)
            .ThenByDescending(r => r.StartDate);

        return Task.FromResult(Project(ordered, pageNumber, pageSize));
    }

    public Task<PagedResult<LeaveRequestSummaryDto>> GetHistoryAsync(
        Guid employeeId,
        LeaveRequestQueryDto query,
        int pageNumber,
        int pageSize,
        CancellationToken cancellationToken)
    {
        var cutoff = DateTime.UtcNow.Date.AddMonths(-1);
        var filtered = _requests
            .Where(r => r.EmployeeId == employeeId && r.EndDate.Date <= cutoff)
            .AsQueryable();

        filtered = ApplyFilters(filtered, query);
        var ordered = filtered.OrderByDescending(r => r.StartDate);

        return Task.FromResult(Project(ordered, pageNumber, pageSize));
    }

    public Task<LeaveRequest?> FindByIdAsync(Guid requestId, CancellationToken cancellationToken)
    {
        var request = _requests.FirstOrDefault(r => r.Id == requestId);
        return Task.FromResult(Clone(request));
    }

    public Task AddAsync(LeaveRequest request, CancellationToken cancellationToken)
    {
        lock (_syncRoot)
        {
            if (request.Id == Guid.Empty)
            {
                request.Id = Guid.NewGuid();
            }

            if (_employees.TryGetValue(request.EmployeeId, out var employee))
            {
                request.Employee = employee;
            }

            _requests.Add(Clone(request)!);
        }

        return Task.CompletedTask;
    }

    public Task UpdateAsync(LeaveRequest request, CancellationToken cancellationToken)
    {
        lock (_syncRoot)
        {
            var index = _requests.FindIndex(r => r.Id == request.Id);
            if (index >= 0)
            {
                if (_employees.TryGetValue(request.EmployeeId, out var employee))
                {
                    request.Employee = employee;
                }

                _requests[index] = Clone(request)!;
            }
        }

        return Task.CompletedTask;
    }

    public Task<LeaveBalanceDto[]> GetBalancesAsync(Guid employeeId, int year, CancellationToken cancellationToken)
    {
        var results = new List<LeaveBalanceDto>(_leaveTypes.Length);

        foreach (var leaveType in _leaveTypes)
        {
            var relevant = _requests
                .Where(r => r.EmployeeId == employeeId &&
                            (r.StartDate.Year == year || r.EndDate.Year == year) &&
                            string.Equals(r.LeaveType, leaveType.Name, StringComparison.OrdinalIgnoreCase))
                .ToList();

            var taken = relevant
                .Where(r => r.Status.Equals("Approved", StringComparison.OrdinalIgnoreCase))
                .Sum(GetDuration);

            var pending = relevant
                .Where(r => r.Status.Equals("Pending", StringComparison.OrdinalIgnoreCase))
                .Sum(GetDuration);

            var remaining = leaveType.DefaultAllowance <= 0
                ? 0m
                : Math.Max(0m, leaveType.DefaultAllowance - taken);

            results.Add(new LeaveBalanceDto(
                employeeId,
                year,
                leaveType.Name,
                leaveType.DefaultAllowance,
                0m,
                taken,
                pending,
                remaining));
        }

        return Task.FromResult(results.OrderBy(r => r.LeaveType).ToArray());
    }

    public Task<LeaveTypeDto[]> GetLeaveTypesAsync(CancellationToken cancellationToken)
        => Task.FromResult(_leaveTypes);

    private static IQueryable<LeaveRequest> ApplyFilters(IQueryable<LeaveRequest> query, LeaveRequestQueryDto filters)
    {
        if (!string.IsNullOrWhiteSpace(filters.LeaveType))
        {
            var type = filters.LeaveType.Trim();
            query = query.Where(r => r.LeaveType.Equals(type, StringComparison.OrdinalIgnoreCase));
        }

        if (!string.IsNullOrWhiteSpace(filters.Status))
        {
            var status = filters.Status.Trim();
            query = query.Where(r => r.Status.Equals(status, StringComparison.OrdinalIgnoreCase));
        }

        if (filters.StartDate.HasValue)
        {
            var start = filters.StartDate.Value.Date;
            query = query.Where(r => r.StartDate.Date >= start);
        }

        if (filters.EndDate.HasValue)
        {
            var end = filters.EndDate.Value.Date;
            query = query.Where(r => r.EndDate.Date <= end);
        }

        if (!string.IsNullOrWhiteSpace(filters.EmployeeKeyword))
        {
            var keyword = filters.EmployeeKeyword.Trim();
            query = query.Where(r =>
                r.Employee != null &&
                (r.Employee.FullName != null && r.Employee.FullName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                 r.Employee.EmployeeNumber != null && r.Employee.EmployeeNumber.Contains(keyword, StringComparison.OrdinalIgnoreCase)));
        }

        return query;
    }

    private PagedResult<LeaveRequestSummaryDto> Project(
        IOrderedQueryable<LeaveRequest> query,
        int pageNumber,
        int pageSize)
    {
        var total = query.Count();
        var items = query
            .Skip(Math.Max(pageNumber - 1, 0) * pageSize)
            .Take(pageSize)
            .Select(ToSummary)
            .ToList();

        return new PagedResult<LeaveRequestSummaryDto>(items, total, pageNumber, pageSize);
    }

    private LeaveRequestSummaryDto ToSummary(LeaveRequest request)
    {
        var employeeName = _employees.TryGetValue(request.EmployeeId, out var employee)
            ? employee.FullName
            : request.Employee?.FullName ?? "Unknown";

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

    private static LeaveRequest? Clone(LeaveRequest? request)
    {
        if (request is null)
        {
            return null;
        }

        return new LeaveRequest
        {
            Id = request.Id,
            EmployeeId = request.EmployeeId,
            Reference = request.Reference,
            LeaveType = request.LeaveType,
            Reason = request.Reason,
            IsHalfDay = request.IsHalfDay,
            ContactDuringLeave = request.ContactDuringLeave,
            StartDate = request.StartDate,
            EndDate = request.EndDate,
            Status = request.Status,
            RequestedOn = request.RequestedOn,
            ApproverId = request.ApproverId,
            ApproverName = request.ApproverName,
            DecisionOn = request.DecisionOn,
            ManagerComment = request.ManagerComment,
            SupportingDocumentUrl = request.SupportingDocumentUrl,
            Employee = request.Employee is null
                ? null
                : new Employee
                {
                    Id = request.Employee.Id,
                    EmployeeNumber = request.Employee.EmployeeNumber,
                    FullName = request.Employee.FullName,
                    Department = request.Employee.Department,
                    Position = request.Employee.Position,
                    Status = request.Employee.Status
                }
        };
    }

    private static decimal GetDuration(LeaveRequest request)
    {
        if (request.IsHalfDay)
        {
            return 0.5m;
        }

        var span = (decimal)(request.EndDate.Date - request.StartDate.Date).TotalDays + 1;
        return Math.Max(0.5m, span);
    }
}
