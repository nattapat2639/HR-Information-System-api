using System.Globalization;
using System.Linq;
using System.Text;
using Hris.Application.DTOs.EmployeeRecords;
using Hris.Application.DTOs.PageData;
using Hris.Application.Interfaces.Services;
using Hris.Infrastructure.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hris.Api.Controllers;

[ApiController]
[Route("api/employee-records")]
public class EmployeeRecordsController : ControllerBase
{
    private const int ExportPageSize = 200;
    private readonly IPageDataService _pageDataService;
    private readonly HrisDbContext _context;

    private static readonly string[] AllHeaders =
    {
        "PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.EMPLOYEE_ID",
        "PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.NAME",
        "PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.POSITION",
        "PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.DEPARTMENT",
        "PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.STATUS",
        "PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.LAST_EVENT"
    };

    private static readonly string[] SearchHeaders =
    {
        "PAGES.EMPLOYEE_RECORDS.SEARCH.COLUMNS.EMPLOYEE_ID",
        "PAGES.EMPLOYEE_RECORDS.SEARCH.COLUMNS.NAME",
        "PAGES.EMPLOYEE_RECORDS.SEARCH.COLUMNS.DEPARTMENT",
        "PAGES.EMPLOYEE_RECORDS.SEARCH.COLUMNS.LEVEL",
        "PAGES.EMPLOYEE_RECORDS.SEARCH.COLUMNS.STATUS",
        "PAGES.EMPLOYEE_RECORDS.SEARCH.COLUMNS.EVENT"
    };

    private static readonly Dictionary<string, string> HeaderLabels = new(StringComparer.OrdinalIgnoreCase)
    {
        ["PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.EMPLOYEE_ID"] = "Employee ID",
        ["PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.NAME"] = "Name",
        ["PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.POSITION"] = "Position",
        ["PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.DEPARTMENT"] = "Department",
        ["PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.STATUS"] = "Status",
        ["PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.LAST_EVENT"] = "Latest Event",
        ["PAGES.EMPLOYEE_RECORDS.SEARCH.COLUMNS.EMPLOYEE_ID"] = "Employee ID",
        ["PAGES.EMPLOYEE_RECORDS.SEARCH.COLUMNS.NAME"] = "Name",
        ["PAGES.EMPLOYEE_RECORDS.SEARCH.COLUMNS.DEPARTMENT"] = "Department",
        ["PAGES.EMPLOYEE_RECORDS.SEARCH.COLUMNS.LEVEL"] = "Level",
        ["PAGES.EMPLOYEE_RECORDS.SEARCH.COLUMNS.STATUS"] = "Status",
        ["PAGES.EMPLOYEE_RECORDS.SEARCH.COLUMNS.EVENT"] = "Event"
    };

    public EmployeeRecordsController(IPageDataService pageDataService, HrisDbContext context)
    {
        _pageDataService = pageDataService;
        _context = context;
    }

    [HttpGet("export")]
    public async Task<IActionResult> ExportAll(CancellationToken cancellationToken)
    {
        var filters = ExtractFilters(Request.Query);
        var selectedNumbers = ParseEmployeeNumbers(Request.Query);
        var rows = await FetchAllRowsAsync("employee-records", "all", filters, cancellationToken);
        rows = FilterRowsByEmployeeNumbers(rows, selectedNumbers, "PAGES.EMPLOYEE_RECORDS.LIST.COLUMNS.EMPLOYEE_ID");
        if (rows.Count == 0)
        {
            return NotFound();
        }

        var csv = BuildCsv(rows, AllHeaders);
        var fileName = $"employee-register-{DateTime.UtcNow:yyyyMMddHHmmss}.csv";
        return File(csv, "text/csv", fileName);
    }

    [HttpGet("search/export")]
    public async Task<IActionResult> ExportSearch(CancellationToken cancellationToken)
    {
        var filters = ExtractFilters(Request.Query);
        var selectedNumbers = ParseEmployeeNumbers(Request.Query);
        var rows = await FetchAllRowsAsync("employee-records", "search", filters, cancellationToken);
        rows = FilterRowsByEmployeeNumbers(rows, selectedNumbers, "PAGES.EMPLOYEE_RECORDS.SEARCH.COLUMNS.EMPLOYEE_ID");
        if (rows.Count == 0)
        {
            return NotFound();
        }

        var csv = BuildCsv(rows, SearchHeaders);
        var fileName = $"employee-search-{DateTime.UtcNow:yyyyMMddHHmmss}.csv";
        return File(csv, "text/csv", fileName);
    }

