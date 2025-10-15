using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.TestModels;

public partial class WorkforcePlanEntry
{
    public Guid Id { get; set; }

    public string Department { get; set; } = null!;

    public string DepartmentLead { get; set; } = null!;

    public string Focus { get; set; } = null!;

    public int ApprovedHeadcountQ3 { get; set; }

    public string AttritionRisk { get; set; } = null!;

    public string NextCriticalHire { get; set; } = null!;

    public DateTime UpdatedAtUtc { get; set; }

    public string Owner { get; set; } = null!;
}
