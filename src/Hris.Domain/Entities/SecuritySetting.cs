using System;

namespace Hris.Domain.Entities;

public class SecuritySetting
{
    public Guid Id { get; set; }
    public string MfaMode { get; set; } = default!;
    public string PasswordPolicy { get; set; } = default!;
}
