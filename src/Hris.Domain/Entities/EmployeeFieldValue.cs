namespace Hris.Domain.Entities;

public class EmployeeFieldValue
{
    public Guid Id { get; set; }
    public Guid EmployeeId { get; set; }
    public Guid FieldDefinitionId { get; set; }
    public string Value { get; set; } = string.Empty;
    public DateTime UpdatedAtUtc { get; set; }
    public string? UpdatedBy { get; set; }

    public Employee? Employee { get; set; }
    public EmployeeFieldDefinition? FieldDefinition { get; set; }
}
