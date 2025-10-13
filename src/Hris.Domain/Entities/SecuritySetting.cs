using System;

namespace Hris.Domain.Entities;

public class SecuritySetting
{
    public Guid Id { get; set; }
    public string Control { get; set; } = default!;
    public string Status { get; set; } = default!;
    public string Owner { get; set; } = default!;
    public DateTime LastReviewedAtUtc { get; set; }
    public string Severity { get; set; } = "Medium";
}
