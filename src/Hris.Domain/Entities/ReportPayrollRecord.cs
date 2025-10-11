using System;

namespace Hris.Domain.Entities;

public class ReportPayrollRecord
{
    public Guid Id { get; set; }
    public string PayGroup { get; set; } = default!;
    public decimal GrossPay { get; set; }
    public decimal NetPay { get; set; }
    public string Status { get; set; } = default!;
}
