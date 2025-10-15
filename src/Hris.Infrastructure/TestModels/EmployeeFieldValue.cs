using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.TestModels;

public partial class EmployeeFieldValue
{
    public Guid Id { get; set; }

    public Guid EmployeeId { get; set; }

    public Guid FieldDefinitionId { get; set; }

    public string Value { get; set; } = null!;

    public DateTime UpdatedAtUtc { get; set; }

    public string? UpdatedBy { get; set; }

    public virtual Employee Employee { get; set; } = null!;

    public virtual EmployeeFieldDefinition FieldDefinition { get; set; } = null!;
}
