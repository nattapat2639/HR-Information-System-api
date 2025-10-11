using System;

namespace Hris.Domain.Entities;

public class ReportLeaveRecord
{
    public Guid Id { get; set; }
    public string Employee { get; set; } = default!;
    public string LeaveType { get; set; } = default!;
    public int DaysUsed { get; set; }
    public string Status { get; set; } = default!;
}
