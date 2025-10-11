using System.Linq;
using Hris.Application.Interfaces.Repositories;
using Hris.Domain.Entities;

namespace Hris.Infrastructure.Persistence.Repositories;

public class InMemoryEmployeeRepository : IEmployeeRepository
{
    private readonly List<Employee> _employees;

    public InMemoryEmployeeRepository()
    {
        _employees = BuildSeedData();
    }

    public Task AddAsync(Employee employee, CancellationToken cancellationToken = default)
    {
        _employees.Add(employee);
        return Task.CompletedTask;
    }

    public Task<IReadOnlyCollection<Employee>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        IReadOnlyCollection<Employee> result = _employees.AsReadOnly();
        return Task.FromResult(result);
    }

    public Task<Employee?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var employee = _employees.FirstOrDefault(e => e.Id == id);
        return Task.FromResult(employee);
    }

    private static List<Employee> BuildSeedData()
    {
        return new List<Employee>
        {
            new()
            {
                Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                EmployeeNumber = "HR-0001",
                FullName = "Chanon Phumiphak",
                Department = "People Operations",
                Position = "HR Business Partner",
                Status = "Active",
                HiredAt = DateTime.UtcNow.AddYears(-3)
            },
            new()
            {
                Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                EmployeeNumber = "IT-0005",
                FullName = "Supaporn Teerapat",
                Department = "Technology",
                Position = "Lead Software Engineer",
                Status = "Active",
                HiredAt = DateTime.UtcNow.AddYears(-5)
            },
            new()
            {
                Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                EmployeeNumber = "FN-0010",
                FullName = "Nattawat Charoen",
                Department = "Finance",
                Position = "Payroll Specialist",
                Status = "OnLeave",
                HiredAt = DateTime.UtcNow.AddYears(-2)
            }
        };
    }
}
