using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.TestModels;

public partial class ReportLeaf
{
    public Guid Id { get; set; }

    public string Employee { get; set; } = null!;

    public string LeaveType { get; set; } = null!;

    public int DaysUsed { get; set; }

    public string Status { get; set; } = null!;
}
