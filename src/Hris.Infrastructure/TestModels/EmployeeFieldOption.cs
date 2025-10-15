using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.TestModels;

public partial class EmployeeFieldOption
{
    public Guid Id { get; set; }

    public Guid FieldDefinitionId { get; set; }

    public string Label { get; set; } = null!;

    public string Value { get; set; } = null!;

    public int SortOrder { get; set; }

    public virtual EmployeeFieldDefinition FieldDefinition { get; set; } = null!;
}