    [HttpGet("{employeeNumber}/profile")]
    public async Task<ActionResult<EmployeeProfileDto>> GetProfile(string employeeNumber, CancellationToken cancellationToken)
    {
        if (string.IsNullOrWhiteSpace(employeeNumber))
        {
            return BadRequest();
        }

        var employee = await _context.Employees
            .AsNoTracking()
            .FirstOrDefaultAsync(e => e.EmployeeNumber == employeeNumber, cancellationToken);

        if (employee is null)
        {
            return NotFound();
        }

        var profile = BuildProfile(employee);
        return Ok(profile);
    }

    [HttpGet("search/insights")]
    public async Task<ActionResult<EmployeeSearchInsightsDto>> GetSearchInsights(CancellationToken cancellationToken)
    {
        var filters = ExtractFilters(Request.Query);
        var rows = await FetchAllRowsAsync("employee-records", "search", filters, cancellationToken);

        if (rows.Count == 0)
        {
            return Ok(new EmployeeSearchInsightsDto(Array.Empty<DistributionItemDto>(), Array.Empty<DistributionItemDto>()));
        }

        var statusCounts = rows
            .Select(row => row.Columns.TryGetValue("PAGES.EMPLOYEE_RECORDS.SEARCH.COLUMNS.STATUS", out var value) ? value ?? "Unknown" : "Unknown")
            .GroupBy(value => value)
            .Select(group => new DistributionItemDto(group.Key, group.Count()))
            .OrderByDescending(item => item.Count)
            .ToArray();

        var departmentCounts = rows
            .Select(row => row.Columns.TryGetValue("PAGES.EMPLOYEE_RECORDS.SEARCH.COLUMNS.DEPARTMENT", out var value) ? value ?? "Unassigned" : "Unassigned")
            .GroupBy(value => value)
            .Select(group => new DistributionItemDto(group.Key, group.Count()))
            .OrderByDescending(item => item.Count)
            .ThenBy(item => item.Label, StringComparer.OrdinalIgnoreCase)
            .Take(6)
            .ToArray();

        return Ok(new EmployeeSearchInsightsDto(statusCounts, departmentCounts));
    }

    private async Task<List<PageRowDto>> FetchAllRowsAsync(
        string module,
        string page,
        IReadOnlyDictionary<string, string> filters,
        CancellationToken cancellationToken)
    {
        var results = new List<PageRowDto>();
        var pageNumber = 1;

        while (true)
        {
            var data = await _pageDataService.GetPageAsync(
                module,
                page,
                pageNumber,
                ExportPageSize,
                filters,
                cancellationToken);

            if (data is null || data.Rows.Count == 0)
            {
                break;
            }

            results.AddRange(data.Rows);

            if (results.Count >= data.TotalCount)
            {
                break;
            }

            pageNumber++;
        }

        return results;
    }

    private static byte[] BuildCsv(IEnumerable<PageRowDto> rows, IReadOnlyList<string> headers)
    {
        var builder = new StringBuilder();
        builder.AppendLine(string.Join(",", headers.Select(header => EscapeCsv(HeaderLabels.TryGetValue(header, out var label) ? label : header))));

        foreach (var row in rows)
        {
            var values = headers.Select(header =>
                row.Columns.TryGetValue(header, out var value) ? EscapeCsv(value ?? string.Empty) : string.Empty);
            builder.AppendLine(string.Join(",", values));
        }

        return Encoding.UTF8.GetBytes(builder.ToString());
    }

