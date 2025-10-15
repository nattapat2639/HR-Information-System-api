using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.TestModels;

public partial class ReportPerformance
{
    public Guid Id { get; set; }

    public string Department { get; set; } = null!;

    public decimal AverageScore { get; set; }

    public string Trend { get; set; } = null!;

    public string Status { get; set; } = null!;
}
