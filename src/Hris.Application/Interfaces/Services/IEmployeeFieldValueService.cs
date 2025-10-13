using Hris.Application.DTOs.EmployeeRecords;

namespace Hris.Application.Interfaces.Services;

public interface IEmployeeFieldValueService
{
    Task<EmployeeFieldValueSetDto?> GetForEmployeeAsync(string employeeNumber, CancellationToken cancellationToken = default);
    Task<EmployeeFieldValueSetDto?> UpdateForEmployeeAsync(string employeeNumber, EmployeeFieldValueUpdateCommand command, CancellationToken cancellationToken = default);
}
