using Hris.Application.DTOs;

namespace Hris.Application.Interfaces.Services;

public interface IEmployeeService
{
    Task<PagedResult<EmployeeDto>> GetEmployeesAsync(int page, int pageSize, CancellationToken cancellationToken = default);
    Task<EmployeeDto?> GetEmployeeAsync(Guid id, CancellationToken cancellationToken = default);
}
