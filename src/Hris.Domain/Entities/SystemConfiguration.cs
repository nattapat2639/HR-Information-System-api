using System;

namespace Hris.Domain.Entities;

public class SystemConfiguration
{
    public Guid Id { get; set; }
    public string Timezone { get; set; } = default!;
    public string Workweek { get; set; } = default!;
}
