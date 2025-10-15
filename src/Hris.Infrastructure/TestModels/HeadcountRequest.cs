using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.TestModels;

public partial class HeadcountRequest
{
    public Guid Id { get; set; }

    public string Department { get; set; } = null!;

    public int RequestedHeadcount { get; set; }

    public string RequestedBy { get; set; } = null!;

    public string Justification { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime RequestedAtUtc { get; set; }

    public DateTime? ResolvedAtUtc { get; set; }
}
