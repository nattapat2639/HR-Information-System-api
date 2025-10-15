using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.TestModels;

public partial class ReportEmployee
{
    public Guid Id { get; set; }

    public string EmployeeId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Department { get; set; } = null!;

    public string Status { get; set; } = null!;
}
