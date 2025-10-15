using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.TestModels;

public partial class LeaveRequest
{
    public Guid Id { get; set; }

    public Guid EmployeeId { get; set; }

    public string Reference { get; set; } = null!;

    public string LeaveType { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string Status { get; set; } = null!;

    public DateTime RequestedOn { get; set; }

    public virtual Employee Employee { get; set; } = null!;
}
