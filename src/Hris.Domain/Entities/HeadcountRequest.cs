using System;

namespace Hris.Domain.Entities;

public class HeadcountRequest
{
    public Guid Id { get; set; }
    public string Department { get; set; } = default!;
    public int RequestedHeadcount { get; set; }
    public string RequestedBy { get; set; } = default!;
    public string Justification { get; set; } = default!;
    public string Status { get; set; } = "Pending";
    public DateTime RequestedAtUtc { get; set; }
    public DateTime? ResolvedAtUtc { get; set; }
}
