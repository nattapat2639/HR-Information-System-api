using System.Text.RegularExpressions;
using Hris.Application.DTOs.EmployeeRecords;
using Hris.Application.Interfaces.Repositories;
using Hris.Application.Interfaces.Services;
using Hris.Application.Mapping;
using Hris.Domain.Entities;

namespace Hris.Application.Services;

public class EmployeeFieldDefinitionService : IEmployeeFieldDefinitionService
{
    private static readonly Regex NonAllowedKeyCharacters = new("[^a-z0-9._-]+", RegexOptions.Compiled);

    private readonly IEmployeeFieldDefinitionRepository _repository;

    public EmployeeFieldDefinitionService(IEmployeeFieldDefinitionRepository repository)
    {
        _repository = repository;
    }

    public async Task<IReadOnlyCollection<EmployeeFieldDefinitionDto>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var definitions = await _repository.GetAllAsync(cancellationToken);
        return definitions
            .Select(definition => definition.ToDto())
            .ToArray();
    }

    public async Task<EmployeeFieldDefinitionDto?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var definition = await _repository.GetByIdAsync(id, cancellationToken);
        return definition?.ToDto();
    }

    public async Task<EmployeeFieldDefinitionDto> CreateAsync(EmployeeFieldDefinitionRequest request, CancellationToken cancellationToken = default)
    {
        var normalizedKey = NormalizeKey(request.FieldKey);

        if (await _repository.FieldKeyExistsAsync(normalizedKey, null, cancellationToken))
        {
            throw new InvalidOperationException("FIELD_KEY_EXISTS");
        }

        var definitionId = Guid.NewGuid();
        var definition = BuildDefinition(definitionId, normalizedKey, request);
        await _repository.AddAsync(definition, cancellationToken);

        var saved = await _repository.GetByIdAsync(definitionId, cancellationToken);
        return (saved ?? definition).ToDto();
    }

    public async Task<EmployeeFieldDefinitionDto?> UpdateAsync(Guid id, EmployeeFieldDefinitionRequest request, CancellationToken cancellationToken = default)
    {
        var existing = await _repository.GetByIdAsync(id, cancellationToken);
        if (existing is null)
        {
            return null;
        }

        var normalizedKey = NormalizeKey(request.FieldKey);

        if (!string.Equals(existing.FieldKey, normalizedKey, StringComparison.OrdinalIgnoreCase) &&
            await _repository.FieldKeyExistsAsync(normalizedKey, id, cancellationToken))
        {
            throw new InvalidOperationException("FIELD_KEY_EXISTS");
        }

        var updated = BuildDefinition(id, normalizedKey, request);
        await _repository.UpdateAsync(updated, cancellationToken);

        var saved = await _repository.GetByIdAsync(id, cancellationToken);
        return saved?.ToDto();
    }

    public Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
        => _repository.DeleteAsync(id, cancellationToken);

    private static EmployeeFieldDefinition BuildDefinition(Guid id, string normalizedKey, EmployeeFieldDefinitionRequest request)
    {
        var dataType = NormalizeDataType(request.DataType);
        var definition = new EmployeeFieldDefinition
        {
            Id = id,
            FieldKey = normalizedKey,
            DisplayName = request.DisplayName.Trim(),
            DataType = dataType,
            IsRequired = request.IsRequired,
            Category = string.IsNullOrWhiteSpace(request.Category) ? "General" : request.Category.Trim(),
            SortOrder = Math.Max(0, request.SortOrder),
            Description = string.IsNullOrWhiteSpace(request.Description) ? null : request.Description.Trim(),
            IsActive = request.IsActive,
            Options = BuildOptions(id, dataType, request.Options)
        };

        return definition;
    }

    private static List<EmployeeFieldOption> BuildOptions(
        Guid definitionId,
        string dataType,
        IReadOnlyCollection<EmployeeFieldOptionRequest> options)
    {
        if (!IsOptionBasedType(dataType) || options is null || options.Count == 0)
        {
            return new List<EmployeeFieldOption>();
        }

        var index = 0;
        return options
            .Where(option => !string.IsNullOrWhiteSpace(option.Label))
            .Select(option =>
            {
                var label = option.Label.Trim();
                var value = string.IsNullOrWhiteSpace(option.Value) ? label : option.Value.Trim();
                var sortOrder = option.SortOrder > 0 ? option.SortOrder : ++index;

                return new EmployeeFieldOption
                {
                    Id = Guid.NewGuid(),
                    FieldDefinitionId = definitionId,
                    Label = label,
                    Value = value,
                    SortOrder = sortOrder
                };
            })
            .OrderBy(option => option.SortOrder)
            .ThenBy(option => option.Label, StringComparer.OrdinalIgnoreCase)
            .ToList();
    }

    private static bool IsOptionBasedType(string dataType)
        => string.Equals(dataType, "select", StringComparison.OrdinalIgnoreCase) ||
           string.Equals(dataType, "multi_select", StringComparison.OrdinalIgnoreCase);

    private static string NormalizeKey(string? key)
    {
        if (string.IsNullOrWhiteSpace(key))
        {
            throw new InvalidOperationException("FIELD_KEY_REQUIRED");
        }

        var lowered = key.Trim().ToLowerInvariant();
        lowered = lowered.Replace(' ', '_');
        lowered = NonAllowedKeyCharacters.Replace(lowered, "-");
        lowered = lowered.Trim('-', '.');

        if (string.IsNullOrWhiteSpace(lowered))
        {
            throw new InvalidOperationException("FIELD_KEY_REQUIRED");
        }

        return lowered;
    }

    private static string NormalizeDataType(string? dataType)
    {
        var normalized = string.IsNullOrWhiteSpace(dataType) ? "text" : dataType.Trim().ToLowerInvariant();

        return normalized switch
        {
            "text" or "number" or "date" or "email" or "select" or "multi_select" => normalized,
            _ => "text"
        };
    }
}
