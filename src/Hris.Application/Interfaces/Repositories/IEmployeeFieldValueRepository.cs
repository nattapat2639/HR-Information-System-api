using Hris.Domain.Entities;

namespace Hris.Application.Interfaces.Repositories;

public interface IEmployeeFieldValueRepository
{
    Task<IReadOnlyCollection<EmployeeFieldValue>> GetByEmployeeAsync(Guid employeeId, CancellationToken cancellationToken = default);
    Task ReplaceAsync(Guid employeeId, IReadOnlyCollection<EmployeeFieldValue> values, CancellationToken cancellationToken = default);
}
