using System;

namespace Hris.Domain.Entities;

public class EmployeePayslipComponent
{
    public Guid Id { get; set; }
    public Guid EmployeeId { get; set; }
    public string PayPeriod { get; set; } = default!;
    public string ComponentName { get; set; } = default!;
    public decimal Amount { get; set; }
    public string? Notes { get; set; }

    public Employee? Employee { get; set; }
}
