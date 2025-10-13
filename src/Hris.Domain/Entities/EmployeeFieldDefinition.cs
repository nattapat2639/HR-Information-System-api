namespace Hris.Domain.Entities;

public class EmployeeFieldDefinition
{
    public Guid Id { get; set; }
    public string FieldKey { get; set; } = default!;
    public string DisplayName { get; set; } = default!;
    public string DataType { get; set; } = "text";
    public bool IsRequired { get; set; }
    public string Category { get; set; } = "General";
    public int SortOrder { get; set; }
    public string? Description { get; set; }
    public bool IsActive { get; set; } = true;

    public ICollection<EmployeeFieldOption> Options { get; set; } = new List<EmployeeFieldOption>();
}