    private static HashSet<string> ParseEmployeeNumbers(IQueryCollection query)
    {
        if (!query.TryGetValue("employeeNumbers", out var values) || values.Count == 0)
        {
            return new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        }

        var tokenArray = values.ToArray();

        return tokenArray
            .SelectMany(value => (value ?? string.Empty).Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries))
            .Select(value => value.Trim())
            .Where(value => !string.IsNullOrWhiteSpace(value))
            .ToHashSet(StringComparer.OrdinalIgnoreCase);
    }

    private static List<PageRowDto> FilterRowsByEmployeeNumbers(
        List<PageRowDto> rows,
        IReadOnlyCollection<string> employeeNumbers,
        string headerKey)
    {
        if (employeeNumbers.Count == 0)
        {
            return rows;
        }

        var allowed = new HashSet<string>(employeeNumbers, StringComparer.OrdinalIgnoreCase);
        return rows
            .Where(row =>
                row.Columns.TryGetValue(headerKey, out var value) &&
                !string.IsNullOrWhiteSpace(value) &&
                allowed.Contains(value))
            .ToList();
    }

    private EmployeeProfileDto BuildProfile(Hris.Domain.Entities.Employee employee)
    {
        var departmentPlan = _context.WorkforcePlanEntries
            .AsNoTracking()
            .FirstOrDefault(entry => entry.Department == employee.Department);

        var hiredAt = employee.HiredAt;
        var birthDate = hiredAt.AddYears(-7).AddMonths(-(Math.Abs(employee.FullName.GetHashCode()) % 6));

        var personal = new List<EmployeeProfileFieldDto>
        {
            new("PAGES.EMPLOYEE_RECORDS.PROFILE.CARDS.EMPLOYEE_ID", employee.EmployeeNumber),
            new("PAGES.EMPLOYEE_RECORDS.PROFILE.CARDS.FULL_NAME", employee.FullName),
            new("PAGES.EMPLOYEE_RECORDS.PROFILE.CARDS.NATIONAL_ID", GenerateNationalId(employee.EmployeeNumber)),
            new("PAGES.EMPLOYEE_RECORDS.PROFILE.CARDS.BIRTHDATE", birthDate.ToString("d MMM yyyy", CultureInfo.InvariantCulture))
        };

        var job = new List<EmployeeProfileFieldDto>
        {
            new("PAGES.EMPLOYEE_RECORDS.PROFILE.CARDS.TITLE", employee.Position),
            new("PAGES.EMPLOYEE_RECORDS.PROFILE.CARDS.MANAGER", departmentPlan?.DepartmentLead ?? "N/A"),
            new("PAGES.EMPLOYEE_RECORDS.PROFILE.CARDS.DEPARTMENT", employee.Department),
            new("PAGES.EMPLOYEE_RECORDS.PROFILE.CARDS.LOCATION", ResolveLocation(employee.Department))
        };

        var contact = new List<EmployeeProfileFieldDto>
        {
            new("PAGES.EMPLOYEE_RECORDS.PROFILE.CARDS.EMAIL", GenerateEmail(employee.FullName)),
            new("PAGES.EMPLOYEE_RECORDS.PROFILE.CARDS.PHONE", GeneratePhone(employee.EmployeeNumber)),
            new("PAGES.EMPLOYEE_RECORDS.PROFILE.CARDS.EMERGENCY", GenerateEmergencyContact(employee.FullName))
        };

        var timeline = BuildTimeline(employee);
        var documents = BuildDocuments(employee);

        return new EmployeeProfileDto(
            employee.EmployeeNumber,
            employee.FullName,
            personal,
            job,
            contact,
            timeline,
            documents);
    }

    private static IReadOnlyCollection<EmployeeTimelineEventDto> BuildTimeline(Hris.Domain.Entities.Employee employee)
    {
        var baseDate = employee.HiredAt;
        var events = new List<EmployeeTimelineEventDto>
        {
            new(
                baseDate.AddMonths(16),
                "PAGES.EMPLOYEE_RECORDS.PROFILE.TIMELINE.CATEGORIES.PROMOTION",
                "promotion",
                $"Promoted to {PromotedTitle(employee.Position)}",
                "Expanded responsibilities across platform reliability and mentoring guild leads.",
                "upgrade"),
            new(
                baseDate.AddMonths(10),
                "PAGES.EMPLOYEE_RECORDS.PROFILE.TIMELINE.CATEGORIES.RECOGNITION",
                "recognition",
                "Received quarterly leadership recognition",
                "Awarded for resolving a major incident and supporting new engineers onboarding.",
                "emoji_events"),
            new(
                baseDate.AddMonths(5),
                "PAGES.EMPLOYEE_RECORDS.PROFILE.TIMELINE.CATEGORIES.TRANSFER",
                "transfer",
                $"Rotation into {employee.Department} excellence squad",
                "Moved to accelerate cross-team collaboration and build shared playbooks.",
                "sync_alt"),
            new(
                baseDate.AddMonths(1),
                "PAGES.EMPLOYEE_RECORDS.PROFILE.TIMELINE.CATEGORIES.DEVELOPMENT",
                "development",
                "Completed leadership accelerator program",
                "Finished six-week course focusing on stakeholder communication and coaching skills.",
                "school")
        };

        return events
            .OrderByDescending(@event => @event.Date)
            .ToArray();
    }

    private static IReadOnlyCollection<EmployeeDocumentDto> BuildDocuments(Hris.Domain.Entities.Employee employee)
    {
        var baseDate = employee.HiredAt;
        return new[]
        {
            new EmployeeDocumentDto("PAGES.EMPLOYEE_RECORDS.PROFILE.DOCUMENTS.CONTRACT", baseDate.AddMonths(14)),
            new EmployeeDocumentDto("PAGES.EMPLOYEE_RECORDS.PROFILE.DOCUMENTS.PERFORMANCE", baseDate.AddMonths(12)),
            new EmployeeDocumentDto("PAGES.EMPLOYEE_RECORDS.PROFILE.DOCUMENTS.CERTIFICATION", baseDate.AddMonths(8))
        };
    }

    private static string GenerateNationalId(string employeeNumber)
    {
        var digitsOnly = new string(employeeNumber.Where(char.IsDigit).ToArray());
        if (digitsOnly.Length < 13)
        {
            digitsOnly = digitsOnly.PadRight(13, '7');
        }

        digitsOnly = digitsOnly[..13];

        return string.Create(17, digitsOnly, static (span, data) =>
        {
            span[0] = data[0];
            span[1] = data[1];
            span[2] = data[2];
            span[3] = '-';
            span[4] = data[3];
            span[5] = '-';
            span[6] = data[4];
            span[7] = data[5];
            span[8] = data[6];
            span[9] = data[7];
            span[10] = data[8];
            span[11] = '-';
            span[12] = data[9];
            span[13] = data[10];
            span[14] = '-';
            span[15] = data[11];
            span[16] = data[12];
        });
    }

    private static string GenerateEmail(string fullName)
    {
        var slug = fullName.ToLowerInvariant().Replace(' ', '.');
        return $"{slug}@example.com";
    }

    private static string GeneratePhone(string employeeNumber)
    {
        var digits = new string(employeeNumber.Where(char.IsDigit).ToArray());
        if (digits.Length < 9)
        {
            digits = digits.PadLeft(9, '4');
        }

        return $"+66 8{digits[0]} {digits[1..5]} {digits[5..9]}";
    }

    private static string GenerateEmergencyContact(string fullName)
    {
        var parts = fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        var contactName = parts.Length > 1 ? parts[^1] : "Family";
        return $"{contactName} {parts[0]} • +66 8{(parts.Length > 1 ? parts[^1].Length : 7)} 123 4567";
    }

    private static string ResolveLocation(string department)
    {
        return department switch
        {
            "Technology" or "Data & Analytics" => "Headquarters • Hybrid",
            "Sales" or "Marketing" => "Headquarters • Office",
            "Customer Success" => "Regional Hub",
            _ => "Headquarters"
        };
    }

    private static string PromotedTitle(string position)
    {
        if (position.Contains("Engineer", StringComparison.OrdinalIgnoreCase))
        {
            return "Principal " + position.Replace("Engineer", "Engineer", StringComparison.OrdinalIgnoreCase);
        }

        if (position.Contains("Manager", StringComparison.OrdinalIgnoreCase))
        {
            return position.Replace("Manager", "Senior Manager", StringComparison.OrdinalIgnoreCase);
        }

        return "Lead " + position;
    }

    private static IReadOnlyDictionary<string, string> ExtractFilters(IQueryCollection query)
    {
        var result = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        foreach (var entry in query)
        {
            if (string.Equals(entry.Key, "page", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(entry.Key, "pageNumber", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(entry.Key, "pageSize", StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            var value = entry.Value.ToString();
            if (!string.IsNullOrWhiteSpace(value))
            {
                result[entry.Key] = value.Trim();
            }
        }

        return result;
    }

    private static string EscapeCsv(string value)
    {
        if (value.Contains(',') || value.Contains('"'))
        {
            var escaped = value.Replace("\"", "\"\"", StringComparison.Ordinal);
            return $"\"{escaped}\"";
        }

        return value;
    }
}
