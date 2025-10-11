using System;

namespace Hris.Domain.Entities;

public class NotificationPreference
{
    public Guid Id { get; set; }
    public string Channel { get; set; } = default!;
    public string Frequency { get; set; } = default!;
}
