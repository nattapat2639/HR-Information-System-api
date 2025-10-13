using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Hris.Application.DTOs.Common;
using Hris.Application.DTOs.Organization;
using Hris.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hris.Api.Controllers;

[ApiController]
[Route("api/organization")]
public class OrganizationController : ControllerBase
{
    private readonly HrisDbContext _context;

    public OrganizationController(HrisDbContext context)
    {
        _context = context;
    }

    [HttpPost("structure/sync")]
    public async Task<ActionResult<ActionResponse>> SyncStructure(CancellationToken cancellationToken)
    {
        var now = DateTime.UtcNow;
        var entries = await _context.WorkforcePlanEntries.ToListAsync(cancellationToken);

        foreach (var entry in entries)
        {
            entry.UpdatedAtUtc = now;
        }

        await _context.SaveChangesAsync(cancellationToken);

        return Ok(new ActionResponse("ORGANIZATION.STRUCTURE.SYNC_SUCCESS", TimestampUtc: now));
    }

    [HttpPost("workforce-plan/publish")]
    public async Task<ActionResult<ActionResponse>> PublishWorkforcePlan(CancellationToken cancellationToken)
    {
        var now = DateTime.UtcNow;
        var entries = await _context.WorkforcePlanEntries.ToListAsync(cancellationToken);

        foreach (var entry in entries)
        {
            entry.UpdatedAtUtc = now;
        }

        await _context.SaveChangesAsync(cancellationToken);

        return Ok(new ActionResponse("ORGANIZATION.WORKFORCE_PLAN.PUBLISH_SUCCESS", TimestampUtc: now));
    }

    [HttpPost("workforce-plan/request")]
    public async Task<ActionResult<ActionResponse>> CreateHeadcountRequest(
        [FromBody] HeadcountRequestDto request,
        CancellationToken cancellationToken)
    {
        if (string.IsNullOrWhiteSpace(request.Department) || request.RequestedHeadcount <= 0)
        {
            return BadRequest(new ActionResponse("ORGANIZATION.WORKFORCE_PLAN.REQUEST_INVALID", "Department and headcount are required"));
        }

        var entity = new Hris.Domain.Entities.HeadcountRequest
        {
            Id = Guid.NewGuid(),
            Department = request.Department,
            RequestedHeadcount = request.RequestedHeadcount,
            RequestedBy = string.IsNullOrWhiteSpace(request.RequestedBy) ? "Unknown" : request.RequestedBy,
            Justification = request.Justification ?? string.Empty,
            Status = "Pending",
            RequestedAtUtc = DateTime.UtcNow
        };

        await _context.HeadcountRequests.AddAsync(entity, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);

        return Ok(new ActionResponse("ORGANIZATION.WORKFORCE_PLAN.REQUEST_CREATED", entity.Department, entity.RequestedAtUtc));
    }

    [HttpGet("structure/export")]
    public async Task<IActionResult> ExportStructure(
        [FromQuery] string? department = null,
        [FromQuery] string? attrition = null,
        CancellationToken cancellationToken = default)
    {
        var filters = new OrganizationSnapshotFilters(department, attrition);
        var (structureRows, _) = await BuildOrganizationSnapshots(filters, cancellationToken);

        var builder = new StringBuilder();
        builder.AppendLine("Department,Lead,Headcount,OpenRoles,Focus");

        foreach (var row in structureRows)
        {
            builder.AppendLine(string.Join(",", row.Select(EscapeCsv)));
        }

        var fileName = $"organization-structure-{DateTime.UtcNow:yyyyMMddHHmmss}.csv";
        return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", fileName);
    }

