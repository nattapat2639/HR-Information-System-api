using Hris.Application.DTOs.PageData;

namespace Hris.Application.Interfaces.Repositories;

public interface IPageDataRepository
{
    Task<PageDataDto?> GetPageAsync(
        string module,
        string page,
        int pageNumber,
        int pageSize,
        IReadOnlyDictionary<string, string> filters,
        CancellationToken cancellationToken = default);
}
