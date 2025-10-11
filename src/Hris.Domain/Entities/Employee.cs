namespace Hris.Domain.Entities;

public class Employee
{
    public Guid Id { get; set; }
    public string EmployeeNumber { get; set; } = default!;
    public string FullName { get; set; } = default!;
    public string Department { get; set; } = default!;
    public string Position { get; set; } = default!;
    public string Status { get; set; } = "Active";
    public DateTime HiredAt { get; set; }
}
