using System;

namespace Hris.Domain.Entities;

public class TrainingSession
{
    public Guid Id { get; set; }
    public string Title { get; set; } = default!;
    public DateTime SessionDate { get; set; }
    public string Trainer { get; set; } = default!;
    public string Status { get; set; } = default!;
}
