using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.TestModels;

public partial class TrainingProgress
{
    public Guid Id { get; set; }

    public Guid EmployeeId { get; set; }

    public string ProgramName { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string Status { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;
}
