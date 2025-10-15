using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.TestModels;

public partial class TrainingRequest
{
    public Guid Id { get; set; }

    public string RequestedBy { get; set; } = null!;

    public string ProgramName { get; set; } = null!;

    public DateTime SubmittedOn { get; set; }

    public string Status { get; set; } = null!;
}
