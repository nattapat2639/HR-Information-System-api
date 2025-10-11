namespace Hris.Application.DTOs;

public record EmployeeDto
{
    public Guid Id { get; init; }
    public string EmployeeNumber { get; init; } = default!;
    public string FullName { get; init; } = default!;
    public string Department { get; init; } = default!;
    public string Position { get; init; } = default!;
    public string Status { get; init; } = default!;
    public DateTime HiredAt { get; init; }
}
