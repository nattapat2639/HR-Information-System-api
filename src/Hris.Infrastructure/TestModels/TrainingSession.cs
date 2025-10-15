using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.TestModels;

public partial class TrainingSession
{
    public Guid Id { get; set; }

    public string Title { get; set; } = null!;

    public DateTime SessionDate { get; set; }

    public string Trainer { get; set; } = null!;

    public string Status { get; set; } = null!;
}
