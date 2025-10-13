using System.Text;
using Hris.Application.DTOs.PageData;
using Hris.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hris.Api.Controllers;

[ApiController]
[Route("api/employee-records")]
public class EmployeeRecordsController : ControllerBase
{
    private const int ExportPageSize = 200;
    private readonly IPageDataService _pageDataService;

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

    public EmployeeRecordsController(IPageDataService pageDataService)
    {
        _pageDataService = pageDataService;
    }

    [HttpGet("export")]
    public async Task<IActionResult> ExportAll(CancellationToken cancellationToken)
    {
        var filters = ExtractFilters(Request.Query);
        var rows = await FetchAllRowsAsync("employee-records", "all", filters, cancellationToken);
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
        var rows = await FetchAllRowsAsync("employee-records", "search", filters, cancellationToken);
        if (rows.Count == 0)
        {
            return NotFound();
        }

        var csv = BuildCsv(rows, SearchHeaders);
        var fileName = $"employee-search-{DateTime.UtcNow:yyyyMMddHHmmss}.csv";
        return File(csv, "text/csv", fileName);
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
