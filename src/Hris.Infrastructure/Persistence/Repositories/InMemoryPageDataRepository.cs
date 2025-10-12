using System;
using System.Collections.Generic;
using System.Linq;
using Hris.Application.DTOs.PageData;
using Hris.Application.Interfaces.Repositories;

namespace Hris.Infrastructure.Persistence.Repositories;

public class InMemoryPageDataRepository : IPageDataRepository
{
    private record PageTemplate(string Module, string Page, string? NoteKey, List<PageRowDto> Rows);

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

    private readonly Dictionary<string, Dictionary<string, PageTemplate>> _store;

    public InMemoryPageDataRepository()
    {
        _store = BuildSeed();
    }

    public Task<PageDataDto?> GetPageAsync(
        string module,
        string page,
        int pageNumber,
        int pageSize,
        IReadOnlyDictionary<string, string> filters,
        CancellationToken cancellationToken = default)
    {
        if (!_store.TryGetValue(module, out var pages) || !pages.TryGetValue(page, out var template))
        {
            return Task.FromResult<PageDataDto?>(null);
        }

        pageNumber = Math.Max(1, pageNumber);
        pageSize = Math.Clamp(pageSize, 1, 200);

        IEnumerable<PageRowDto> query = template.Rows;

        if (filters.Count > 0)
        {
            foreach (var filter in filters)
            {
                if (string.IsNullOrWhiteSpace(filter.Value))
                {
                    continue;
                }

                var tokens = ExpandFilterTokens(filter.Value.Trim());
                if (tokens.Count == 0)
                {
                    continue;
                }

                query = query.Where(row =>
                    row.Columns.Values.Any(cell =>
                        tokens.Any(token =>
                            cell.Contains(token, StringComparison.OrdinalIgnoreCase))));
            }
        }

        var totalCount = query.Count();
        var pagedRows = query
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToList();

        var result = new PageDataDto(
            template.Module,
            template.Page,
            pageNumber,
            pageSize,
            totalCount,
            pagedRows,
            template.NoteKey);

        return Task.FromResult<PageDataDto?>(result);
    }

    private static IReadOnlyCollection<string> ExpandFilterTokens(string value)
    {
        if (FilterSynonyms.TryGetValue(value, out var synonyms))
        {
            if (synonyms.Length == 0)
            {
                return Array.Empty<string>();
            }

            return synonyms.Concat(new[] { value }).ToArray();
        }

        return new[] { value };
    }

