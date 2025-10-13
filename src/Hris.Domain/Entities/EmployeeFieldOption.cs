namespace Hris.Domain.Entities;

public class EmployeeFieldOption
{
    public Guid Id { get; set; }
    public Guid FieldDefinitionId { get; set; }
    public string Label { get; set; } = default!;
    public string Value { get; set; } = default!;
    public int SortOrder { get; set; }

    public EmployeeFieldDefinition? FieldDefinition { get; set; }
}
