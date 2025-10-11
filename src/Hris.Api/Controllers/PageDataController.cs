using Hris.Application.DTOs.PageData;
using Hris.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hris.Api.Controllers;

[ApiController]
[Route("api/page-data")]
public class PageDataController : ControllerBase
{
    private readonly IPageDataService _pageDataService;

    public PageDataController(IPageDataService pageDataService)
    {
        _pageDataService = pageDataService;
    }

    [HttpGet("{module}/{page}")]
    [ProducesResponseType(typeof(PageDataDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetPageData(
        string module,
        string page,
        CancellationToken cancellationToken = default)
    {
        var (pageNumber, pageSize) = ResolvePagination(Request.Query);
        var filters = ExtractFilters(Request.Query);

        var data = await _pageDataService.GetPageAsync(
            module,
            page,
            pageNumber,
            pageSize,
            filters,
            cancellationToken);

        if (data is null)
        {
            return NotFound();
        }

        return Ok(data);
    }

    private static (int PageNumber, int PageSize) ResolvePagination(IQueryCollection query)
    {
        const int defaultPage = 1;
        const int defaultSize = 20;

        int TryParse(string key)
        {
            if (query.TryGetValue(key, out var value) && int.TryParse(value, out var parsed))
            {
                return parsed;
            }

            return -1;
        }

        var page = TryParse("pageNumber");
        if (page <= 0)
        {
            page = TryParse("page");
        }
        if (page <= 0)
        {
            page = defaultPage;
        }

        var size = TryParse("pageSize");
        if (size <= 0)
        {
            size = defaultSize;
        }

        return (page, size);
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
}
