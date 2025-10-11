using Hris.Application.DTOs.PageData;

namespace Hris.Application.Interfaces.Services;

public interface IPageDataService
{
    Task<PageDataDto?> GetPageAsync(
        string module,
        string page,
        int pageNumber,
        int pageSize,
        IReadOnlyDictionary<string, string> filters,
        CancellationToken cancellationToken = default);
}
