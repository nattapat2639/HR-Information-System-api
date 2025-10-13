using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Hris.Application.Interfaces.Repositories;
using Hris.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hris.Infrastructure.Persistence.Repositories;

public class SqlEmployeeRepository : IEmployeeRepository
{
    private readonly HrisDbContext _context;

    public SqlEmployeeRepository(HrisDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Employee employee, CancellationToken cancellationToken = default)
    {
        await _context.Employees.AddAsync(employee, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task<IReadOnlyCollection<Employee>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var employees = await _context.Employees
            .AsNoTracking()
            .OrderBy(e => e.EmployeeNumber)
            .ToListAsync(cancellationToken);

        return employees;
    }

    public async Task<Employee?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _context.Employees
            .AsNoTracking()
            .FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
    }
}
