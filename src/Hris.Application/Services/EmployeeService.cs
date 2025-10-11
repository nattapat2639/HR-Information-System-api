using System.Linq;
using Hris.Application.DTOs;
using Hris.Application.Interfaces.Repositories;
using Hris.Application.Interfaces.Services;
using Hris.Application.Mapping;

namespace Hris.Application.Services;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _repository;

    public EmployeeService(IEmployeeRepository repository)
    {
        _repository = repository;
    }

    public async Task<PagedResult<EmployeeDto>> GetEmployeesAsync(int page, int pageSize, CancellationToken cancellationToken = default)
    {
        var records = await _repository.GetAllAsync(cancellationToken);
        var total = records.Count;
        var skip = Math.Max(page - 1, 0) * pageSize;
        var items = records
            .Skip(skip)
            .Take(pageSize)
            .Select(employee => employee.ToDto())
            .ToList();

        return new PagedResult<EmployeeDto>(items, total, page, pageSize);
    }

    public async Task<EmployeeDto?> GetEmployeeAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var employee = await _repository.GetByIdAsync(id, cancellationToken);
        return employee?.ToDto();
    }
}
