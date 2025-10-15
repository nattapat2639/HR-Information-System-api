using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.TestModels;

public partial class NotificationPreference
{
    public Guid Id { get; set; }

    public string Channel { get; set; } = null!;

    public string Frequency { get; set; } = null!;
}
