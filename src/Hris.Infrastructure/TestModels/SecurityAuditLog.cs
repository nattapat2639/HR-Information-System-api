using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.TestModels;

public partial class SecurityAuditLog
{
    public Guid Id { get; set; }

    public DateTime RunAtUtc { get; set; }

    public string PerformedBy { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string Summary { get; set; } = null!;
}
