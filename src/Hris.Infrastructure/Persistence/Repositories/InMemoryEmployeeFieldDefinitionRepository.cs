using Hris.Application.Interfaces.Repositories;
using Hris.Domain.Entities;

namespace Hris.Infrastructure.Persistence.Repositories;

public class InMemoryEmployeeFieldDefinitionRepository : IEmployeeFieldDefinitionRepository
{
    private readonly List<EmployeeFieldDefinition> _definitions;

    public InMemoryEmployeeFieldDefinitionRepository()
    {
        _definitions = BuildSeedData();
    }

    public Task<IReadOnlyCollection<EmployeeFieldDefinition>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var ordered = _definitions
            .OrderBy(definition => definition.SortOrder)
            .ThenBy(definition => definition.DisplayName, StringComparer.OrdinalIgnoreCase)
            .Select(CloneDefinition)
            .ToList()
            .AsReadOnly();

        return Task.FromResult<IReadOnlyCollection<EmployeeFieldDefinition>>(ordered);
    }

    public Task<EmployeeFieldDefinition?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var definition = _definitions.FirstOrDefault(def => def.Id == id);
        return Task.FromResult(definition is null ? null : CloneDefinition(definition));
    }

    public Task AddAsync(EmployeeFieldDefinition definition, CancellationToken cancellationToken = default)
    {
        _definitions.Add(CloneDefinition(definition));
        return Task.CompletedTask;
    }

    public Task UpdateAsync(EmployeeFieldDefinition definition, CancellationToken cancellationToken = default)
    {
        var index = _definitions.FindIndex(def => def.Id == definition.Id);
        if (index >= 0)
        {
            _definitions[index] = CloneDefinition(definition);
        }

        return Task.CompletedTask;
    }

    public Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var removed = _definitions.RemoveAll(def => def.Id == id) > 0;
        return Task.FromResult(removed);
    }

    public Task<bool> FieldKeyExistsAsync(string fieldKey, Guid? excludeId = null, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(fieldKey))
        {
            return Task.FromResult(false);
        }

        var exists = _definitions.Any(def =>
            string.Equals(def.FieldKey, fieldKey, StringComparison.OrdinalIgnoreCase) &&
            (!excludeId.HasValue || def.Id != excludeId.Value));

        return Task.FromResult(exists);
    }

    private static EmployeeFieldDefinition CloneDefinition(EmployeeFieldDefinition definition)
        => new()
        {
            Id = definition.Id,
            FieldKey = definition.FieldKey,
            DisplayName = definition.DisplayName,
            DataType = definition.DataType,
            IsRequired = definition.IsRequired,
            Category = definition.Category,
            SortOrder = definition.SortOrder,
            Description = definition.Description,
            IsActive = definition.IsActive,
            Options = definition.Options
                .OrderBy(option => option.SortOrder)
                .Select(option => new EmployeeFieldOption
                {
                    Id = option.Id,
                    FieldDefinitionId = option.FieldDefinitionId,
                    Label = option.Label,
                    Value = option.Value,
                    SortOrder = option.SortOrder
                })
                .ToList()
        };

    private static List<EmployeeFieldDefinition> BuildSeedData()
    {
        var definitions = new List<EmployeeFieldDefinition>
        {
            new()
            {
                Id = CreateDeterministicGuid(880, 1),
                FieldKey = "personal.full_name",
                DisplayName = "Legal full name",
                DataType = "text",
                IsRequired = true,
                Category = "Personal",
                SortOrder = 1,
                Description = "Official full name used on contracts and payslips.",
                IsActive = true
            },
            new()
            {
                Id = CreateDeterministicGuid(880, 2),
                FieldKey = "personal.birth_date",
                DisplayName = "Date of birth",
                DataType = "date",
                IsRequired = false,
                Category = "Personal",
                SortOrder = 2,
                Description = "Employee birth date for eligibility and benefits checks.",
                IsActive = true
            },
            new()
            {
                Id = CreateDeterministicGuid(880, 3),
                FieldKey = "job.department",
                DisplayName = "Department",
                DataType = "select",
                IsRequired = true,
                Category = "Employment",
                SortOrder = 10,
                Description = "Owning department within the organisation structure.",
                IsActive = true
            },
            new()
            {
                Id = CreateDeterministicGuid(880, 4),
                FieldKey = "job.job_level",
                DisplayName = "Job level",
                DataType = "select",
                IsRequired = false,
                Category = "Employment",
                SortOrder = 11,
                Description = "Career level aligned to the company job framework.",
                IsActive = true
            },
            new()
            {
                Id = CreateDeterministicGuid(880, 5),
                FieldKey = "job.employment_type",
                DisplayName = "Employment type",
                DataType = "select",
                IsRequired = true,
                Category = "Employment",
                SortOrder = 12,
                Description = "Indicates if the employee is full-time, contract, or intern.",
                IsActive = true
            }
        };

        AttachOptions(definitions[2], new[]
        {
            ("People Operations", 1),
            ("Technology", 2),
            ("Finance", 3),
            ("Marketing", 4),
            ("Customer Success", 5),
            ("Operations", 6),
            ("Sales", 7),
            ("Data & Analytics", 8)
        }, startIndex: 1);

        AttachOptions(definitions[3], new[]
        {
            ("Junior", 1),
            ("Mid", 2),
            ("Senior", 3),
            ("Lead", 4),
            ("Director", 5)
        }, startIndex: 9);

        AttachOptions(definitions[4], new[]
        {
            ("Full-time", 1),
            ("Contract", 2),
            ("Intern", 3)
        }, startIndex: 14);

        return definitions;
    }

    private static void AttachOptions(
        EmployeeFieldDefinition definition,
        IEnumerable<(string Label, int Sort)> options,
        int startIndex)
    {
        definition.Options = options
            .Select((tuple, index) => new EmployeeFieldOption
            {
                Id = CreateDeterministicGuid(881, startIndex + index),
                FieldDefinitionId = definition.Id,
                Label = tuple.Label,
                Value = tuple.Label,
                SortOrder = tuple.Sort
            })
            .ToList();
    }

    private static Guid CreateDeterministicGuid(int scope, int index)
    {
        var a = (uint)scope;
        var b = (uint)index;
        var c = a ^ (b << 1);
        var d = a + b + 12345;
        return Guid.ParseExact($"{a:X8}{b:X8}{c:X8}{d:X8}", "N");
    }
}
