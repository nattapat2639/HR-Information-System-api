using System;

namespace Hris.Domain.Entities;

public class PerformanceReview
{
    public Guid Id { get; set; }
    public Guid EmployeeId { get; set; }
    public string ReviewCycle { get; set; } = default!;
    public decimal Score { get; set; }
    public string ManagerName { get; set; } = default!;
    public string Status { get; set; } = default!;

    public Employee? Employee { get; set; }
}
