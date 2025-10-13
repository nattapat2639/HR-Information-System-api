using Hris.Application.DTOs.EmployeeRecords;
using Hris.Domain.Entities;

namespace Hris.Application.Mapping;

public static class EmployeeFieldDefinitionMappingExtensions
{
    public static EmployeeFieldDefinitionDto ToDto(this EmployeeFieldDefinition definition)
        => new(
            definition.Id,
            definition.FieldKey,
            definition.DisplayName,
            definition.DataType,
            definition.IsRequired,
            definition.Category,
            definition.SortOrder,
            definition.IsActive,
            definition.Description,
            definition.Options
                .OrderBy(option => option.SortOrder)
                .ThenBy(option => option.Label, StringComparer.OrdinalIgnoreCase)
                .Select(option => new EmployeeFieldOptionDto(
                    option.Id,
                    option.Label,
                    option.Value,
                    option.SortOrder))
                .ToArray());
}
