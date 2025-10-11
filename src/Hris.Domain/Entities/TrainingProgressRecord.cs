using System;

namespace Hris.Domain.Entities;

public class TrainingProgressRecord
{
    public Guid Id { get; set; }
    public Guid EmployeeId { get; set; }
    public string ProgramName { get; set; } = default!;
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string Status { get; set; } = default!;

    public Employee? Employee { get; set; }
}
