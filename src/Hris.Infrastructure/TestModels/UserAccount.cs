using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.TestModels;

public partial class UserAccount
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Role { get; set; } = null!;

    public string Status { get; set; } = null!;
}
