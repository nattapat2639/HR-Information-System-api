using Hris.Application.Interfaces.Repositories;
using Hris.Domain.Entities;

namespace Hris.Infrastructure.Persistence.Repositories;

public class InMemoryEmployeeFieldValueRepository : IEmployeeFieldValueRepository
{
    private readonly List<EmployeeFieldValue> _values;
    private readonly object _sync = new();

    public InMemoryEmployeeFieldValueRepository()
    {
        _values = BuildSeedData();
    }

    public Task<IReadOnlyCollection<EmployeeFieldValue>> GetByEmployeeAsync(Guid employeeId, CancellationToken cancellationToken = default)
    {
        lock (_sync)
        {
            var items = _values
                .Where(value => value.EmployeeId == employeeId)
                .Select(CloneValue)
                .ToList()
                .AsReadOnly();

            return Task.FromResult<IReadOnlyCollection<EmployeeFieldValue>>(items);
        }
    }

    public Task ReplaceAsync(Guid employeeId, IReadOnlyCollection<EmployeeFieldValue> values, CancellationToken cancellationToken = default)
    {
        lock (_sync)
        {
            _values.RemoveAll(value => value.EmployeeId == employeeId);

            foreach (var value in values)
            {
                _values.Add(CloneValue(value));
            }
        }

        return Task.CompletedTask;
    }

    private static List<EmployeeFieldValue> BuildSeedData()
    {
        var now = DateTime.UtcNow;
        return new List<EmployeeFieldValue>
        {
            new()
            {
                Id = CreateDeterministicGuid(882, 1),
                EmployeeId = CreateDeterministicGuid(100, 1),
                FieldDefinitionId = CreateDeterministicGuid(880, 1),
                Value = "Anan Techakul",
                UpdatedAtUtc = now.AddDays(-1),
                UpdatedBy = "People Operations"
            },
            new()
            {
                Id = CreateDeterministicGuid(882, 2),
                EmployeeId = CreateDeterministicGuid(100, 1),
                FieldDefinitionId = CreateDeterministicGuid(880, 2),
                Value = "1991-05-18",
                UpdatedAtUtc = now.AddDays(-1),
                UpdatedBy = "People Operations"
            },
            new()
            {
                Id = CreateDeterministicGuid(882, 3),
                EmployeeId = CreateDeterministicGuid(100, 1),
                FieldDefinitionId = CreateDeterministicGuid(880, 3),
                Value = "Technology",
                UpdatedAtUtc = now.AddDays(-1),
                UpdatedBy = "People Operations"
            },
            new()
            {
                Id = CreateDeterministicGuid(882, 4),
                EmployeeId = CreateDeterministicGuid(100, 1),
                FieldDefinitionId = CreateDeterministicGuid(880, 4),
                Value = "Senior",
                UpdatedAtUtc = now.AddDays(-1),
                UpdatedBy = "People Operations"
            },
            new()
            {
                Id = CreateDeterministicGuid(882, 5),
                EmployeeId = CreateDeterministicGuid(100, 1),
                FieldDefinitionId = CreateDeterministicGuid(880, 5),
                Value = "Full-time",
                UpdatedAtUtc = now.AddDays(-1),
                UpdatedBy = "People Operations"
            },
            new()
            {
                Id = CreateDeterministicGuid(882, 6),
                EmployeeId = CreateDeterministicGuid(100, 2),
                FieldDefinitionId = CreateDeterministicGuid(880, 1),
                Value = "Suchada Pradchaphet",
                UpdatedAtUtc = now.AddDays(-2),
                UpdatedBy = "People Operations"
            },
            new()
            {
                Id = CreateDeterministicGuid(882, 7),
                EmployeeId = CreateDeterministicGuid(100, 2),
                FieldDefinitionId = CreateDeterministicGuid(880, 2),
                Value = "1993-11-02",
                UpdatedAtUtc = now.AddDays(-2),
                UpdatedBy = "People Operations"
            },
            new()
            {
                Id = CreateDeterministicGuid(882, 8),
                EmployeeId = CreateDeterministicGuid(100, 2),
                FieldDefinitionId = CreateDeterministicGuid(880, 3),
                Value = "Operations",
                UpdatedAtUtc = now.AddDays(-2),
                UpdatedBy = "People Operations"
            },
            new()
            {
                Id = CreateDeterministicGuid(882, 9),
                EmployeeId = CreateDeterministicGuid(100, 2),
                FieldDefinitionId = CreateDeterministicGuid(880, 4),
                Value = "Lead",
                UpdatedAtUtc = now.AddDays(-2),
                UpdatedBy = "People Operations"
            },
            new()
            {
                Id = CreateDeterministicGuid(882, 10),
                EmployeeId = CreateDeterministicGuid(100, 2),
                FieldDefinitionId = CreateDeterministicGuid(880, 5),
                Value = "Full-time",
                UpdatedAtUtc = now.AddDays(-2),
                UpdatedBy = "People Operations"
            }
        };
    }

    private static EmployeeFieldValue CloneValue(EmployeeFieldValue value)
        => new()
        {
            Id = value.Id,
            EmployeeId = value.EmployeeId,
            FieldDefinitionId = value.FieldDefinitionId,
            Value = value.Value,
            UpdatedAtUtc = value.UpdatedAtUtc,
            UpdatedBy = value.UpdatedBy
        };

    private static Guid CreateDeterministicGuid(int scope, int index)
    {
        var a = (uint)scope;
        var b = (uint)index;
        var c = a ^ (b << 1);
        var d = a + b + 12345;
        return Guid.ParseExact($"{a:X8}{b:X8}{c:X8}{d:X8}", "N");
    }
}
