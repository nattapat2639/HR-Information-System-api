using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.TestModels;

public partial class PayrollSummary
{
    public Guid Id { get; set; }

    public string Department { get; set; } = null!;

    public string Period { get; set; } = null!;

    public int TotalEmployees { get; set; }

    public decimal GrossPay { get; set; }

    public decimal NetPay { get; set; }

    public string Status { get; set; } = null!;
}
