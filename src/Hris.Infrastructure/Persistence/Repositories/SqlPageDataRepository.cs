using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Hris.Application.DTOs.PageData;
using Hris.Application.Interfaces.Repositories;
using Hris.Domain.Entities;
using Hris.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace Hris.Infrastructure.Persistence.Repositories;

public class SqlPageDataRepository : IPageDataRepository
{
    private static readonly Guid DefaultEmployeeId = Guid.Parse("11111111-1111-1111-1111-111111111111");
    private static readonly Guid DefaultPayrollEmployeeId = Guid.Parse("33333333-3333-3333-3333-333333333333");
    private static readonly Guid DefaultPerformanceEmployeeId = Guid.Parse("11111111-1111-1111-1111-111111111111");
    private static readonly Guid DefaultTrainingEmployeeId = Guid.Parse("22222222-2222-2222-2222-222222222222");
    private static readonly DateTime HistoricCutoffDate = new(2025, 1, 1);

    private static readonly Dictionary<string, string[]> FilterSynonyms = new(StringComparer.OrdinalIgnoreCase)
    {
        ["COMMON.DEPARTMENTS.HR"] = new[] { "People Operations", "Human Resources", "HR" },
        ["COMMON.DEPARTMENTS.IT"] = new[] { "Technology", "IT" },
        ["COMMON.DEPARTMENTS.FINANCE"] = new[] { "Finance" },
        ["COMMON.DEPARTMENTS.MARKETING"] = new[] { "Marketing" },
        ["COMMON.DEPARTMENTS.CUSTOMER_SUCCESS"] = new[] { "Customer Success", "CS" },
        ["COMMON.DEPARTMENTS.OPERATIONS"] = new[] { "Operations" },
        ["COMMON.DEPARTMENTS.SALES"] = new[] { "Sales" },
        ["COMMON.DEPARTMENTS.DATA_ANALYTICS"] = new[] { "Data & Analytics", "Analytics" },
        ["COMMON.DEPARTMENTS.ALL"] = Array.Empty<string>(),
        ["COMMON.LOCATIONS.HQ"] = new[] { "Headquarters", "HQ" },
        ["COMMON.LOCATIONS.REGIONAL"] = new[] { "Regional offices", "Regional" },
        ["COMMON.LOCATIONS.ALL"] = Array.Empty<string>(),
        ["COMMON.ROLES.USER"] = new[] { "Employee" },
        ["COMMON.ROLES.MANAGER"] = new[] { "Manager" },
        ["COMMON.ROLES.ADMIN"] = new[] { "Administrator" },
        ["COMMON.ROLES.ALL"] = Array.Empty<string>(),
        ["COMMON.STATUSES.ACTIVE"] = new[] { "Active" },
        ["COMMON.STATUSES.INACTIVE"] = new[] { "Inactive" },
        ["COMMON.STATUSES.ONBOARDING"] = new[] { "Onboarding", "Probation" },
        ["COMMON.STATUSES.PENDING"] = new[] { "Pending" },
        ["COMMON.STATUSES.APPROVED"] = new[] { "Approved" },
        ["COMMON.STATUSES.REJECTED"] = new[] { "Rejected", "Declined" },
        ["COMMON.STATUSES.IN_PROGRESS"] = new[] { "In Progress", "Probation" },
        ["COMMON.STATUSES.COMPLETED"] = new[] { "Completed" },
        ["COMMON.STATUSES.SUBMITTED"] = new[] { "Submitted" },
        ["COMMON.STATUSES.CLOSED"] = new[] { "Closed" },
        ["COMMON.STATUSES.SUSPENDED"] = new[] { "Suspended" },
        ["COMMON.STATUSES.ON_LEAVE"] = new[] { "On Leave" },
        ["COMMON.STATUSES.PROBATION"] = new[] { "Probation" },
        ["COMMON.STATUSES.ALL"] = Array.Empty<string>(),
        ["PAGES.LEAVE.OPTIONS.ALL_TYPES"] = Array.Empty<string>(),
        ["PAGES.LEAVE.OPTIONS.ANNUAL"] = new[] { "Annual Leave" },
        ["PAGES.LEAVE.OPTIONS.SICK"] = new[] { "Sick Leave" },
        ["PAGES.LEAVE.OPTIONS.UNPAID"] = new[] { "Unpaid Leave" },
        ["COMMON.PERIODS.CURRENT_MONTH"] = new[] { "March 2025", "Current Month" },
        ["COMMON.PERIODS.LAST_MONTH"] = new[] { "February 2025", "Last Month" },
        ["COMMON.PERIODS.THIS_MONTH"] = new[] { "This Month" },
        ["COMMON.PERIODS.THIS_QUARTER"] = new[] { "This Quarter" },
        ["COMMON.PERIODS.CURRENT_QUARTER"] = new[] { "Current Quarter" },
        ["COMMON.PERIODS.LAST_QUARTER"] = new[] { "Last Quarter" },
        ["COMMON.PERIODS.CURRENT_YEAR"] = new[] { "2025", "Current Year" },
        ["COMMON.PERIODS.LAST_YEAR"] = new[] { "2024", "Last Year" },
        ["COMMON.PERIODS.NEXT_YEAR"] = new[] { "2026", "Next Year" },
        ["COMMON.PERIODS.CUSTOM"] = Array.Empty<string>(),
        ["PAGES.PAYROLL.GENERATE.PAY_GROUPS.MONTHLY"] = new[] { "Monthly" },
        ["PAGES.PAYROLL.GENERATE.PAY_GROUPS.BI_WEEKLY"] = new[] { "Bi-weekly" },
        ["PAGES.TRAINING.CATEGORIES.ALL"] = Array.Empty<string>(),
        ["PAGES.TRAINING.CATEGORIES.TECHNICAL"] = new[] { "Technical", "Technical Skills" },
        ["PAGES.TRAINING.CATEGORIES.SOFT_SKILL"] = new[] { "Soft skills" },
        ["COMMON.MONTHS.CURRENT"] = new[] { "March", "March 2025" },
        ["COMMON.MONTHS.NEXT"] = new[] { "April", "April 2025" },
        ["COMMON.YEARS.CURRENT"] = new[] { "2025", "Current Year" },
        ["COMMON.YEARS.LAST"] = new[] { "2024", "Last Year" },
        ["PAGES.PERFORMANCE.CREATE.TEMPLATES.STANDARD"] = new[] { "Standard" },
        ["PAGES.PERFORMANCE.CREATE.TEMPLATES.CUSTOM"] = new[] { "Custom" },
        ["PAGES.ENGAGEMENT.RESULTS.OPTIONS.LATEST"] = new[] { "Latest survey" },
        ["PAGES.ENGAGEMENT.RESULTS.OPTIONS.CUSTOM"] = Array.Empty<string>(),
        ["PAGES.REPORTS.EXPORT.FORMATS.CSV"] = new[] { "CSV" },
        ["PAGES.REPORTS.EXPORT.FORMATS.XLSX"] = new[] { "Excel (.xlsx)" },
        ["PAGES.REPORTS.EXPORT.FORMATS.PDF"] = new[] { "PDF" },
        ["PAGES.REPORTS.EXPORT.DATASETS.EMPLOYEE"] = new[] { "Employee master" },
        ["PAGES.REPORTS.EXPORT.DATASETS.LEAVE"] = new[] { "Leave transactions" },
        ["PAGES.REPORTS.EXPORT.DATASETS.PAYROLL"] = new[] { "Payroll summary" },
        ["PAGES.SETTINGS.SYSTEM.TIMEZONES.BKK"] = new[] { "(UTC+07:00) Bangkok" },
        ["PAGES.SETTINGS.SYSTEM.TIMEZONES.UTC"] = new[] { "(UTC) Coordinated Universal Time" },
        ["PAGES.SETTINGS.SYSTEM.WORKWEEKS.STANDARD"] = new[] { "Monday to Friday" },
        ["PAGES.SETTINGS.SYSTEM.WORKWEEKS.CUSTOM"] = new[] { "Custom schedule" },
        ["PAGES.SETTINGS.NOTIFICATIONS.CHANNELS.EMAIL"] = new[] { "Email" },
        ["PAGES.SETTINGS.NOTIFICATIONS.CHANNELS.SMS"] = new[] { "SMS" },
        ["PAGES.SETTINGS.NOTIFICATIONS.CHANNELS.IN_APP"] = new[] { "In-app" },
        ["PAGES.SETTINGS.NOTIFICATIONS.FREQUENCIES.REALTIME"] = new[] { "Real-time" },
        ["PAGES.SETTINGS.NOTIFICATIONS.FREQUENCIES.DAILY"] = new[] { "Daily" },
        ["PAGES.SETTINGS.NOTIFICATIONS.FREQUENCIES.WEEKLY"] = new[] { "Weekly" },
        ["PAGES.SETTINGS.SECURITY.MFA.REQUIRED"] = new[] { "Required" },
        ["PAGES.SETTINGS.SECURITY.MFA.OPTIONAL"] = new[] { "Optional" },
        ["PAGES.SETTINGS.SECURITY.PASSWORD_POLICY.STANDARD"] = new[] { "Standard" },
        ["PAGES.SETTINGS.SECURITY.PASSWORD_POLICY.STRICT"] = new[] { "Strict" }
    };

