namespace Hris.Application.DTOs.EmployeeRecords;

public record EmployeeFieldValueSetDto(
    Guid EmployeeId,
    string EmployeeNumber,
    IReadOnlyCollection<EmployeeFieldWithValueDto> Fields);

public record EmployeeFieldWithValueDto(
    Guid FieldDefinitionId,
    string FieldKey,
    string DisplayName,
    string DataType,
    bool IsRequired,
    string Category,
    int SortOrder,
    bool IsActive,
    string? Description,
    IReadOnlyCollection<EmployeeFieldOptionDto> Options,
    string? Value,
    DateTime? UpdatedAtUtc,
    string? UpdatedBy);

public record EmployeeFieldValueUpdateItem(
    string FieldKey,
    string? Value,
    IReadOnlyCollection<string>? Values);

public record EmployeeFieldValueUpdateCommand(
    string UpdatedBy,
    IReadOnlyCollection<EmployeeFieldValueUpdateItem> Fields);
