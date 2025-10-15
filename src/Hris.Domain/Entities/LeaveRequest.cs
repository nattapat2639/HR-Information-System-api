using System;

namespace Hris.Domain.Entities;

public class LeaveRequest
{
    public Guid Id { get; set; }
    public Guid EmployeeId { get; set; }
    public string Reference { get; set; } = default!;
    public string LeaveType { get; set; } = default!;
    public string? Reason { get; set; }
    public bool IsHalfDay { get; set; }
    public string? ContactDuringLeave { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Status { get; set; } = default!;
    public DateTime RequestedOn { get; set; }
    public Guid? ApproverId { get; set; }
    public string? ApproverName { get; set; }
    public DateTime? DecisionOn { get; set; }
    public string? ManagerComment { get; set; }
    public string? SupportingDocumentUrl { get; set; }

    public Employee? Employee { get; set; }
}
