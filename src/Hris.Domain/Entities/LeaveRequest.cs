using System;

namespace Hris.Domain.Entities;

public class LeaveRequest
{
    public Guid Id { get; set; }
    public Guid EmployeeId { get; set; }
    public string Reference { get; set; } = default!;
    public string LeaveType { get; set; } = default!;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Status { get; set; } = default!;
    public DateTime RequestedOn { get; set; }

    public Employee? Employee { get; set; }
}
