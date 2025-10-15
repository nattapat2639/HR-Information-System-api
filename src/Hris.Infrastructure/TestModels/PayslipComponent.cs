using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.TestModels;

public partial class PayslipComponent
{
    public Guid Id { get; set; }

    public Guid EmployeeId { get; set; }

    public string PayPeriod { get; set; } = null!;

    public string ComponentName { get; set; } = null!;

    public decimal Amount { get; set; }

    public string? Notes { get; set; }

    public virtual Employee Employee { get; set; } = null!;
}
