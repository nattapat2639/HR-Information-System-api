using System;

namespace Hris.Domain.Entities;

public class UserRoleSummary
{
    public Guid Id { get; set; }
    public string Role { get; set; } = default!;
    public string Description { get; set; } = default!;
    public int AssignedUsers { get; set; }
}
