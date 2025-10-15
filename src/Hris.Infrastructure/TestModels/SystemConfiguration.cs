using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.TestModels;

public partial class SystemConfiguration
{
    public Guid Id { get; set; }

    public string Owner { get; set; } = null!;

    public string Key { get; set; } = null!;

    public string Category { get; set; } = null!;

    public DateTime UpdatedAtUtc { get; set; }

    public string Value { get; set; } = null!;
}
