using System;

namespace Hris.Domain.Entities;

public class SystemConfiguration
{
    public Guid Id { get; set; }
    public string Key { get; set; } = default!;
    public string Value { get; set; } = default!;
    public string Owner { get; set; } = default!;
    public DateTime UpdatedAtUtc { get; set; }
    public string Category { get; set; } = "General";
}
