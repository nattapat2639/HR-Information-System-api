namespace Hris.Application.DTOs.EmployeeRecords;

public record EmployeeFieldDefinitionDto(
    Guid Id,
    string FieldKey,
    string DisplayName,
    string DataType,
    bool IsRequired,
    string Category,
    int SortOrder,
    bool IsActive,
    string? Description,
    IReadOnlyCollection<EmployeeFieldOptionDto> Options);

public record EmployeeFieldOptionDto(
    Guid Id,
    string Label,
    string Value,
    int SortOrder);

public record EmployeeFieldDefinitionRequest(
    string FieldKey,
    string DisplayName,
    string DataType,
    bool IsRequired,
    string Category,
    int SortOrder,
    bool IsActive,
    string? Description,
    IReadOnlyCollection<EmployeeFieldOptionRequest> Options);

public record EmployeeFieldOptionRequest(
    string Label,
    string? Value,
    int SortOrder);
