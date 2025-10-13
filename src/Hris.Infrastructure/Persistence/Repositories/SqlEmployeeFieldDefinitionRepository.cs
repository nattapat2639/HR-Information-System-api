using Hris.Application.Interfaces.Repositories;
using Hris.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hris.Infrastructure.Persistence.Repositories;

public class SqlEmployeeFieldDefinitionRepository : IEmployeeFieldDefinitionRepository
{
    private readonly HrisDbContext _context;

    public SqlEmployeeFieldDefinitionRepository(HrisDbContext context)
    {
        _context = context;
    }

    public async Task<IReadOnlyCollection<EmployeeFieldDefinition>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var definitions = await _context.EmployeeFieldDefinitions
            .AsNoTracking()
            .Include(definition => definition.Options)
            .OrderBy(definition => definition.SortOrder)
            .ThenBy(definition => definition.DisplayName)
            .ToListAsync(cancellationToken);

        foreach (var definition in definitions)
        {
            definition.Options = definition.Options
                .OrderBy(option => option.SortOrder)
                .ThenBy(option => option.Label)
                .ToList();
        }

        return definitions;
    }

    public async Task<EmployeeFieldDefinition?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var definition = await _context.EmployeeFieldDefinitions
            .AsNoTracking()
            .Include(def => def.Options)
            .FirstOrDefaultAsync(def => def.Id == id, cancellationToken);

        if (definition is null)
        {
            return null;
        }

        definition.Options = definition.Options
            .OrderBy(option => option.SortOrder)
            .ThenBy(option => option.Label)
            .ToList();

        return definition;
    }

    public async Task AddAsync(EmployeeFieldDefinition definition, CancellationToken cancellationToken = default)
    {
        if (definition.Options is { Count: > 0 })
        {
            foreach (var option in definition.Options)
            {
                option.FieldDefinitionId = definition.Id;
                if (option.Id == Guid.Empty)
                {
                    option.Id = Guid.NewGuid();
                }
            }
        }

        await _context.EmployeeFieldDefinitions.AddAsync(definition, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateAsync(EmployeeFieldDefinition definition, CancellationToken cancellationToken = default)
    {
        var existing = await _context.EmployeeFieldDefinitions
            .Include(def => def.Options)
            .FirstOrDefaultAsync(def => def.Id == definition.Id, cancellationToken);

        if (existing is null)
        {
            return;
        }

        existing.FieldKey = definition.FieldKey;
        existing.DisplayName = definition.DisplayName;
        existing.DataType = definition.DataType;
        existing.IsRequired = definition.IsRequired;
        existing.Category = definition.Category;
        existing.SortOrder = definition.SortOrder;
        existing.Description = definition.Description;
        existing.IsActive = definition.IsActive;

        _context.EmployeeFieldOptions.RemoveRange(existing.Options);
        existing.Options.Clear();

        if (definition.Options is { Count: > 0 })
        {
            foreach (var option in definition.Options
                         .OrderBy(option => option.SortOrder)
                         .ThenBy(option => option.Label))
            {
                existing.Options.Add(new EmployeeFieldOption
                {
                    Id = option.Id == Guid.Empty ? Guid.NewGuid() : option.Id,
                    FieldDefinitionId = existing.Id,
                    Label = option.Label,
                    Value = option.Value,
                    SortOrder = option.SortOrder
                });
            }
        }

        await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var definition = await _context.EmployeeFieldDefinitions
            .FirstOrDefaultAsync(def => def.Id == id, cancellationToken);

        if (definition is null)
        {
            return false;
        }

        _context.EmployeeFieldDefinitions.Remove(definition);
        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }

    public async Task<bool> FieldKeyExistsAsync(string fieldKey, Guid? excludeId = null, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(fieldKey))
        {
            return false;
        }

        fieldKey = fieldKey.Trim();

        return await _context.EmployeeFieldDefinitions.AnyAsync(
            definition =>
                definition.FieldKey == fieldKey &&
                (!excludeId.HasValue || definition.Id != excludeId.Value),
            cancellationToken);
    }
}
