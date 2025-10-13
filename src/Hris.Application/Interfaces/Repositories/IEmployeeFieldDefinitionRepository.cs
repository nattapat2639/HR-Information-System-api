using Hris.Domain.Entities;

namespace Hris.Application.Interfaces.Repositories;

public interface IEmployeeFieldDefinitionRepository
{
    Task<IReadOnlyCollection<EmployeeFieldDefinition>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<EmployeeFieldDefinition?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task AddAsync(EmployeeFieldDefinition definition, CancellationToken cancellationToken = default);
    Task UpdateAsync(EmployeeFieldDefinition definition, CancellationToken cancellationToken = default);
    Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default);
    Task<bool> FieldKeyExistsAsync(string fieldKey, Guid? excludeId = null, CancellationToken cancellationToken = default);
}
