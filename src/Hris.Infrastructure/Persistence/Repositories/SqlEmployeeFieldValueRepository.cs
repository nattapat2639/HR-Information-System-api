using Hris.Application.Interfaces.Repositories;
using Hris.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hris.Infrastructure.Persistence.Repositories;

public class SqlEmployeeFieldValueRepository : IEmployeeFieldValueRepository
{
    private readonly HrisDbContext _context;

    public SqlEmployeeFieldValueRepository(HrisDbContext context)
    {
        _context = context;
    }

    public async Task<IReadOnlyCollection<EmployeeFieldValue>> GetByEmployeeAsync(Guid employeeId, CancellationToken cancellationToken = default)
    {
        var values = await _context.EmployeeFieldValues
            .AsNoTracking()
            .Where(value => value.EmployeeId == employeeId)
            .OrderBy(value => value.FieldDefinitionId)
            .ToListAsync(cancellationToken);

        return values;
    }

    public async Task ReplaceAsync(Guid employeeId, IReadOnlyCollection<EmployeeFieldValue> values, CancellationToken cancellationToken = default)
    {
        var tracked = await _context.EmployeeFieldValues
            .Where(value => value.EmployeeId == employeeId)
            .ToListAsync(cancellationToken);

        var incomingByField = values.ToDictionary(value => value.FieldDefinitionId);

        foreach (var existing in tracked)
        {
            if (!incomingByField.ContainsKey(existing.FieldDefinitionId))
            {
                _context.EmployeeFieldValues.Remove(existing);
            }
        }

        foreach (var incoming in values)
        {
            var match = tracked.FirstOrDefault(value => value.FieldDefinitionId == incoming.FieldDefinitionId);
            if (match is null)
            {
                var entity = new EmployeeFieldValue
                {
                    Id = incoming.Id == Guid.Empty ? Guid.NewGuid() : incoming.Id,
                    EmployeeId = employeeId,
                    FieldDefinitionId = incoming.FieldDefinitionId,
                    Value = incoming.Value,
                    UpdatedAtUtc = incoming.UpdatedAtUtc,
                    UpdatedBy = incoming.UpdatedBy
                };

                await _context.EmployeeFieldValues.AddAsync(entity, cancellationToken);
            }
            else
            {
                match.Value = incoming.Value;
                match.UpdatedAtUtc = incoming.UpdatedAtUtc;
                match.UpdatedBy = incoming.UpdatedBy;
            }
        }

        await _context.SaveChangesAsync(cancellationToken);
    }
}
