using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.TestModels;

public partial class SecuritySetting
{
    public Guid Id { get; set; }

    public string Control { get; set; } = null!;

    public DateTime LastReviewedAtUtc { get; set; }

    public string Owner { get; set; } = null!;

    public string Severity { get; set; } = null!;

    public string Status { get; set; } = null!;
}
