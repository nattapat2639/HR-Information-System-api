using System;

namespace Hris.Domain.Entities;

public class SecurityAuditLog
{
    public Guid Id { get; set; }
    public DateTime RunAtUtc { get; set; }
    public string PerformedBy { get; set; } = default!;
    public string Status { get; set; } = default!;
    public string Summary { get; set; } = default!;
}
