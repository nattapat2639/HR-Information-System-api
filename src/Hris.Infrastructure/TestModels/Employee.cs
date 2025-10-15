using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.TestModels;

public partial class Employee
{
    public Guid Id { get; set; }

    public string EmployeeNumber { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string Department { get; set; } = null!;

    public string Position { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime HiredAt { get; set; }

    public virtual ICollection<EmployeeFieldValue> EmployeeFieldValues { get; set; } = new List<EmployeeFieldValue>();

    public virtual ICollection<LeaveRequest> LeaveRequests { get; set; } = new List<LeaveRequest>();

    public virtual ICollection<PayslipComponent> PayslipComponents { get; set; } = new List<PayslipComponent>();

    public virtual ICollection<PerformanceReview> PerformanceReviews { get; set; } = new List<PerformanceReview>();

    public virtual ICollection<TrainingProgress> TrainingProgresses { get; set; } = new List<TrainingProgress>();
}
