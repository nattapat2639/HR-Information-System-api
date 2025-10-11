using Hris.Application.DTOs.PageData;
using Hris.Application.Interfaces.Repositories;
using Hris.Application.Interfaces.Services;

namespace Hris.Application.Services;

public class PageDataService : IPageDataService
{
    private readonly IPageDataRepository _repository;

    public PageDataService(IPageDataRepository repository)
    {
        _repository = repository;
    }

    public Task<PageDataDto?> GetPageAsync(
        string module,
        string page,
        int pageNumber,
        int pageSize,
        IReadOnlyDictionary<string, string> filters,
        CancellationToken cancellationToken = default)
        => _repository.GetPageAsync(module, page, pageNumber, pageSize, filters, cancellationToken);
}
