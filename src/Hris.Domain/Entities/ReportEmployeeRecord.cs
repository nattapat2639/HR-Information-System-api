using System;

namespace Hris.Domain.Entities;

public class ReportEmployeeRecord
{
    public Guid Id { get; set; }
    public string EmployeeId { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string Department { get; set; } = default!;
    public string Status { get; set; } = default!;
}