    [HttpGet("workforce-plan/export")]
    public async Task<IActionResult> ExportWorkforcePlan(
        [FromQuery] string? department = null,
        [FromQuery] string? attrition = null,
        CancellationToken cancellationToken = default)
    {
        var filters = new OrganizationSnapshotFilters(department, attrition);
        var (_, planRows) = await BuildOrganizationSnapshots(filters, cancellationToken);

        var builder = new StringBuilder();
        builder.AppendLine("Department,CurrentHeadcount,ApprovedQ3,AttritionRisk,NextHire");

        foreach (var row in planRows)
        {
            builder.AppendLine(string.Join(",", row.Select(EscapeCsv)));
        }

        var fileName = $"workforce-plan-{DateTime.UtcNow:yyyyMMddHHmmss}.csv";
        return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", fileName);
    }

    [HttpGet("overview")]
    public async Task<ActionResult<OrganizationOverviewDto>> GetOverview(
        [FromQuery] string? department = null,
        [FromQuery] string? attrition = null,
        CancellationToken cancellationToken = default)
    {
        var filters = new OrganizationSnapshotFilters(department, attrition);

        var planEntries = await _context.WorkforcePlanEntries
            .AsNoTracking()
            .OrderBy(entry => entry.Department)
            .ToListAsync(cancellationToken);

        var filteredEntries = planEntries
            .Where(entry => MatchesFilter(entry.Department, filters.Department))
            .Where(entry => MatchesFilter(entry.AttritionRisk, filters.AttritionRisk))
            .ToList();

        var relevantDepartments = filteredEntries
            .Select(entry => entry.Department ?? "Unassigned")
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .ToArray();

        var employeesQuery = _context.Employees.AsNoTracking();
        if (relevantDepartments.Length > 0)
        {
            var normalizedDepartments = relevantDepartments
                .Select(value => value.ToLowerInvariant())
                .ToArray();

            employeesQuery = employeesQuery.Where(employee =>
                employee.Department != null &&
                normalizedDepartments.Contains(employee.Department.ToLower()));
        }

        var employees = await employeesQuery.ToListAsync(cancellationToken);
        var headcountLookup = employees
            .GroupBy(employee => employee.Department ?? "Unassigned")
            .ToDictionary(
                group => group.Key,
                group => group.Count(),
                StringComparer.OrdinalIgnoreCase);

        var departmentPlans = filteredEntries
            .Select(entry =>
            {
                var departmentKey = entry.Department ?? "Unassigned";
                var currentHeadcount = headcountLookup.TryGetValue(departmentKey, out var count) ? count : 0;
                var openRoles = Math.Max(entry.ApprovedHeadcountQ3 - currentHeadcount, 0);

                return new DepartmentPlanSummaryDto(
                    departmentKey,
                    entry.DepartmentLead,
                    entry.Focus,
                    currentHeadcount,
                    entry.ApprovedHeadcountQ3,
                    openRoles,
                    entry.AttritionRisk);
            })
            .OrderByDescending(plan => plan.OpenRoles)
            .ThenBy(plan => plan.Department, StringComparer.OrdinalIgnoreCase)
            .ToList();

        var totalHeadcount = departmentPlans.Sum(plan => plan.CurrentHeadcount);
        var totalApproved = departmentPlans.Sum(plan => plan.ApprovedHeadcount);
        var totalOpenRoles = departmentPlans.Sum(plan => plan.OpenRoles);
        var departmentCount = departmentPlans
            .Select(plan => plan.Department)
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .Count();

        var attritionBreakdown = filteredEntries
            .GroupBy(entry => string.IsNullOrWhiteSpace(entry.AttritionRisk) ? "Unknown" : entry.AttritionRisk)
            .Select(group => new AttritionBreakdownDto(group.Key, group.Count()))
            .OrderByDescending(item => item.Count)
            .ThenBy(item => item.RiskLevel, StringComparer.OrdinalIgnoreCase)
            .ToList();

        var focusAreas = filteredEntries
            .GroupBy(entry => string.IsNullOrWhiteSpace(entry.Focus) ? "Unspecified" : entry.Focus)
            .Select(group => new FocusAreaSummaryDto(group.Key, group.Count()))
            .OrderByDescending(item => item.DepartmentCount)
            .ThenBy(item => item.FocusArea, StringComparer.OrdinalIgnoreCase)
            .ToList();

        var lastSynced = filteredEntries.Count > 0
            ? filteredEntries.Max(entry => entry.UpdatedAtUtc)
            : (DateTime?)null;

        var overview = new OrganizationOverviewDto(
            lastSynced,
            totalHeadcount,
            totalOpenRoles,
            departmentCount,
            totalApproved,
            attritionBreakdown,
            departmentPlans,
            focusAreas);

        return Ok(overview);
    }

