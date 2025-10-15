using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.TestModels;

public partial class EmployeeFieldDefinition
{
    public Guid Id { get; set; }

    public string FieldKey { get; set; } = null!;

    public string DisplayName { get; set; } = null!;

    public string DataType { get; set; } = null!;

    public bool IsRequired { get; set; }

    public string Category { get; set; } = null!;

    public int SortOrder { get; set; }

    public string? Description { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<EmployeeFieldOption> EmployeeFieldOptions { get; set; } = new List<EmployeeFieldOption>();

    public virtual ICollection<EmployeeFieldValue> EmployeeFieldValues { get; set; } = new List<EmployeeFieldValue>();
}
