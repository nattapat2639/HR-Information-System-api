using System;

namespace Hris.Domain.Entities;

public class ReportPerformanceRecord
{
    public Guid Id { get; set; }
    public string Department { get; set; } = default!;
    public decimal AverageScore { get; set; }
    public string Trend { get; set; } = default!;
    public string Status { get; set; } = default!;
}
