using System;

namespace Hris.Domain.Entities;

public class PayrollSummaryRecord
{
    public Guid Id { get; set; }
    public string Department { get; set; } = default!;
    public string Period { get; set; } = default!;
    public int TotalEmployees { get; set; }
    public decimal GrossPay { get; set; }
    public decimal NetPay { get; set; }
    public string Status { get; set; } = default!;
}
