using Hris.Application.DTOs;
using Hris.Domain.Entities;

namespace Hris.Application.Mapping;

public static class EmployeeMappingExtensions
{
    public static EmployeeDto ToDto(this Employee employee) => new()
    {
        Id = employee.Id,
        EmployeeNumber = employee.EmployeeNumber,
        FullName = employee.FullName,
        Department = employee.Department,
        Position = employee.Position,
        Status = employee.Status,
        HiredAt = employee.HiredAt
    };
}