    private static Dictionary<string, Dictionary<string, PageTemplate>> BuildSeed()
    {
        return new Dictionary<string, Dictionary<string, PageTemplate>>(StringComparer.OrdinalIgnoreCase)
        {
            ["dashboard"] = new(StringComparer.OrdinalIgnoreCase)
            {
                ["overview"] = Template("dashboard", "overview", "PAGES.DASHBOARD.TODO")
            },
            ["organization"] = new(StringComparer.OrdinalIgnoreCase)
            {
                ["structure"] = Template(
                    "organization",
                    "structure",
                    "PAGES.ORGANIZATION.STRUCTURE.NOTE",
                    Row(
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.DEPARTMENT", "People Operations"),
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.LEAD", "Chanon Phumiphak"),
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.HEADCOUNT", "8"),
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.OPEN_ROLES", "1"),
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.FOCUS", "HR strategy, talent development")),
                    Row(
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.DEPARTMENT", "Technology"),
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.LEAD", "Anuwat Khem"),
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.HEADCOUNT", "14"),
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.OPEN_ROLES", "3"),
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.FOCUS", "Product delivery, platform reliability")),
                    Row(
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.DEPARTMENT", "Finance"),
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.LEAD", "Benjamas Sriwilai"),
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.HEADCOUNT", "6"),
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.OPEN_ROLES", "1"),
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.FOCUS", "Payroll, budgeting, treasury")),
                    Row(
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.DEPARTMENT", "Marketing"),
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.LEAD", "Oranicha Mek"),
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.HEADCOUNT", "6"),
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.OPEN_ROLES", "1"),
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.FOCUS", "Demand generation, brand growth")),
                    Row(
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.DEPARTMENT", "Customer Success"),
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.LEAD", "Jirawat Kan"),
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.HEADCOUNT", "5"),
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.OPEN_ROLES", "0"),
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.FOCUS", "Onboarding, renewals, support excellence")),
                    Row(
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.DEPARTMENT", "Operations"),
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.LEAD", "Amara Jittrakorn"),
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.HEADCOUNT", "5"),
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.OPEN_ROLES", "1"),
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.FOCUS", "Facilities, procurement, logistics")),
                    Row(
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.DEPARTMENT", "Sales"),
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.LEAD", "Pimchanok Rukdee"),
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.HEADCOUNT", "3"),
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.OPEN_ROLES", "1"),
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.FOCUS", "Enterprise acquisition, account growth")),
                    Row(
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.DEPARTMENT", "Data & Analytics"),
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.LEAD", "Piyada Sornchai"),
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.HEADCOUNT", "3"),
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.OPEN_ROLES", "1"),
                        ("PAGES.ORGANIZATION.STRUCTURE.COLUMNS.FOCUS", "Insights, dashboards, data governance"))),
                ["workforce-plan"] = Template(
                    "organization",
                    "workforce-plan",
                    "PAGES.ORGANIZATION.WORKFORCE_PLAN.NOTE",
                    Row(
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.DEPARTMENT", "People Operations"),
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.CURRENT_HEADCOUNT", "8"),
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.APPROVED_Q3", "9"),
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.ATTRITION_RISK", "Low"),
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.NEXT_HIRE", "HR Business Partner")),
                    Row(
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.DEPARTMENT", "Technology"),
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.CURRENT_HEADCOUNT", "14"),
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.APPROVED_Q3", "16"),
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.ATTRITION_RISK", "Medium"),
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.NEXT_HIRE", "Senior Backend Engineer")),
                    Row(
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.DEPARTMENT", "Finance"),
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.CURRENT_HEADCOUNT", "6"),
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.APPROVED_Q3", "6"),
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.ATTRITION_RISK", "Low"),
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.NEXT_HIRE", "Revenue Assurance Analyst")),
                    Row(
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.DEPARTMENT", "Marketing"),
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.CURRENT_HEADCOUNT", "6"),
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.APPROVED_Q3", "7"),
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.ATTRITION_RISK", "Medium"),
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.NEXT_HIRE", "Lifecycle Marketer")),
                    Row(
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.DEPARTMENT", "Customer Success"),
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.CURRENT_HEADCOUNT", "5"),
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.APPROVED_Q3", "5"),
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.ATTRITION_RISK", "Low"),
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.NEXT_HIRE", "Technical Account Manager")),
                    Row(
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.DEPARTMENT", "Operations"),
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.CURRENT_HEADCOUNT", "5"),
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.APPROVED_Q3", "6"),
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.ATTRITION_RISK", "Medium"),
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.NEXT_HIRE", "Facilities Supervisor")),
                    Row(
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.DEPARTMENT", "Sales"),
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.CURRENT_HEADCOUNT", "3"),
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.APPROVED_Q3", "4"),
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.ATTRITION_RISK", "High"),
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.NEXT_HIRE", "Enterprise Account Executive")),
                    Row(
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.DEPARTMENT", "Data & Analytics"),
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.CURRENT_HEADCOUNT", "3"),
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.APPROVED_Q3", "4"),
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.ATTRITION_RISK", "Medium"),
                        ("PAGES.ORGANIZATION.WORKFORCE_PLAN.COLUMNS.NEXT_HIRE", "Analytics Engineer")))
            },
            ["employee-records"] = new(StringComparer.OrdinalIgnoreCase)
            {
                ["all"] = Template(
                    "employee-records",
                    "all",
                    null,
                    Row(
                        ("PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.EMPLOYEE_ID", "HR-0001"),
                        ("PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.NAME", "Chanon Phumiphak"),
                        ("PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.POSITION", "HR Business Partner"),
                        ("PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.DEPARTMENT", "People Operations"),
                        ("PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.STATUS", "Active")),
                    Row(
                        ("PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.EMPLOYEE_ID", "HR-0002"),
                        ("PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.NAME", "Supaporn Teerapat"),
                        ("PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.POSITION", "Compensation Lead"),
                        ("PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.DEPARTMENT", "People Operations"),
                        ("PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.STATUS", "Active")),
                    Row(
                        ("PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.EMPLOYEE_ID", "IT-0003"),
                        ("PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.NAME", "Thanawat Dee"),
                        ("PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.POSITION", "Senior Backend Engineer"),
                        ("PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.DEPARTMENT", "Technology"),
                        ("PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.STATUS", "Active")),
                    Row(
                        ("PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.EMPLOYEE_ID", "FN-0001"),
                        ("PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.NAME", "Nattawat Charoen"),
                        ("PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.POSITION", "Payroll Specialist"),
                        ("PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.DEPARTMENT", "Finance"),
                        ("PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.STATUS", "On Leave")),
                    Row(
                        ("PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.EMPLOYEE_ID", "MK-0001"),
                        ("PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.NAME", "Oranicha Mek"),
                        ("PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.POSITION", "Marketing Lead"),
                        ("PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.DEPARTMENT", "Marketing"),
                        ("PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.STATUS", "Active")),
                    Row(
                        ("PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.EMPLOYEE_ID", "CS-0001"),
                        ("PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.NAME", "Jirawat Kan"),
                        ("PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.POSITION", "Customer Success Lead"),
                        ("PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.DEPARTMENT", "Customer Success"),
                        ("PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.STATUS", "Active"))),
                ["profile"] = Template("employee-records", "profile", "PAGES.EMPLOYEE_RECORDS.PROFILE.TODO"),
                ["search"] = Template(
                    "employee-records",
                    "search",
                    "PAGES.EMPLOYEE_RECORDS.SEARCH.TODO",
                    Row(
                        ("PAGES.EMPLOYEE_RECORDS.SEARCH.COLUMNS.EMPLOYEE_ID", "MK-0004"),
                        ("PAGES.EMPLOYEE_RECORDS.SEARCH.COLUMNS.NAME", "Suwit Phasuk"),
                        ("PAGES.EMPLOYEE_RECORDS.SEARCH.COLUMNS.DEPARTMENT", "Marketing"),
                        ("PAGES.EMPLOYEE_RECORDS.SEARCH.COLUMNS.LEVEL", "Senior")),
                    Row(
                        ("PAGES.EMPLOYEE_RECORDS.SEARCH.COLUMNS.EMPLOYEE_ID", "CS-0002"),
                        ("PAGES.EMPLOYEE_RECORDS.SEARCH.COLUMNS.NAME", "Supawadee Ornnapa"),
                        ("PAGES.EMPLOYEE_RECORDS.SEARCH.COLUMNS.DEPARTMENT", "Customer Success"),
                        ("PAGES.EMPLOYEE_RECORDS.SEARCH.COLUMNS.LEVEL", "Lead")))
            },
            ["leave-management"] = new(StringComparer.OrdinalIgnoreCase)
            {
                ["my"] = Template(
                    "leave-management",
                    "my",
                    null,
                    Row(
                        ("PAGES.LEAVE.MY.COLUMNS.REFERENCE", "LV-2025-0001"),
                        ("PAGES.LEAVE.MY.COLUMNS.TYPE", "Annual Leave"),
                        ("PAGES.LEAVE.MY.COLUMNS.START", "2025-02-21"),
                        ("PAGES.LEAVE.MY.COLUMNS.END", "2025-02-24"),
                        ("PAGES.LEAVE.MY.COLUMNS.STATUS", "Approved")),
                    Row(
                        ("PAGES.LEAVE.MY.COLUMNS.REFERENCE", "LV-2025-0004"),
                        ("PAGES.LEAVE.MY.COLUMNS.TYPE", "Sick Leave"),
                        ("PAGES.LEAVE.MY.COLUMNS.START", "2025-03-03"),
                        ("PAGES.LEAVE.MY.COLUMNS.END", "2025-03-05"),
                        ("PAGES.LEAVE.MY.COLUMNS.STATUS", "Pending")),
                    Row(
                        ("PAGES.LEAVE.MY.COLUMNS.REFERENCE", "LV-2025-0010"),
                        ("PAGES.LEAVE.MY.COLUMNS.TYPE", "Work From Home"),
                        ("PAGES.LEAVE.MY.COLUMNS.START", "2025-03-12"),
                        ("PAGES.LEAVE.MY.COLUMNS.END", "2025-03-12"),
                        ("PAGES.LEAVE.MY.COLUMNS.STATUS", "Approved"))),
                ["create"] = Template("leave-management", "create", "PAGES.LEAVE.CREATE.TODO"),
                ["team"] = Template(
                    "leave-management",
                    "team",
                    null,
                    Row(
                        ("PAGES.LEAVE.TEAM.COLUMNS.EMPLOYEE", "Warit Somchai"),
                        ("PAGES.LEAVE.TEAM.COLUMNS.TYPE", "Work From Home"),
                        ("PAGES.LEAVE.TEAM.COLUMNS.PERIOD", "2025-03-10 to 2025-03-11"),
                        ("PAGES.LEAVE.TEAM.COLUMNS.STATUS", "Pending"),
                        ("PAGES.LEAVE.TEAM.COLUMNS.REQUESTED_ON", "2025-02-28")),
                    Row(
                        ("PAGES.LEAVE.TEAM.COLUMNS.EMPLOYEE", "Patchara T."),
                        ("PAGES.LEAVE.TEAM.COLUMNS.TYPE", "Annual Leave"),
                        ("PAGES.LEAVE.TEAM.COLUMNS.PERIOD", "2025-03-18 to 2025-03-22"),
                        ("PAGES.LEAVE.TEAM.COLUMNS.STATUS", "Pending"),
                        ("PAGES.LEAVE.TEAM.COLUMNS.REQUESTED_ON", "2025-03-01"))),
                ["history"] = Template(
                    "leave-management",
                    "history",
                    null,
                    Row(
                        ("PAGES.LEAVE.HISTORY.COLUMNS.REFERENCE", "LV-2024-0145"),
                        ("PAGES.LEAVE.HISTORY.COLUMNS.TYPE", "Annual Leave"),
                        ("PAGES.LEAVE.HISTORY.COLUMNS.PERIOD", "2024-12-20 to 2024-12-24"),
                        ("PAGES.LEAVE.HISTORY.COLUMNS.DAY_USED", "5"),
                        ("PAGES.LEAVE.HISTORY.COLUMNS.STATUS", "Approved")),
                    Row(
                        ("PAGES.LEAVE.HISTORY.COLUMNS.REFERENCE", "LV-2024-0162"),
                        ("PAGES.LEAVE.HISTORY.COLUMNS.TYPE", "Sick Leave"),
                        ("PAGES.LEAVE.HISTORY.COLUMNS.PERIOD", "2024-11-02 to 2024-11-03"),
                        ("PAGES.LEAVE.HISTORY.COLUMNS.DAY_USED", "2"),
                        ("PAGES.LEAVE.HISTORY.COLUMNS.STATUS", "Approved")))
            },
            ["payroll"] = new(StringComparer.OrdinalIgnoreCase)
            {
                ["my"] = Template(
                    "payroll",
                    "my",
                    null,
                    Row(
                        ("PAGES.PAYROLL.MY.COLUMNS.COMPONENT", "Base Salary"),
                        ("PAGES.PAYROLL.MY.COLUMNS.AMOUNT", "65,000"),
                        ("PAGES.PAYROLL.MY.COLUMNS.NOTES", "March 2025")),
                    Row(
                        ("PAGES.PAYROLL.MY.COLUMNS.COMPONENT", "Bonus"),
                        ("PAGES.PAYROLL.MY.COLUMNS.AMOUNT", "10,000"),
                        ("PAGES.PAYROLL.MY.COLUMNS.NOTES", "Performance FY24")),
                    Row(
                        ("PAGES.PAYROLL.MY.COLUMNS.COMPONENT", "Withholding Tax"),
                        ("PAGES.PAYROLL.MY.COLUMNS.AMOUNT", "-5,600"),
                        ("PAGES.PAYROLL.MY.COLUMNS.NOTES", "WHT 5%"))),
                ["summary"] = Template(
                    "payroll",
                    "summary",
                    null,
                    Row(
                        ("PAGES.PAYROLL.SUMMARY.COLUMNS.DEPARTMENT", "Technology"),
                        ("PAGES.PAYROLL.SUMMARY.COLUMNS.TOTAL_EMPLOYEES", "42"),
                        ("PAGES.PAYROLL.SUMMARY.COLUMNS.GROSS_PAY", "2,560,000"),
                        ("PAGES.PAYROLL.SUMMARY.COLUMNS.NET_PAY", "2,180,000")),
                    Row(
                        ("PAGES.PAYROLL.SUMMARY.COLUMNS.DEPARTMENT", "Operations"),
                        ("PAGES.PAYROLL.SUMMARY.COLUMNS.TOTAL_EMPLOYEES", "18"),
                        ("PAGES.PAYROLL.SUMMARY.COLUMNS.GROSS_PAY", "820,000"),
                        ("PAGES.PAYROLL.SUMMARY.COLUMNS.NET_PAY", "705,000"))),
                ["generate"] = Template("payroll", "generate", "PAGES.PAYROLL.GENERATE.TODO")
            },
            ["performance"] = new(StringComparer.OrdinalIgnoreCase)
            {
                ["my"] = Template(
                    "performance",
                    "my",
                    null,
                    Row(
                        ("PAGES.PERFORMANCE.MY.COLUMNS.REVIEW_CYCLE", "Mid-Year 2024"),
                        ("PAGES.PERFORMANCE.MY.COLUMNS.SCORE", "4.3"),
                        ("PAGES.PERFORMANCE.MY.COLUMNS.MANAGER", "Karn Suphachai"),
                        ("PAGES.PERFORMANCE.MY.COLUMNS.STATUS", "Completed")),
                    Row(
                        ("PAGES.PERFORMANCE.MY.COLUMNS.REVIEW_CYCLE", "Year-End 2024"),
                        ("PAGES.PERFORMANCE.MY.COLUMNS.SCORE", "4.6"),
                        ("PAGES.PERFORMANCE.MY.COLUMNS.MANAGER", "Karn Suphachai"),
                        ("PAGES.PERFORMANCE.MY.COLUMNS.STATUS", "Completed"))),
                ["team"] = Template(
                    "performance",
                    "team",
                    null,
                    Row(
                        ("PAGES.PERFORMANCE.TEAM.COLUMNS.EMPLOYEE", "Sureeporn Wai"),
                        ("PAGES.PERFORMANCE.TEAM.COLUMNS.REVIEW_CYCLE", "Year-End 2024"),
                        ("PAGES.PERFORMANCE.TEAM.COLUMNS.SCORE", "Awaiting"),
                        ("PAGES.PERFORMANCE.TEAM.COLUMNS.STATUS", "Submitted")),
                    Row(
                        ("PAGES.PERFORMANCE.TEAM.COLUMNS.EMPLOYEE", "Pakorn Lek"),
                        ("PAGES.PERFORMANCE.TEAM.COLUMNS.REVIEW_CYCLE", "Year-End 2024"),
                        ("PAGES.PERFORMANCE.TEAM.COLUMNS.SCORE", "3.9"),
                        ("PAGES.PERFORMANCE.TEAM.COLUMNS.STATUS", "Pending Approval"))),
                ["create"] = Template("performance", "create", "PAGES.PERFORMANCE.CREATE.TODO")
            },
            ["training"] = new(StringComparer.OrdinalIgnoreCase)
            {
                ["calendar"] = Template(
                    "training",
                    "calendar",
                    null,
                    Row(
                        ("PAGES.TRAINING.CALENDAR.COLUMNS.SESSION", "Advanced Angular Workshop"),
                        ("PAGES.TRAINING.CALENDAR.COLUMNS.DATE", "2025-03-18"),
                        ("PAGES.TRAINING.CALENDAR.COLUMNS.TRAINER", "Anan Techakun"),
                        ("PAGES.TRAINING.CALENDAR.COLUMNS.STATUS", "Open")),
                    Row(
                        ("PAGES.TRAINING.CALENDAR.COLUMNS.SESSION", "Leadership for Managers"),
                        ("PAGES.TRAINING.CALENDAR.COLUMNS.DATE", "2025-04-02"),
                        ("PAGES.TRAINING.CALENDAR.COLUMNS.TRAINER", "Sasithorn P."),
                        ("PAGES.TRAINING.CALENDAR.COLUMNS.STATUS", "Waitlist"))),
                ["progress"] = Template(
                    "training",
                    "progress",
                    null,
                    Row(
                        ("PAGES.TRAINING.PROGRESS.COLUMNS.PROGRAM", "OKRs Mastery"),
                        ("PAGES.TRAINING.PROGRESS.COLUMNS.START_DATE", "2025-01-15"),
                        ("PAGES.TRAINING.PROGRESS.COLUMNS.END_DATE", "2025-03-15"),
                        ("PAGES.TRAINING.PROGRESS.COLUMNS.STATUS", "In Progress")),
                    Row(
                        ("PAGES.TRAINING.PROGRESS.COLUMNS.PROGRAM", "Cloud Fundamentals"),
                        ("PAGES.TRAINING.PROGRESS.COLUMNS.START_DATE", "2024-09-01"),
                        ("PAGES.TRAINING.PROGRESS.COLUMNS.END_DATE", "2024-10-15"),
                        ("PAGES.TRAINING.PROGRESS.COLUMNS.STATUS", "Completed"))),
                ["requests"] = Template(
                    "training",
                    "requests",
                    null,
                    Row(
                        ("PAGES.TRAINING.REQUESTS.COLUMNS.REQUESTED_BY", "Janya K."),
                        ("PAGES.TRAINING.REQUESTS.COLUMNS.PROGRAM", "Data Storytelling"),
                        ("PAGES.TRAINING.REQUESTS.COLUMNS.SUBMITTED_ON", "2025-02-20"),
                        ("PAGES.TRAINING.REQUESTS.COLUMNS.STATUS", "Pending")),
                    Row(
                        ("PAGES.TRAINING.REQUESTS.COLUMNS.REQUESTED_BY", "Pattama Mee"),
                        ("PAGES.TRAINING.REQUESTS.COLUMNS.PROGRAM", "Advanced Excel Automation"),
                        ("PAGES.TRAINING.REQUESTS.COLUMNS.SUBMITTED_ON", "2025-01-29"),
                        ("PAGES.TRAINING.REQUESTS.COLUMNS.STATUS", "Approved"))),
                ["create"] = Template("training", "create", "PAGES.TRAINING.CREATE.TODO")
            },
            ["engagement"] = new(StringComparer.OrdinalIgnoreCase)
            {
                ["surveys"] = Template(
                    "engagement",
                    "surveys",
                    null,
                    Row(
                        ("PAGES.ENGAGEMENT.SURVEYS.COLUMNS.TITLE", "2025 Q1 Engagement Pulse"),
                        ("PAGES.ENGAGEMENT.SURVEYS.COLUMNS.STATUS", "Open"),
                        ("PAGES.ENGAGEMENT.SURVEYS.COLUMNS.OPEN_DATE", "2025-03-01"),
                        ("PAGES.ENGAGEMENT.SURVEYS.COLUMNS.CLOSE_DATE", "2025-03-20")),
                    Row(
                        ("PAGES.ENGAGEMENT.SURVEYS.COLUMNS.TITLE", "Hybrid Work Feedback"),
                        ("PAGES.ENGAGEMENT.SURVEYS.COLUMNS.STATUS", "Scheduled"),
                        ("PAGES.ENGAGEMENT.SURVEYS.COLUMNS.OPEN_DATE", "2025-04-05"),
                        ("PAGES.ENGAGEMENT.SURVEYS.COLUMNS.CLOSE_DATE", "2025-04-25"))),
                ["results"] = Template(
                    "engagement",
                    "results",
                    null,
                    Row(
                        ("PAGES.ENGAGEMENT.RESULTS.COLUMNS.METRIC", "Participation"),
                        ("PAGES.ENGAGEMENT.RESULTS.COLUMNS.SCORE", "87%"),
                        ("PAGES.ENGAGEMENT.RESULTS.COLUMNS.TREND", "+5% QoQ")),
                    Row(
                        ("PAGES.ENGAGEMENT.RESULTS.COLUMNS.METRIC", "eNPS"),
                        ("PAGES.ENGAGEMENT.RESULTS.COLUMNS.SCORE", "42"),
                        ("PAGES.ENGAGEMENT.RESULTS.COLUMNS.TREND", "+3 pts"))),
                ["create"] = Template("engagement", "create", "PAGES.ENGAGEMENT.CREATE.TODO")
            },
            ["reports"] = new(StringComparer.OrdinalIgnoreCase)
            {
                ["employee"] = Template(
                    "reports",
                    "employee",
                    null,
                    Row(
                        ("PAGES.REPORTS.EMPLOYEE.COLUMNS.EMPLOYEE_ID", "HR-0001"),
                        ("PAGES.REPORTS.EMPLOYEE.COLUMNS.NAME", "Chanon Phumiphak"),
                        ("PAGES.REPORTS.EMPLOYEE.COLUMNS.DEPARTMENT", "People Operations"),
                        ("PAGES.REPORTS.EMPLOYEE.COLUMNS.STATUS", "Active")),
                    Row(
                        ("PAGES.REPORTS.EMPLOYEE.COLUMNS.EMPLOYEE_ID", "IT-0003"),
                        ("PAGES.REPORTS.EMPLOYEE.COLUMNS.NAME", "Thanawat Dee"),
                        ("PAGES.REPORTS.EMPLOYEE.COLUMNS.DEPARTMENT", "Technology"),
                        ("PAGES.REPORTS.EMPLOYEE.COLUMNS.STATUS", "Active")),
                    Row(
                        ("PAGES.REPORTS.EMPLOYEE.COLUMNS.EMPLOYEE_ID", "MK-0001"),
                        ("PAGES.REPORTS.EMPLOYEE.COLUMNS.NAME", "Oranicha Mek"),
                        ("PAGES.REPORTS.EMPLOYEE.COLUMNS.DEPARTMENT", "Marketing"),
                        ("PAGES.REPORTS.EMPLOYEE.COLUMNS.STATUS", "Active"))),
                ["leave"] = Template(
                    "reports",
                    "leave",
                    null,
                    Row(
                        ("PAGES.REPORTS.LEAVE.COLUMNS.EMPLOYEE", "Patchara T."),
                        ("PAGES.REPORTS.LEAVE.COLUMNS.TYPE", "Annual Leave"),
                        ("PAGES.REPORTS.LEAVE.COLUMNS.DAYS_USED", "12"),
                        ("PAGES.REPORTS.LEAVE.COLUMNS.STATUS", "Approved")),
                    Row(
                        ("PAGES.REPORTS.LEAVE.COLUMNS.EMPLOYEE", "Warit Somchai"),
                        ("PAGES.REPORTS.LEAVE.COLUMNS.TYPE", "Sick Leave"),
                        ("PAGES.REPORTS.LEAVE.COLUMNS.DAYS_USED", "5"),
                        ("PAGES.REPORTS.LEAVE.COLUMNS.STATUS", "Approved"))),
                ["payroll"] = Template(
                    "reports",
                    "payroll",
                    null,
                    Row(
                        ("PAGES.REPORTS.PAYROLL.COLUMNS.PAY_GROUP", "Monthly"),
                        ("PAGES.REPORTS.PAYROLL.COLUMNS.GROSS_PAY", "3,950,000"),
                        ("PAGES.REPORTS.PAYROLL.COLUMNS.NET_PAY", "3,210,000"),
                        ("PAGES.REPORTS.PAYROLL.COLUMNS.STATUS", "Completed")),
                    Row(
                        ("PAGES.REPORTS.PAYROLL.COLUMNS.PAY_GROUP", "Bi-weekly"),
                        ("PAGES.REPORTS.PAYROLL.COLUMNS.GROSS_PAY", "780,000"),
                        ("PAGES.REPORTS.PAYROLL.COLUMNS.NET_PAY", "655,000"),
                        ("PAGES.REPORTS.PAYROLL.COLUMNS.STATUS", "Completed"))),
                ["performance"] = Template(
                    "reports",
                    "performance",
                    null,
                    Row(
                        ("PAGES.REPORTS.PERFORMANCE.COLUMNS.DEPARTMENT", "Technology"),
                        ("PAGES.REPORTS.PERFORMANCE.COLUMNS.AVERAGE_SCORE", "4.3"),
                        ("PAGES.REPORTS.PERFORMANCE.COLUMNS.TREND", "+0.2"),
                        ("PAGES.REPORTS.PERFORMANCE.COLUMNS.STATUS", "Published")),
                    Row(
                        ("PAGES.REPORTS.PERFORMANCE.COLUMNS.DEPARTMENT", "Operations"),
                        ("PAGES.REPORTS.PERFORMANCE.COLUMNS.AVERAGE_SCORE", "4.0"),
                        ("PAGES.REPORTS.PERFORMANCE.COLUMNS.TREND", "+0.1"),
                        ("PAGES.REPORTS.PERFORMANCE.COLUMNS.STATUS", "Published"))),
                ["exports"] = Template("reports", "exports", "PAGES.REPORTS.EXPORT.TODO")
            },
            ["users"] = new(StringComparer.OrdinalIgnoreCase)
            {
                ["list"] = Template(
                    "users",
                    "list",
                    null,
                    Row(
                        ("PAGES.USERS.LIST.COLUMNS.NAME", "Alex Morgan"),
                        ("PAGES.USERS.LIST.COLUMNS.EMAIL", "alex.morgan@company.com"),
                        ("PAGES.USERS.LIST.COLUMNS.ROLE", "Administrator"),
                        ("PAGES.USERS.LIST.COLUMNS.STATUS", "Active")),
                    Row(
                        ("PAGES.USERS.LIST.COLUMNS.NAME", "Pakamon Dee"),
                        ("PAGES.USERS.LIST.COLUMNS.EMAIL", "pakamon.dee@company.com"),
                        ("PAGES.USERS.LIST.COLUMNS.ROLE", "Manager"),
                        ("PAGES.USERS.LIST.COLUMNS.STATUS", "Active")),
                    Row(
                        ("PAGES.USERS.LIST.COLUMNS.NAME", "Siwaporn Lek"),
                        ("PAGES.USERS.LIST.COLUMNS.EMAIL", "siwaporn.lek@company.com"),
                        ("PAGES.USERS.LIST.COLUMNS.ROLE", "Employee"),
                        ("PAGES.USERS.LIST.COLUMNS.STATUS", "Suspended"))),
                ["create"] = Template("users", "create", "PAGES.USERS.CREATE.TODO"),
                ["roles"] = Template(
                    "users",
                    "roles",
                    null,
                    Row(
                        ("PAGES.USERS.ROLES.COLUMNS.ROLE", "Administrator"),
                        ("PAGES.USERS.ROLES.COLUMNS.DESCRIPTION", "Full access to manage system settings"),
                        ("PAGES.USERS.ROLES.COLUMNS.ASSIGNED_USERS", "3")),
                    Row(
                        ("PAGES.USERS.ROLES.COLUMNS.ROLE", "Manager"),
                        ("PAGES.USERS.ROLES.COLUMNS.DESCRIPTION", "Manage team approvals and reports"),
                        ("PAGES.USERS.ROLES.COLUMNS.ASSIGNED_USERS", "18")),
                    Row(
                        ("PAGES.USERS.ROLES.COLUMNS.ROLE", "Employee"),
                        ("PAGES.USERS.ROLES.COLUMNS.DESCRIPTION", "Self-service access"),
                        ("PAGES.USERS.ROLES.COLUMNS.ASSIGNED_USERS", "420")))
            },
            ["settings"] = new(StringComparer.OrdinalIgnoreCase)
            {
                ["profile"] = Template("settings", "profile", "PAGES.SETTINGS.PROFILE.TODO"),
                ["notifications"] = Template("settings", "notifications", "PAGES.SETTINGS.NOTIFICATIONS.TODO"),
                ["system"] = Template(
                    "settings",
                    "system",
                    "PAGES.SETTINGS.SYSTEM.NOTE",
                    Row(
                        ("PAGES.SETTINGS.SYSTEM.COLUMNS.CONFIGURATION", "Primary timezone"),
                        ("PAGES.SETTINGS.SYSTEM.COLUMNS.VALUE", "(UTC+07:00) Bangkok"),
                        ("PAGES.SETTINGS.SYSTEM.COLUMNS.OWNER", "IT Platform"),
                        ("PAGES.SETTINGS.SYSTEM.COLUMNS.UPDATED", "2025-02-15")),
                    Row(
                        ("PAGES.SETTINGS.SYSTEM.COLUMNS.CONFIGURATION", "Workweek template"),
                        ("PAGES.SETTINGS.SYSTEM.COLUMNS.VALUE", "Mon-Fri, 09:00-18:00"),
                        ("PAGES.SETTINGS.SYSTEM.COLUMNS.OWNER", "People Operations"),
                        ("PAGES.SETTINGS.SYSTEM.COLUMNS.UPDATED", "2025-01-08")),
                    Row(
                        ("PAGES.SETTINGS.SYSTEM.COLUMNS.CONFIGURATION", "Public holiday set"),
                        ("PAGES.SETTINGS.SYSTEM.COLUMNS.VALUE", "Thailand 2025"),
                        ("PAGES.SETTINGS.SYSTEM.COLUMNS.OWNER", "People Operations"),
                        ("PAGES.SETTINGS.SYSTEM.COLUMNS.UPDATED", "2025-02-01")),
                    Row(
                        ("PAGES.SETTINGS.SYSTEM.COLUMNS.CONFIGURATION", "Data residency"),
                        ("PAGES.SETTINGS.SYSTEM.COLUMNS.VALUE", "ap-southeast-1"),
                        ("PAGES.SETTINGS.SYSTEM.COLUMNS.OWNER", "Security Office"),
                        ("PAGES.SETTINGS.SYSTEM.COLUMNS.UPDATED", "2024-12-12"))),
                ["security"] = Template(
                    "settings",
                    "security",
                    "PAGES.SETTINGS.SECURITY.NOTE",
                    Row(
                        ("PAGES.SETTINGS.SECURITY.COLUMNS.CONTROL", "Multi-factor authentication"),
                        ("PAGES.SETTINGS.SECURITY.COLUMNS.STATUS", "Enforced"),
                        ("PAGES.SETTINGS.SECURITY.COLUMNS.LAST_REVIEW", "2025-02-28"),
                        ("PAGES.SETTINGS.SECURITY.COLUMNS.OWNER", "Security Office")),
                    Row(
                        ("PAGES.SETTINGS.SECURITY.COLUMNS.CONTROL", "Password policy"),
                        ("PAGES.SETTINGS.SECURITY.COLUMNS.STATUS", "12 chars / rotation 90 days"),
                        ("PAGES.SETTINGS.SECURITY.COLUMNS.LAST_REVIEW", "2025-01-15"),
                        ("PAGES.SETTINGS.SECURITY.COLUMNS.OWNER", "Security Office")),
                    Row(
                        ("PAGES.SETTINGS.SECURITY.COLUMNS.CONTROL", "Privileged access review"),
                        ("PAGES.SETTINGS.SECURITY.COLUMNS.STATUS", "In progress"),
                        ("PAGES.SETTINGS.SECURITY.COLUMNS.LAST_REVIEW", "2025-03-05"),
                        ("PAGES.SETTINGS.SECURITY.COLUMNS.OWNER", "Internal Audit")),
                    Row(
                        ("PAGES.SETTINGS.SECURITY.COLUMNS.CONTROL", "Data loss prevention"),
                        ("PAGES.SETTINGS.SECURITY.COLUMNS.STATUS", "Alerting"),
                        ("PAGES.SETTINGS.SECURITY.COLUMNS.LAST_REVIEW", "2025-02-10"),
                        ("PAGES.SETTINGS.SECURITY.COLUMNS.OWNER", "Security Office")))
            }
        };
    }

    private static PageTemplate Template(string module, string page, string? noteKey, params PageRowDto[] rows)
        => new(module, page, noteKey, rows.ToList());

    private static PageRowDto Row(params (string Key, string Value)[] columns)
    {
        var dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        foreach (var (key, value) in columns)
        {
            dictionary[key] = value;
        }

        return new PageRowDto(dictionary);
    }
}
