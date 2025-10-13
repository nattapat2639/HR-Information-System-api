using System.Linq;
using Hris.Application.DTOs;
using Hris.Application.Interfaces.Repositories;
using Hris.Application.Interfaces.Services;
using Hris.Application.Mapping;
using Hris.Domain.Entities;

namespace Hris.Application.Services;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _repository;

    public EmployeeService(IEmployeeRepository repository)
    {
        _repository = repository;
    }

    public async Task<PagedResult<EmployeeDto>> GetEmployeesAsync(int page, int pageSize, CancellationToken cancellationToken = default)
    {
        var records = await _repository.GetAllAsync(cancellationToken);
        var total = records.Count;
        var skip = Math.Max(page - 1, 0) * pageSize;
        var items = records
            .Skip(skip)
            .Take(pageSize)
            .Select(employee => employee.ToDto())
            .ToList();

        return new PagedResult<EmployeeDto>(items, total, page, pageSize);
    }

    public async Task<EmployeeDto?> GetEmployeeAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var employee = await _repository.GetByIdAsync(id, cancellationToken);
        return employee?.ToDto();
    }

    public async Task<EmployeeDto> CreateEmployeeAsync(EmployeeCreateRequest request, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(request);

        var employeeNumber = NormalizeEmployeeNumber(request.EmployeeNumber);
        var existing = await _repository.GetByEmployeeNumberAsync(employeeNumber, cancellationToken);
        if (existing is not null)
        {
            throw new InvalidOperationException("EMPLOYEE_NUMBER_EXISTS");
        }

        var employee = new Employee
        {
            Id = Guid.NewGuid(),
            EmployeeNumber = employeeNumber,
            FullName = NormalizeRequired(request.FullName, 128, "EMPLOYEE_FULL_NAME_REQUIRED"),
            Department = NormalizeRequired(request.Department, 128, "EMPLOYEE_DEPARTMENT_REQUIRED"),
            Position = NormalizeRequired(request.Position, 128, "EMPLOYEE_POSITION_REQUIRED"),
            Status = NormalizeOptional(request.Status, 64, "Active"),
            HiredAt = NormalizeHiredAt(request.HiredAt)
        };

        await _repository.AddAsync(employee, cancellationToken);
        return employee.ToDto();
    }

    private static string NormalizeEmployeeNumber(string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new InvalidOperationException("EMPLOYEE_NUMBER_REQUIRED");
        }

        var trimmed = value.Trim();
        if (trimmed.Length > 32)
        {
            trimmed = trimmed[..32];
        }

        return trimmed.ToUpperInvariant();
    }

    private static string NormalizeRequired(string? value, int maxLength, string errorCode)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new InvalidOperationException(errorCode);
        }

        var trimmed = value.Trim();
        if (trimmed.Length > maxLength)
        {
            trimmed = trimmed[..maxLength];
        }

        return trimmed;
    }

    private static string NormalizeOptional(string? value, int maxLength, string fallback)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return fallback;
        }

        var trimmed = value.Trim();
        if (trimmed.Length > maxLength)
        {
            trimmed = trimmed[..maxLength];
        }

        return trimmed;
    }

    private static DateTime NormalizeHiredAt(DateTime? hiredAt)
    {
        if (hiredAt is null)
        {
            return DateTime.UtcNow.Date;
        }

        var date = hiredAt.Value.Date;
        return DateTime.SpecifyKind(date, DateTimeKind.Utc);
    }
}
