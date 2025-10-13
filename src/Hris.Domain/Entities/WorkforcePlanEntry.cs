using System;

namespace Hris.Domain.Entities;

public class WorkforcePlanEntry
{
    public Guid Id { get; set; }
    public string Department { get; set; } = default!;
    public string DepartmentLead { get; set; } = default!;
    public string Focus { get; set; } = default!;
    public int ApprovedHeadcountQ3 { get; set; }
    public string AttritionRisk { get; set; } = default!;
    public string NextCriticalHire { get; set; } = default!;
    public DateTime UpdatedAtUtc { get; set; }
    public string Owner { get; set; } = "People Operations";
}
