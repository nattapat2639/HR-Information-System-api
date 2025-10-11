using Hris.Domain.Entities;

namespace Hris.Application.Interfaces.Repositories;

public interface IEmployeeRepository
{
    Task<IReadOnlyCollection<Employee>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<Employee?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task AddAsync(Employee employee, CancellationToken cancellationToken = default);
}
