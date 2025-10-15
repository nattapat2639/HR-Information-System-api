using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.TestModels;

public partial class UserRole
{
    public Guid Id { get; set; }

    public string Role { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int AssignedUsers { get; set; }
}
