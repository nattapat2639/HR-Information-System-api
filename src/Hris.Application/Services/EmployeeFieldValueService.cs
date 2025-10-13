using System.Linq;
using Hris.Application.DTOs.EmployeeRecords;
using Hris.Application.Interfaces.Repositories;
using Hris.Application.Interfaces.Services;
using Hris.Domain.Entities;

namespace Hris.Application.Services;

public class EmployeeFieldValueService : IEmployeeFieldValueService
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IEmployeeFieldDefinitionRepository _definitionRepository;
    private readonly IEmployeeFieldValueRepository _valueRepository;

    public EmployeeFieldValueService(
        IEmployeeRepository employeeRepository,
        IEmployeeFieldDefinitionRepository definitionRepository,
        IEmployeeFieldValueRepository valueRepository)
    {
        _employeeRepository = employeeRepository;
        _definitionRepository = definitionRepository;
        _valueRepository = valueRepository;
    }

    public async Task<EmployeeFieldValueSetDto?> GetForEmployeeAsync(string employeeNumber, CancellationToken cancellationToken = default)
    {
        var employee = await _employeeRepository.GetByEmployeeNumberAsync(employeeNumber, cancellationToken);
        if (employee is null)
        {
            return null;
        }

        var definitions = await _definitionRepository.GetAllAsync(cancellationToken);
        var values = await _valueRepository.GetByEmployeeAsync(employee.Id, cancellationToken);

        var valuesByDefinition = values.ToDictionary(value => value.FieldDefinitionId);

        var fields = definitions
            .OrderBy(definition => definition.SortOrder)
            .ThenBy(definition => definition.DisplayName, StringComparer.OrdinalIgnoreCase)
            .Select(definition =>
            {
                valuesByDefinition.TryGetValue(definition.Id, out var currentValue);

                var options = definition.Options
                    .OrderBy(option => option.SortOrder)
                    .ThenBy(option => option.Label, StringComparer.OrdinalIgnoreCase)
                    .Select(option => new EmployeeFieldOptionDto(option.Id, option.Label, option.Value, option.SortOrder))
                    .ToArray();

                return new EmployeeFieldWithValueDto(
                    definition.Id,
                    definition.FieldKey,
                    definition.DisplayName,
                    definition.DataType,
                    definition.IsRequired,
                    definition.Category,
                    definition.SortOrder,
                    definition.IsActive,
                    definition.Description,
                    options,
                    currentValue?.Value,
                    currentValue?.UpdatedAtUtc,
                    currentValue?.UpdatedBy);
            })
            .ToArray();

        return new EmployeeFieldValueSetDto(employee.Id, employee.EmployeeNumber, fields);
    }

    public async Task<EmployeeFieldValueSetDto?> UpdateForEmployeeAsync(
        string employeeNumber,
        EmployeeFieldValueUpdateCommand command,
        CancellationToken cancellationToken = default)
    {
        var employee = await _employeeRepository.GetByEmployeeNumberAsync(employeeNumber, cancellationToken);
        if (employee is null)
        {
            return null;
        }

        var definitions = await _definitionRepository.GetAllAsync(cancellationToken);
        var activeDefinitions = definitions
            .Where(definition => definition.IsActive)
            .ToDictionary(definition => definition.FieldKey, StringComparer.OrdinalIgnoreCase);

        var currentValues = (await _valueRepository.GetByEmployeeAsync(employee.Id, cancellationToken))
            .ToDictionary(value => value.FieldDefinitionId);

        var updatedBy = string.IsNullOrWhiteSpace(command.UpdatedBy) ? "System" : command.UpdatedBy.Trim();
        var now = DateTime.UtcNow;

        if (command.Fields is null)
        {
            command = command with { Fields = Array.Empty<EmployeeFieldValueUpdateItem>() };
        }

        foreach (var item in command.Fields)
        {
            if (item is null || string.IsNullOrWhiteSpace(item.FieldKey))
            {
                continue;
            }

            if (!activeDefinitions.TryGetValue(item.FieldKey, out var definition))
            {
                continue;
            }

            var normalizedValue = NormalizeValue(definition, item);

            if (normalizedValue is null)
            {
                if (definition.IsRequired)
                {
                    throw new InvalidOperationException($"FIELD_VALUE_REQUIRED::{definition.FieldKey}");
                }

                currentValues.Remove(definition.Id);
                continue;
            }

            if (currentValues.TryGetValue(definition.Id, out var existing))
            {
                existing.Value = normalizedValue;
                existing.UpdatedAtUtc = now;
                existing.UpdatedBy = updatedBy;
            }
            else
            {
                currentValues[definition.Id] = new EmployeeFieldValue
                {
                    Id = Guid.NewGuid(),
                    EmployeeId = employee.Id,
                    FieldDefinitionId = definition.Id,
                    Value = normalizedValue,
                    UpdatedAtUtc = now,
                    UpdatedBy = updatedBy
                };
            }
        }

        await _valueRepository.ReplaceAsync(employee.Id, currentValues.Values.ToArray(), cancellationToken);

        return await GetForEmployeeAsync(employeeNumber, cancellationToken);
    }

    private static string? NormalizeValue(EmployeeFieldDefinition definition, EmployeeFieldValueUpdateItem item)
    {
        var dataType = definition.DataType.ToLowerInvariant();

        return dataType switch
        {
            "select" => NormalizeSelectValue(definition, item),
            "multi_select" => NormalizeMultiSelectValue(definition, item),
            _ => NormalizePrimitiveValue(item.Value)
        };
    }

    private static string? NormalizeSelectValue(EmployeeFieldDefinition definition, EmployeeFieldValueUpdateItem item)
    {
        var candidate = item.Value;
        if (string.IsNullOrWhiteSpace(candidate) && item.Values is { Count: > 0 })
        {
            candidate = item.Values.FirstOrDefault();
        }

        candidate = NormalizePrimitiveValue(candidate);

        if (candidate is null)
        {
            return null;
        }

        var match = definition.Options.FirstOrDefault(option =>
            option.Value.Equals(candidate, StringComparison.OrdinalIgnoreCase) ||
            option.Label.Equals(candidate, StringComparison.OrdinalIgnoreCase));

        return match?.Value;
    }

    private static string? NormalizeMultiSelectValue(EmployeeFieldDefinition definition, EmployeeFieldValueUpdateItem item)
    {
        IEnumerable<string> candidates = Array.Empty<string>();

        if (item.Values is { Count: > 0 })
        {
            candidates = item.Values;
        }
        else if (!string.IsNullOrWhiteSpace(item.Value))
        {
            candidates = item.Value.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        }

        var allowed = new HashSet<string>(
            definition.Options.Select(option => option.Value),
            StringComparer.OrdinalIgnoreCase);

        var normalized = candidates
            .Select(candidate => candidate.Trim())
            .Where(candidate => candidate.Length > 0)
            .Where(candidate => allowed.Contains(candidate))
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .ToArray();

        if (normalized.Length == 0)
        {
            return null;
        }

        return string.Join(";", normalized);
    }

    private static string? NormalizePrimitiveValue(string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return null;
        }

        var trimmed = value.Trim();
        return trimmed.Length == 0 ? null : trimmed;
    }
}
