using Hris.Application.DTOs.EmployeeRecords;

namespace Hris.Application.Interfaces.Services;

public interface IEmployeeFieldDefinitionService
{
    Task<IReadOnlyCollection<EmployeeFieldDefinitionDto>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<EmployeeFieldDefinitionDto?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<EmployeeFieldDefinitionDto> CreateAsync(EmployeeFieldDefinitionRequest request, CancellationToken cancellationToken = default);
    Task<EmployeeFieldDefinitionDto?> UpdateAsync(Guid id, EmployeeFieldDefinitionRequest request, CancellationToken cancellationToken = default);
    Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default);
}