    private async Task<(IReadOnlyList<string[]>, IReadOnlyList<string[]>)> BuildOrganizationSnapshots(
        OrganizationSnapshotFilters filters,
        CancellationToken cancellationToken)
    {
        var planEntries = await _context.WorkforcePlanEntries
            .AsNoTracking()
            .OrderBy(entry => entry.Department)
            .ToListAsync(cancellationToken);

        var filteredEntries = planEntries
            .Where(entry => MatchesFilter(entry.Department, filters.Department))
            .Where(entry => MatchesFilter(entry.AttritionRisk, filters.AttritionRisk))
            .ToList();

        var relevantDepartments = filteredEntries
            .Select(entry => entry.Department ?? "Unassigned")
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .ToArray();

        var headcountQuery = _context.Employees.AsNoTracking();
        if (relevantDepartments.Length > 0)
        {
            var normalizedDepartments = relevantDepartments
                .Select(value => value.ToLowerInvariant())
                .ToArray();

            headcountQuery = headcountQuery.Where(employee =>
                employee.Department != null &&
                normalizedDepartments.Contains(employee.Department.ToLower()));
        }

        var headcountLookup = await headcountQuery
            .GroupBy(employee => employee.Department)
            .Select(group => new { group.Key, Count = group.Count() })
            .ToDictionaryAsync(x => x.Key ?? "Unassigned", x => x.Count, StringComparer.OrdinalIgnoreCase, cancellationToken);

        var structureRows = filteredEntries.Select(entry =>
        {
            var departmentKey = entry.Department ?? "Unassigned";
            var currentHeadcount = headcountLookup.TryGetValue(departmentKey, out var count) ? count : 0;
            var openRoles = Math.Max(entry.ApprovedHeadcountQ3 - currentHeadcount, 0);

            return new[]
            {
                departmentKey,
                entry.DepartmentLead ?? string.Empty,
                currentHeadcount.ToString(CultureInfo.InvariantCulture),
                openRoles.ToString(CultureInfo.InvariantCulture),
                entry.Focus ?? string.Empty
            };
        }).ToList();

        var planRows = filteredEntries.Select(entry =>
        {
            var departmentKey = entry.Department ?? "Unassigned";
            var currentHeadcount = headcountLookup.TryGetValue(departmentKey, out var count) ? count : 0;

            return new[]
            {
                departmentKey,
                currentHeadcount.ToString(CultureInfo.InvariantCulture),
                entry.ApprovedHeadcountQ3.ToString(CultureInfo.InvariantCulture),
                entry.AttritionRisk ?? string.Empty,
                entry.NextCriticalHire ?? string.Empty
            };
        }).ToList();

        return (structureRows, planRows);
    }

    private static string EscapeCsv(string value)
    {
        if (value.Contains(',') || value.Contains('"'))
        {
            var escaped = value.Replace("\"", "\"\"");
            return $"\"{escaped}\"";
        }

        return value;
    }

    private sealed record OrganizationSnapshotFilters(string? Department, string? AttritionRisk);

    private static bool MatchesFilter(string? value, string? filter)
    {
        if (string.IsNullOrWhiteSpace(filter))
        {
            return true;
        }

        if (string.IsNullOrWhiteSpace(value))
        {
            return false;
        }

        return string.Equals(value.Trim(), filter.Trim(), StringComparison.OrdinalIgnoreCase);
    }
}