    private static readonly HashSet<string> ReservedQueryKeys = new(StringComparer.OrdinalIgnoreCase)
    {
        "pagenumber",
        "pagesize",
        "startdate",
        "enddate",
        "opendate",
        "closedate",
        "submittedon"
    };

    private readonly HrisDbContext _context;

    public SqlPageDataRepository(HrisDbContext context)
    {
        _context = context;
    }

    public async Task<PageDataDto?> GetPageAsync(
        string module,
        string page,
        int pageNumber,
        int pageSize,
        IReadOnlyDictionary<string, string> filters,
        CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(module) || string.IsNullOrWhiteSpace(page))
        {
            return null;
        }

        pageNumber = Math.Max(1, pageNumber);
        pageSize = Math.Clamp(pageSize, 1, 200);

        var normalizedModule = module.Trim().ToLowerInvariant();
        var normalizedPage = page.Trim().ToLowerInvariant();

        return normalizedModule switch
        {
            "dashboard" => CreateNoteOnlyPage(module, page, pageNumber, pageSize, "PAGES.DASHBOARD.TODO"),
            "organization" => await GetOrganizationPageAsync(module, page, normalizedPage, pageNumber, pageSize, cancellationToken),
            "employee-records" => await GetEmployeeRecordsPageAsync(module, page, normalizedPage, pageNumber, pageSize, filters, cancellationToken),
            "leave-management" => await GetLeaveManagementPageAsync(module, page, normalizedPage, pageNumber, pageSize, filters, cancellationToken),
            "payroll" => await GetPayrollPageAsync(module, page, normalizedPage, pageNumber, pageSize, filters, cancellationToken),
            "performance" => await GetPerformancePageAsync(module, page, normalizedPage, pageNumber, pageSize, filters, cancellationToken),
            "training" => await GetTrainingPageAsync(module, page, normalizedPage, pageNumber, pageSize, filters, cancellationToken),
            "engagement" => await GetEngagementPageAsync(module, page, normalizedPage, pageNumber, pageSize, filters, cancellationToken),
            "reports" => await GetReportsPageAsync(module, page, normalizedPage, pageNumber, pageSize, filters, cancellationToken),
            "users" => await GetUsersPageAsync(module, page, normalizedPage, pageNumber, pageSize, filters, cancellationToken),
            "settings" => GetSettingsPage(module, page, normalizedPage, pageNumber, pageSize),
            _ => null
        };
    }

    private Task<PageDataDto?> GetEmployeeRecordsPageAsync(
        string module,
        string page,
        string normalizedPage,
        int pageNumber,
        int pageSize,
        IReadOnlyDictionary<string, string> filters,
        CancellationToken cancellationToken)
    {
        var query = _context.Employees.AsNoTracking();
        return normalizedPage switch
        {
            "all" => BuildPageAsync(
                module,
                page,
                noteKey: null,
                pageNumber,
                pageSize,
                filters,
                query,
                new Expression<Func<Employee, string?>>[]
                {
                    e => e.EmployeeNumber,
                    e => e.FullName,
                    e => e.Department,
                    e => e.Position,
                    e => e.Status
                },
                q => q.OrderBy(e => e.EmployeeNumber),
                employee => CreateRow(
                    ("PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.EMPLOYEE_ID", employee.EmployeeNumber),
                    ("PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.NAME", employee.FullName),
                    ("PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.POSITION", employee.Position),
                    ("PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.DEPARTMENT", employee.Department),
                    ("PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.STATUS", employee.Status ?? string.Empty)),
                cancellationToken: cancellationToken),
            "search" => BuildPageAsync(
                module,
                page,
                noteKey: "PAGES.EMPLOYEE_RECORDS.SEARCH.TODO",
                pageNumber,
                pageSize,
                filters,
                query,
                new Expression<Func<Employee, string?>>[]
                {
                    e => e.EmployeeNumber,
                    e => e.FullName,
                    e => e.Department,
                    e => e.Position
                },
                q => q.OrderBy(e => e.FullName),
                employee => CreateRow(
                    ("PAGES.EMPLOYEE_RECORDS.SEARCH.COLUMNS.EMPLOYEE_ID", employee.EmployeeNumber),
                    ("PAGES.EMPLOYEE_RECORDS.SEARCH.COLUMNS.NAME", employee.FullName),
                    ("PAGES.EMPLOYEE_RECORDS.SEARCH.COLUMNS.DEPARTMENT", employee.Department),
                    ("PAGES.EMPLOYEE_RECORDS.SEARCH.COLUMNS.LEVEL", ResolveLevelFromPosition(employee.Position))),
                cancellationToken: cancellationToken),
            "profile" => Task.FromResult<PageDataDto?>(CreateNoteOnlyPage(module, page, pageNumber, pageSize, "PAGES.EMPLOYEE_RECORDS.PROFILE.TODO")),
            _ => Task.FromResult<PageDataDto?>(null)
        };
    }

    private Task<PageDataDto?> GetOrganizationPageAsync(
        string module,
        string page,
        string normalizedPage,
        int pageNumber,
        int pageSize,
        CancellationToken cancellationToken)
    {
        var structureRows = new[]
        {
            CreateRow(
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.DEPARTMENT", "People Operations"),
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.LEAD", "Chanon Phumiphak"),
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.HEADCOUNT", "8"),
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.OPEN_ROLES", "1"),
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.FOCUS", "HR strategy, talent development")),
            CreateRow(
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.DEPARTMENT", "Technology"),
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.LEAD", "Anuwat Khem"),
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.HEADCOUNT", "14"),
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.OPEN_ROLES", "3"),
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.FOCUS", "Product delivery, platform reliability")),
            CreateRow(
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.DEPARTMENT", "Finance"),
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.LEAD", "Benjamas Sriwilai"),
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.HEADCOUNT", "6"),
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.OPEN_ROLES", "1"),
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.FOCUS", "Payroll, budgeting, treasury")),
            CreateRow(
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.DEPARTMENT", "Marketing"),
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.LEAD", "Oranicha Mek"),
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.HEADCOUNT", "6"),
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.OPEN_ROLES", "1"),
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.FOCUS", "Demand generation, brand growth")),
            CreateRow(
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.DEPARTMENT", "Customer Success"),
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.LEAD", "Jirawat Kan"),
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.HEADCOUNT", "5"),
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.OPEN_ROLES", "0"),
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.FOCUS", "Onboarding, renewals, support excellence")),
            CreateRow(
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.DEPARTMENT", "Operations"),
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.LEAD", "Amara Jittrakorn"),
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.HEADCOUNT", "5"),
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.OPEN_ROLES", "1"),
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.FOCUS", "Facilities, procurement, logistics")),
            CreateRow(
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.DEPARTMENT", "Sales"),
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.LEAD", "Pimchanok Rukdee"),
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.HEADCOUNT", "3"),
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.OPEN_ROLES", "1"),
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.FOCUS", "Enterprise acquisition, account growth")),
            CreateRow(
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.DEPARTMENT", "Data & Analytics"),
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.LEAD", "Piyada Sornchai"),
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.HEADCOUNT", "3"),
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.OPEN_ROLES", "1"),
                ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.FOCUS", "Insights, dashboards, data governance"))
        };

        var workforceRows = new[]
        {
            CreateRow(
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.DEPARTMENT", "People Operations"),
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.CURRENT_HEADCOUNT", "8"),
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.APPROVED_Q3", "9"),
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.ATTRITION_RISK", "Low"),
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.NEXT_HIRE", "HR Business Partner")),
            CreateRow(
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.DEPARTMENT", "Technology"),
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.CURRENT_HEADCOUNT", "14"),
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.APPROVED_Q3", "16"),
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.ATTRITION_RISK", "Medium"),
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.NEXT_HIRE", "Senior Backend Engineer")),
            CreateRow(
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.DEPARTMENT", "Finance"),
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.CURRENT_HEADCOUNT", "6"),
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.APPROVED_Q3", "6"),
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.ATTRITION_RISK", "Low"),
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.NEXT_HIRE", "Revenue Assurance Analyst")),
            CreateRow(
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.DEPARTMENT", "Marketing"),
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.CURRENT_HEADCOUNT", "6"),
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.APPROVED_Q3", "7"),
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.ATTRITION_RISK", "Medium"),
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.NEXT_HIRE", "Lifecycle Marketer")),
            CreateRow(
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.DEPARTMENT", "Customer Success"),
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.CURRENT_HEADCOUNT", "5"),
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.APPROVED_Q3", "5"),
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.ATTRITION_RISK", "Low"),
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.NEXT_HIRE", "Technical Account Manager")),
            CreateRow(
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.DEPARTMENT", "Operations"),
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.CURRENT_HEADCOUNT", "5"),
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.APPROVED_Q3", "6"),
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.ATTRITION_RISK", "Medium"),
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.NEXT_HIRE", "Facilities Supervisor")),
            CreateRow(
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.DEPARTMENT", "Sales"),
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.CURRENT_HEADCOUNT", "3"),
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.APPROVED_Q3", "4"),
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.ATTRITION_RISK", "High"),
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.NEXT_HIRE", "Enterprise Account Executive")),
            CreateRow(
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.DEPARTMENT", "Data & Analytics"),
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.CURRENT_HEADCOUNT", "3"),
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.APPROVED_Q3", "4"),
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.ATTRITION_RISK", "Medium"),
                ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.NEXT_HIRE", "Analytics Engineer"))
        };

        return normalizedPage switch
        {
            "structure" => Task.FromResult<PageDataDto?>(CreateStaticPage(module, page, pageNumber, pageSize, "PAGES.ORGANIZATION.STRUCTURE.NOTE", structureRows)),
            "workforce-plan" => Task.FromResult<PageDataDto?>(CreateStaticPage(module, page, pageNumber, pageSize, "PAGES.ORGANIZATION.WORKFORCE_PLAN.NOTE", workforceRows)),
            _ => Task.FromResult<PageDataDto?>(null)
        };
    }

    private Task<PageDataDto?> GetLeaveManagementPageAsync(
        string module,
        string page,
        string normalizedPage,
        int pageNumber,
        int pageSize,
        IReadOnlyDictionary<string, string> filters,
        CancellationToken cancellationToken)
    {
        var query = _context.LeaveRequests
            .AsNoTracking()
            .Include(l => l.Employee);

        return normalizedPage switch
        {
            "my" => BuildPageAsync(
                module,
                page,
                noteKey: null,
                pageNumber,
                pageSize,
                filters,
                query.Where(l => l.EmployeeId == DefaultEmployeeId)
                     .OrderByDescending(l => l.StartDate),
                new Expression<Func<LeaveRequest, string?>>[]
                {
                    l => l.Reference,
                    l => l.LeaveType,
                    l => l.Status
                },
                q => q,
                leave => CreateRow(
                    ("PAGES.LEAVE.MY.COLUMNS.REFERENCE", leave.Reference),
                    ("PAGES.LEAVE.MY.COLUMNS.TYPE", leave.LeaveType),
                    ("PAGES.LEAVE.MY.COLUMNS.START", FormatDate(leave.StartDate)),
                    ("PAGES.LEAVE.MY.COLUMNS.END", FormatDate(leave.EndDate)),
                    ("PAGES.LEAVE.MY.COLUMNS.STATUS", leave.Status)),
                applyCustomFilters: ApplyLeaveRequestFilters,
                cancellationToken: cancellationToken),
            "team" => BuildPageAsync(
                module,
                page,
                noteKey: null,
                pageNumber,
                pageSize,
                filters,
                query.Where(l => l.EmployeeId != DefaultEmployeeId && l.StartDate >= HistoricCutoffDate)
                     .OrderByDescending(l => l.StartDate),
                new Expression<Func<LeaveRequest, string?>>[]
                {
                    l => l.Reference,
                    l => l.LeaveType,
                    l => l.Status,
                    l => l.Employee != null ? l.Employee.FullName : null
                },
                q => q,
                leave => CreateRow(
                    ("PAGES.LEAVE.TEAM.COLUMNS.EMPLOYEE", leave.Employee?.FullName ?? "Unknown"),
                    ("PAGES.LEAVE.TEAM.COLUMNS.TYPE", leave.LeaveType),
                    ("PAGES.LEAVE.TEAM.COLUMNS.PERIOD", $"{FormatDate(leave.StartDate)} to {FormatDate(leave.EndDate)}"),
                    ("PAGES.LEAVE.TEAM.COLUMNS.STATUS", leave.Status),
                    ("PAGES.LEAVE.TEAM.COLUMNS.REQUESTED_ON", FormatDate(leave.RequestedOn))),
                applyCustomFilters: ApplyLeaveRequestFilters,
                cancellationToken: cancellationToken),
            "history" => BuildPageAsync(
                module,
                page,
                noteKey: null,
                pageNumber,
                pageSize,
                filters,
                query.Where(l => l.EndDate < HistoricCutoffDate)
                     .OrderByDescending(l => l.StartDate),
                new Expression<Func<LeaveRequest, string?>>[]
                {
                    l => l.Reference,
                    l => l.LeaveType,
                    l => l.Status
                },
                q => q,
                leave =>
                {
                    var daysUsed = Math.Max(1, (leave.EndDate - leave.StartDate).Days + 1);
                    return CreateRow(
                        ("PAGES.LEAVE.HISTORY.COLUMNS.REFERENCE", leave.Reference),
                        ("PAGES.LEAVE.HISTORY.COLUMNS.TYPE", leave.LeaveType),
                        ("PAGES.LEAVE.HISTORY.COLUMNS.PERIOD", $"{FormatDate(leave.StartDate)} to {FormatDate(leave.EndDate)}"),
                        ("PAGES.LEAVE.HISTORY.COLUMNS.DAY_USED", daysUsed.ToString(CultureInfo.InvariantCulture)),
                        ("PAGES.LEAVE.HISTORY.COLUMNS.STATUS", leave.Status));
                },
                applyCustomFilters: ApplyLeaveRequestFilters,
                cancellationToken: cancellationToken),
            "create" => Task.FromResult<PageDataDto?>(CreateNoteOnlyPage(module, page, pageNumber, pageSize, "PAGES.LEAVE.CREATE.TODO")),
            _ => Task.FromResult<PageDataDto?>(null)
        };
    }

    private Task<PageDataDto?> GetPayrollPageAsync(
        string module,
        string page,
        string normalizedPage,
        int pageNumber,
        int pageSize,
        IReadOnlyDictionary<string, string> filters,
        CancellationToken cancellationToken)
    {
        return normalizedPage switch
        {
            "my" => BuildPageAsync(
                module,
                page,
                noteKey: null,
                pageNumber,
                pageSize,
                filters,
                _context.PayslipComponents
                    .AsNoTracking()
                    .Where(p => p.EmployeeId == DefaultPayrollEmployeeId),
                new Expression<Func<EmployeePayslipComponent, string?>>[]
                {
                    p => p.ComponentName,
                    p => p.Notes
                },
                q => q.OrderBy(p => p.ComponentName),
                component => CreateRow(
                    ("PAGES.PAYROLL.MY.COLUMNS.COMPONENT", component.ComponentName),
                    ("PAGES.PAYROLL.MY.COLUMNS.AMOUNT", FormatCurrency(component.Amount)),
                    ("PAGES.PAYROLL.MY.COLUMNS.NOTES", component.Notes ?? string.Empty)),
                cancellationToken: cancellationToken),
            "summary" => BuildPageAsync(
                module,
                page,
                noteKey: null,
                pageNumber,
                pageSize,
                filters,
                _context.PayrollSummaries.AsNoTracking(),
                new Expression<Func<PayrollSummaryRecord, string?>>[]
                {
                    r => r.Department,
                    r => r.Period,
                    r => r.Status
                },
                q => q.OrderBy(r => r.Department),
                summary => CreateRow(
                    ("PAGES.PAYROLL.SUMMARY.COLUMNS.DEPARTMENT", summary.Department),
                    ("PAGES.PAYROLL.SUMMARY.COLUMNS.TOTAL_EMPLOYEES", summary.TotalEmployees.ToString(CultureInfo.InvariantCulture)),
                    ("PAGES.PAYROLL.SUMMARY.COLUMNS.GROSS_PAY", FormatCurrency(summary.GrossPay)),
                    ("PAGES.PAYROLL.SUMMARY.COLUMNS.NET_PAY", FormatCurrency(summary.NetPay))),
                cancellationToken: cancellationToken),
            "generate" => Task.FromResult<PageDataDto?>(CreateNoteOnlyPage(module, page, pageNumber, pageSize, "PAGES.PAYROLL.GENERATE.TODO")),
            _ => Task.FromResult<PageDataDto?>(null)
        };
    }

    private Task<PageDataDto?> GetPerformancePageAsync(
        string module,
        string page,
        string normalizedPage,
        int pageNumber,
        int pageSize,
        IReadOnlyDictionary<string, string> filters,
        CancellationToken cancellationToken)
    {
        var query = _context.PerformanceReviews
            .AsNoTracking()
            .Include(r => r.Employee);

        return normalizedPage switch
        {
            "my" => BuildPageAsync(
                module,
                page,
                noteKey: null,
                pageNumber,
                pageSize,
                filters,
                query.Where(r => r.EmployeeId == DefaultPerformanceEmployeeId)
                     .OrderByDescending(r => r.ReviewCycle),
                new Expression<Func<PerformanceReview, string?>>[]
                {
                    r => r.ReviewCycle,
                    r => r.ManagerName,
                    r => r.Status
                },
                q => q,
                review => CreateRow(
                    ("PAGES.PERFORMANCE.MY.COLUMNS.REVIEW_CYCLE", review.ReviewCycle),
                    ("PAGES.PERFORMANCE.MY.COLUMNS.SCORE", review.Score.ToString("0.0", CultureInfo.InvariantCulture)),
                    ("PAGES.PERFORMANCE.MY.COLUMNS.MANAGER", review.ManagerName),
                    ("PAGES.PERFORMANCE.MY.COLUMNS.STATUS", review.Status)),
                cancellationToken: cancellationToken),
            "team" => BuildPageAsync(
                module,
                page,
                noteKey: null,
                pageNumber,
                pageSize,
                filters,
                query.Where(r => r.EmployeeId != DefaultPerformanceEmployeeId)
                     .OrderByDescending(r => r.ReviewCycle),
                new Expression<Func<PerformanceReview, string?>>[]
                {
                    r => r.ReviewCycle,
                    r => r.ManagerName,
                    r => r.Status,
                    r => r.Employee != null ? r.Employee.FullName : null
                },
                q => q,
                review => CreateRow(
                    ("PAGES.PERFORMANCE.TEAM.COLUMNS.EMPLOYEE", review.Employee?.FullName ?? "Unknown"),
                    ("PAGES.PERFORMANCE.TEAM.COLUMNS.REVIEW_CYCLE", review.ReviewCycle),
                    ("PAGES.PERFORMANCE.TEAM.COLUMNS.SCORE", review.Score > 0 ? review.Score.ToString("0.0", CultureInfo.InvariantCulture) : "Awaiting"),
                    ("PAGES.PERFORMANCE.TEAM.COLUMNS.STATUS", review.Status)),
                cancellationToken: cancellationToken),
            "create" => Task.FromResult<PageDataDto?>(CreateNoteOnlyPage(module, page, pageNumber, pageSize, "PAGES.PERFORMANCE.CREATE.TODO")),
            _ => Task.FromResult<PageDataDto?>(null)
        };
    }

    private Task<PageDataDto?> GetTrainingPageAsync(
        string module,
        string page,
        string normalizedPage,
        int pageNumber,
        int pageSize,
        IReadOnlyDictionary<string, string> filters,
        CancellationToken cancellationToken)
    {
        return normalizedPage switch
        {
            "calendar" => BuildPageAsync(
                module,
                page,
                noteKey: null,
                pageNumber,
                pageSize,
                filters,
                _context.TrainingSessions.AsNoTracking(),
                new Expression<Func<TrainingSession, string?>>[]
                {
                    s => s.Title,
                    s => s.Trainer,
                    s => s.Status
                },
                q => q.OrderBy(s => s.SessionDate),
                session => CreateRow(
                    ("PAGES.TRAINING.CALENDAR.COLUMNS.SESSION", session.Title),
                    ("PAGES.TRAINING.CALENDAR.COLUMNS.DATE", FormatDate(session.SessionDate)),
                    ("PAGES.TRAINING.CALENDAR.COLUMNS.TRAINER", session.Trainer),
                    ("PAGES.TRAINING.CALENDAR.COLUMNS.STATUS", session.Status)),
                cancellationToken: cancellationToken),
            "progress" => BuildPageAsync(
                module,
                page,
                noteKey: null,
                pageNumber,
                pageSize,
                filters,
                _context.TrainingProgress
                    .AsNoTracking()
                    .Where(p => p.EmployeeId == DefaultTrainingEmployeeId),
                new Expression<Func<TrainingProgressRecord, string?>>[]
                {
                    p => p.ProgramName,
                    p => p.Status
                },
                q => q.OrderByDescending(p => p.StartDate),
                progress => CreateRow(
                    ("PAGES.TRAINING.PROGRESS.COLUMNS.PROGRAM", progress.ProgramName),
                    ("PAGES.TRAINING.PROGRESS.COLUMNS.START_DATE", FormatDate(progress.StartDate)),
                    ("PAGES.TRAINING.PROGRESS.COLUMNS.END_DATE", progress.EndDate.HasValue ? FormatDate(progress.EndDate.Value) : "-"),
                    ("PAGES.TRAINING.PROGRESS.COLUMNS.STATUS", progress.Status)),
                cancellationToken: cancellationToken),
            "requests" => BuildPageAsync(
                module,
                page,
                noteKey: null,
                pageNumber,
                pageSize,
                filters,
                _context.TrainingRequests.AsNoTracking(),
                new Expression<Func<TrainingRequest, string?>>[]
                {
                    r => r.RequestedBy,
                    r => r.ProgramName,
                    r => r.Status
                },
                q => q.OrderByDescending(r => r.SubmittedOn),
                request => CreateRow(
                    ("PAGES.TRAINING.REQUESTS.COLUMNS.REQUESTED_BY", request.RequestedBy),
                    ("PAGES.TRAINING.REQUESTS.COLUMNS.PROGRAM", request.ProgramName),
                    ("PAGES.TRAINING.REQUESTS.COLUMNS.SUBMITTED_ON", FormatDate(request.SubmittedOn)),
                    ("PAGES.TRAINING.REQUESTS.COLUMNS.STATUS", request.Status)),
                cancellationToken: cancellationToken),
            "create" => Task.FromResult<PageDataDto?>(CreateNoteOnlyPage(module, page, pageNumber, pageSize, "PAGES.TRAINING.CREATE.TODO")),
            _ => Task.FromResult<PageDataDto?>(null)
        };
    }

    private Task<PageDataDto?> GetEngagementPageAsync(
        string module,
        string page,
        string normalizedPage,
        int pageNumber,
        int pageSize,
        IReadOnlyDictionary<string, string> filters,
        CancellationToken cancellationToken)
    {
        return normalizedPage switch
        {
            "surveys" => BuildPageAsync(
                module,
                page,
                noteKey: null,
                pageNumber,
                pageSize,
                filters,
                _context.EngagementSurveys.AsNoTracking(),
                new Expression<Func<EngagementSurvey, string?>>[]
                {
                    s => s.Title,
                    s => s.Status
                },
                q => q.OrderByDescending(s => s.OpenDate),
                survey => CreateRow(
                    ("PAGES.ENGAGEMENT.SURVEYS.COLUMNS.TITLE", survey.Title),
                    ("PAGES.ENGAGEMENT.SURVEYS.COLUMNS.STATUS", survey.Status),
                    ("PAGES.ENGAGEMENT.SURVEYS.COLUMNS.OPEN_DATE", FormatDate(survey.OpenDate)),
                    ("PAGES.ENGAGEMENT.SURVEYS.COLUMNS.CLOSE_DATE", FormatDate(survey.CloseDate))),
                cancellationToken: cancellationToken),
            "results" => BuildPageAsync(
                module,
                page,
                noteKey: null,
                pageNumber,
                pageSize,
                filters,
                _context.EngagementSurveyMetrics.AsNoTracking(),
                new Expression<Func<EngagementSurveyMetric, string?>>[]
                {
                    m => m.MetricName,
                    m => m.Score,
                    m => m.Trend
                },
                q => q.OrderBy(m => m.MetricName),
                metric => CreateRow(
                    ("PAGES.ENGAGEMENT.RESULTS.COLUMNS.METRIC", metric.MetricName),
                    ("PAGES.ENGAGEMENT.RESULTS.COLUMNS.SCORE", metric.Score),
                    ("PAGES.ENGAGEMENT.RESULTS.COLUMNS.TREND", metric.Trend)),
                cancellationToken: cancellationToken),
            "create" => Task.FromResult<PageDataDto?>(CreateNoteOnlyPage(module, page, pageNumber, pageSize, "PAGES.ENGAGEMENT.CREATE.TODO")),
            _ => Task.FromResult<PageDataDto?>(null)
        };
    }

    private Task<PageDataDto?> GetReportsPageAsync(
        string module,
        string page,
        string normalizedPage,
        int pageNumber,
        int pageSize,
        IReadOnlyDictionary<string, string> filters,
        CancellationToken cancellationToken)
    {
        return normalizedPage switch
        {
            "employee" => BuildPageAsync(
                module,
                page,
                noteKey: null,
                pageNumber,
                pageSize,
                filters,
                _context.ReportEmployees.AsNoTracking(),
                new Expression<Func<ReportEmployeeRecord, string?>>[]
                {
                    r => r.EmployeeId,
                    r => r.Name,
                    r => r.Department,
                    r => r.Status
                },
                q => q.OrderBy(r => r.EmployeeId),
                record => CreateRow(
                    ("PAGES.REPORTS.EMPLOYEE.COLUMNS.EMPLOYEE_ID", record.EmployeeId),
                    ("PAGES.REPORTS.EMPLOYEE.COLUMNS.NAME", record.Name),
                    ("PAGES.REPORTS.EMPLOYEE.COLUMNS.DEPARTMENT", record.Department),
                    ("PAGES.REPORTS.EMPLOYEE.COLUMNS.STATUS", record.Status)),
                cancellationToken: cancellationToken),
            "leave" => BuildPageAsync(
                module,
                page,
                noteKey: null,
                pageNumber,
                pageSize,
                filters,
                _context.ReportLeaves.AsNoTracking(),
                new Expression<Func<ReportLeaveRecord, string?>>[]
                {
                    r => r.Employee,
                    r => r.LeaveType,
                    r => r.Status
                },
                q => q.OrderBy(r => r.Employee),
                record => CreateRow(
                    ("PAGES.REPORTS.LEAVE.COLUMNS.EMPLOYEE", record.Employee),
                    ("PAGES.REPORTS.LEAVE.COLUMNS.LEAVE_TYPE", record.LeaveType),
                    ("PAGES.REPORTS.LEAVE.COLUMNS.DAYS_USED", record.DaysUsed.ToString(CultureInfo.InvariantCulture)),
                    ("PAGES.REPORTS.LEAVE.COLUMNS.STATUS", record.Status)),
                cancellationToken: cancellationToken),
            "payroll" => BuildPageAsync(
                module,
                page,
                noteKey: null,
                pageNumber,
                pageSize,
                filters,
                _context.ReportPayroll.AsNoTracking(),
                new Expression<Func<ReportPayrollRecord, string?>>[]
                {
                    r => r.PayGroup,
                    r => r.Status
                },
                q => q.OrderBy(r => r.PayGroup),
                record => CreateRow(
                    ("PAGES.REPORTS.PAYROLL.COLUMNS.PAY_GROUP", record.PayGroup),
                    ("PAGES.REPORTS.PAYROLL.COLUMNS.GROSS_PAY", FormatCurrency(record.GrossPay)),
                    ("PAGES.REPORTS.PAYROLL.COLUMNS.NET_PAY", FormatCurrency(record.NetPay)),
                    ("PAGES.REPORTS.PAYROLL.COLUMNS.STATUS", record.Status)),
                cancellationToken: cancellationToken),
            "performance" => BuildPageAsync(
                module,
                page,
                noteKey: null,
                pageNumber,
                pageSize,
                filters,
                _context.ReportPerformance.AsNoTracking(),
                new Expression<Func<ReportPerformanceRecord, string?>>[]
                {
                    r => r.Department,
                    r => r.Status
                },
                q => q.OrderBy(r => r.Department),
                record => CreateRow(
                    ("PAGES.REPORTS.PERFORMANCE.COLUMNS.DEPARTMENT", record.Department),
                    ("PAGES.REPORTS.PERFORMANCE.COLUMNS.AVERAGE_SCORE", record.AverageScore.ToString("0.0", CultureInfo.InvariantCulture)),
                    ("PAGES.REPORTS.PERFORMANCE.COLUMNS.TREND", record.Trend),
                    ("PAGES.REPORTS.PERFORMANCE.COLUMNS.STATUS", record.Status)),
                cancellationToken: cancellationToken),
            "exports" => Task.FromResult<PageDataDto?>(CreateNoteOnlyPage(module, page, pageNumber, pageSize, "PAGES.REPORTS.EXPORT.TODO")),
            _ => Task.FromResult<PageDataDto?>(null)
        };
    }

    private Task<PageDataDto?> GetUsersPageAsync(
        string module,
        string page,
        string normalizedPage,
        int pageNumber,
        int pageSize,
        IReadOnlyDictionary<string, string> filters,
        CancellationToken cancellationToken)
    {
        return normalizedPage switch
        {
            "list" => BuildPageAsync(
                module,
                page,
                noteKey: null,
                pageNumber,
                pageSize,
                filters,
                _context.UserAccounts.AsNoTracking(),
                new Expression<Func<UserAccount, string?>>[]
                {
                    u => u.Name,
                    u => u.Email,
                    u => u.Role,
                    u => u.Status
                },
                q => q.OrderBy(u => u.Name),
                user => CreateRow(
                    ("PAGES.USERS.LIST.COLUMNS.NAME", user.Name),
                    ("PAGES.USERS.LIST.COLUMNS.EMAIL", user.Email),
                    ("PAGES.USERS.LIST.COLUMNS.ROLE", user.Role),
                    ("PAGES.USERS.LIST.COLUMNS.STATUS", user.Status)),
                cancellationToken: cancellationToken),
            "roles" => BuildPageAsync(
                module,
                page,
                noteKey: null,
                pageNumber,
                pageSize,
                filters,
                _context.UserRoles.AsNoTracking(),
                new Expression<Func<UserRoleSummary, string?>>[]
                {
                    r => r.Role,
                    r => r.Description
                },
                q => q.OrderBy(r => r.Role),
                role => CreateRow(
                    ("PAGES.USERS.ROLES.COLUMNS.ROLE", role.Role),
                    ("PAGES.USERS.ROLES.COLUMNS.DESCRIPTION", role.Description),
                    ("PAGES.USERS.ROLES.COLUMNS.ASSIGNED_USERS", role.AssignedUsers.ToString(CultureInfo.InvariantCulture))),
                cancellationToken: cancellationToken),
            "create" => Task.FromResult<PageDataDto?>(CreateNoteOnlyPage(module, page, pageNumber, pageSize, "PAGES.USERS.CREATE.TODO")),
            _ => Task.FromResult<PageDataDto?>(null)
        };
    }

    private PageDataDto? GetSettingsPage(
        string module,
        string page,
        string normalizedPage,
        int pageNumber,
        int pageSize)
    {
        return normalizedPage switch
        {
            "profile" => CreateNoteOnlyPage(module, page, pageNumber, pageSize, "PAGES.SETTINGS.PROFILE.TODO"),
            "notifications" => CreateNoteOnlyPage(module, page, pageNumber, pageSize, "PAGES.SETTINGS.NOTIFICATIONS.TODO"),
            "system" => CreateStaticPage(
                module,
                page,
                pageNumber,
                pageSize,
                "PAGES.SETTINGS.SYSTEM.NOTE",
                new[]
                {
                    CreateRow(
                        ("PAGES.SETTINGS.SYSTEM.COLUMNS.CONFIGURATION", "Primary timezone"),
                        ("PAGES.SETTINGS.SYSTEM.COLUMNS.VALUE", "(UTC+07:00) Bangkok"),
                        ("PAGES.SETTINGS.SYSTEM.COLUMNS.OWNER", "IT Platform"),
                        ("PAGES.SETTINGS.SYSTEM.COLUMNS.UPDATED", "2025-02-15")),
                    CreateRow(
                        ("PAGES.SETTINGS.SYSTEM.COLUMNS.CONFIGURATION", "Workweek template"),
                        ("PAGES.SETTINGS.SYSTEM.COLUMNS.VALUE", "Mon-Fri, 09:00-18:00"),
                        ("PAGES.SETTINGS.SYSTEM.COLUMNS.OWNER", "People Operations"),
                        ("PAGES.SETTINGS.SYSTEM.COLUMNS.UPDATED", "2025-01-08")),
                    CreateRow(
                        ("PAGES.SETTINGS.SYSTEM.COLUMNS.CONFIGURATION", "Public holiday set"),
                        ("PAGES.SETTINGS.SYSTEM.COLUMNS.VALUE", "Thailand 2025"),
                        ("PAGES.SETTINGS.SYSTEM.COLUMNS.OWNER", "People Operations"),
                        ("PAGES.SETTINGS.SYSTEM.COLUMNS.UPDATED", "2025-02-01")),
                    CreateRow(
                        ("PAGES.SETTINGS.SYSTEM.COLUMNS.CONFIGURATION", "Data residency"),
                        ("PAGES.SETTINGS.SYSTEM.COLUMNS.VALUE", "ap-southeast-1"),
                        ("PAGES.SETTINGS.SYSTEM.COLUMNS.OWNER", "Security Office"),
                        ("PAGES.SETTINGS.SYSTEM.COLUMNS.UPDATED", "2024-12-12"))
                }),
            "security" => CreateStaticPage(
                module,
                page,
                pageNumber,
                pageSize,
                "PAGES.SETTINGS.SECURITY.NOTE",
                new[]
                {
                    CreateRow(
                        ("PAGES.SETTINGS.SECURITY.COLUMNS.CONTROL", "Multi-factor authentication"),
                        ("PAGES.SETTINGS.SECURITY.COLUMNS.STATUS", "Enforced"),
                        ("PAGES.SETTINGS.SECURITY.COLUMNS.LAST_REVIEW", "2025-02-28"),
                        ("PAGES.SETTINGS.SECURITY.COLUMNS.OWNER", "Security Office")),
                    CreateRow(
                        ("PAGES.SETTINGS.SECURITY.COLUMNS.CONTROL", "Password policy"),
                        ("PAGES.SETTINGS.SECURITY.COLUMNS.STATUS", "12 chars / rotation 90 days"),
                        ("PAGES.SETTINGS.SECURITY.COLUMNS.LAST_REVIEW", "2025-01-15"),
                        ("PAGES.SETTINGS.SECURITY.COLUMNS.OWNER", "Security Office")),
                    CreateRow(
                        ("PAGES.SETTINGS.SECURITY.COLUMNS.CONTROL", "Privileged access review"),
                        ("PAGES.SETTINGS.SECURITY.COLUMNS.STATUS", "In progress"),
                        ("PAGES.SETTINGS.SECURITY.COLUMNS.LAST_REVIEW", "2025-03-05"),
                        ("PAGES.SETTINGS.SECURITY.COLUMNS.OWNER", "Internal Audit")),
                    CreateRow(
                        ("PAGES.SETTINGS.SECURITY.COLUMNS.CONTROL", "Data loss prevention"),
                        ("PAGES.SETTINGS.SECURITY.COLUMNS.STATUS", "Alerting"),
                        ("PAGES.SETTINGS.SECURITY.COLUMNS.LAST_REVIEW", "2025-02-10"),
                        ("PAGES.SETTINGS.SECURITY.COLUMNS.OWNER", "Security Office"))
                }),
            _ => null
        };
    }

    private async Task<PageDataDto?> BuildPageAsync<T>(
        string module,
        string page,
        string? noteKey,
        int pageNumber,
        int pageSize,
        IReadOnlyDictionary<string, string> filters,
        IQueryable<T> query,
        Expression<Func<T, string?>>[] filterSelectors,
        Func<IQueryable<T>, IQueryable<T>> orderBy,
        Func<T, PageRowDto> rowFactory,
        Func<IQueryable<T>, IReadOnlyCollection<KeyValuePair<string, string>>, IQueryable<T>>? applyCustomFilters = null,
        CancellationToken cancellationToken = default)
    {
        var allFilters = filters.ToList();

        if (applyCustomFilters != null)
        {
            query = applyCustomFilters(query, allFilters);
        }

        var searchFilters = allFilters
            .Where(kvp => !ReservedQueryKeys.Contains(kvp.Key))
            .ToList();

        query = ApplyFilters(query, searchFilters, filterSelectors);
        query = orderBy(query);

        var totalCount = await query.CountAsync(cancellationToken);
        var items = await query
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync(cancellationToken);

        var rows = items
            .Select(rowFactory)
            .ToList();

        return new PageDataDto(
            module,
            page,
            pageNumber,
            pageSize,
            totalCount,
            rows,
            noteKey);
    }

    private static IQueryable<LeaveRequest> ApplyLeaveRequestFilters(
        IQueryable<LeaveRequest> query,
        IReadOnlyCollection<KeyValuePair<string, string>> filters)
    {
        var startDate = TryGetDateFilter(filters, "startDate");
        if (startDate.HasValue)
        {
            query = query.Where(l => l.StartDate.Date >= startDate.Value);
        }

        var endDate = TryGetDateFilter(filters, "endDate");
        if (endDate.HasValue)
        {
            query = query.Where(l => l.EndDate.Date <= endDate.Value);
        }

        return query;
    }

    private static DateTime? TryGetDateFilter(
        IReadOnlyCollection<KeyValuePair<string, string>> filters,
        string key)
    {
        var match = filters.FirstOrDefault(pair =>
            pair.Key.Equals(key, StringComparison.OrdinalIgnoreCase));

        if (string.IsNullOrWhiteSpace(match.Value))
        {
            return null;
        }

        if (DateTime.TryParseExact(
                match.Value,
                "yyyy-MM-dd",
                CultureInfo.InvariantCulture,
                DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal,
                out var parsedExact))
        {
            return parsedExact.Date;
        }

        if (DateTime.TryParse(
                match.Value,
                CultureInfo.InvariantCulture,
                DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal,
                out var parsed))
        {
            return parsed.Date;
        }

        return null;
    }

    private static IQueryable<T> ApplyFilters<T>(
        IQueryable<T> query,
        IReadOnlyCollection<KeyValuePair<string, string>> filters,
        params Expression<Func<T, string?>>[] selectors)
    {
        if (filters.Count == 0 || selectors.Length == 0)
        {
            return query;
        }

        foreach (var (key, value) in filters)
        {
            if (string.IsNullOrWhiteSpace(key) || string.IsNullOrWhiteSpace(value))
            {
                continue;
            }

            var tokens = ExpandFilterTokens(value.Trim());
            if (tokens.Count == 0)
            {
                continue;
            }

            var parameter = Expression.Parameter(typeof(T), "entity");
            Expression? filterExpression = null;

            foreach (var token in tokens)
            {
                var patternConstant = Expression.Constant($"%{token}%", typeof(string));
                Expression? tokenExpression = null;

                foreach (var selector in selectors)
                {
                    var visitor = new ParameterReplaceVisitor(selector.Parameters[0], parameter);
                    var body = visitor.Visit(selector.Body)!;
                    if (body.Type != typeof(string))
                    {
                        body = Expression.Convert(body, typeof(string));
                    }

                    var likeCall = Expression.Call(
                        typeof(NpgsqlDbFunctionsExtensions),
                        nameof(NpgsqlDbFunctionsExtensions.ILike),
                        Type.EmptyTypes,
                        Expression.Property(null, typeof(EF), nameof(EF.Functions)),
                        body,
                        patternConstant);

                    tokenExpression = tokenExpression == null
                        ? likeCall
                        : Expression.OrElse(tokenExpression, likeCall);
                }

                if (tokenExpression != null)
                {
                    filterExpression = filterExpression == null
                        ? tokenExpression
                        : Expression.OrElse(filterExpression, tokenExpression);
                }
            }

            if (filterExpression == null)
            {
                continue;
            }

            var lambda = Expression.Lambda<Func<T, bool>>(filterExpression, parameter);
            query = query.Where(lambda);
        }

        return query;
    }

    private static IReadOnlyCollection<string> ExpandFilterTokens(string value)
    {
        if (FilterSynonyms.TryGetValue(value, out var synonyms))
        {
            return synonyms.Length == 0
                ? Array.Empty<string>()
                : synonyms.Concat(new[] { value }).ToArray();
        }

        return new[] { value };
    }

    private static PageDataDto CreateNoteOnlyPage(
        string module,
        string page,
        int pageNumber,
        int pageSize,
        string noteKey)
        => new(
            module,
            page,
            pageNumber,
            pageSize,
            0,
            Array.Empty<PageRowDto>(),
            noteKey);

    private static PageDataDto CreateStaticPage(
        string module,
        string page,
        int pageNumber,
        int pageSize,
        string? noteKey,
        IReadOnlyList<PageRowDto> rows)
    {
        var total = rows.Count;
        var skip = Math.Max(pageNumber - 1, 0) * pageSize;
        var items = rows.Skip(skip).Take(pageSize).ToArray();

        return new PageDataDto(
            module,
            page,
            pageNumber,
            pageSize,
            total,
            items,
            noteKey);
    }

    private static PageRowDto CreateRow(params (string Key, string Value)[] columns)
    {
        var dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        foreach (var (key, value) in columns)
        {
            dictionary[key] = value;
        }

        return new PageRowDto(dictionary);
    }

    private static string FormatDate(DateTime date)
        => date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

    private static string FormatCurrency(decimal amount)
        => amount.ToString("#,##0.##", CultureInfo.InvariantCulture);

    private static string ResolveLevelFromPosition(string position)
    {
        if (string.IsNullOrWhiteSpace(position))
        {
            return string.Empty;
        }

        if (position.Contains("Lead", StringComparison.OrdinalIgnoreCase))
        {
            return "Lead";
        }

        if (position.Contains("Manager", StringComparison.OrdinalIgnoreCase))
        {
            return "Manager";
        }

        if (position.Contains("Specialist", StringComparison.OrdinalIgnoreCase))
        {
            return "Specialist";
        }

        return "Senior";
    }

    private sealed class ParameterReplaceVisitor : ExpressionVisitor
    {
        private readonly ParameterExpression _source;
        private readonly ParameterExpression _target;

        public ParameterReplaceVisitor(ParameterExpression source, ParameterExpression target)
        {
            _source = source;
            _target = target;
        }

        protected override Expression VisitParameter(ParameterExpression node)
            => node == _source ? _target : base.VisitParameter(node);
    }
}
