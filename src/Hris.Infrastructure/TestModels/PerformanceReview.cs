using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.TestModels;

public partial class PerformanceReview
{
    public Guid Id { get; set; }

    public Guid EmployeeId { get; set; }

    public string ReviewCycle { get; set; } = null!;

    public decimal Score { get; set; }

    public string ManagerName { get; set; } = null!;

    public string Status { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;
}
