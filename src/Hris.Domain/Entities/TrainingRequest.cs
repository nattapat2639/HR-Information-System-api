using System;

namespace Hris.Domain.Entities;

public class TrainingRequest
{
    public Guid Id { get; set; }
    public string RequestedBy { get; set; } = default!;
    public string ProgramName { get; set; } = default!;
    public DateTime SubmittedOn { get; set; }
    public string Status { get; set; } = default!;
}
