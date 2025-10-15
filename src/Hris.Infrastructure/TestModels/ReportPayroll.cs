using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.TestModels;

public partial class ReportPayroll
{
    public Guid Id { get; set; }

    public string PayGroup { get; set; } = null!;

    public decimal GrossPay { get; set; }

    public decimal NetPay { get; set; }

    public string Status { get; set; } = null!;
}
