using System.Collections.Generic;

namespace Hris.Application.DTOs.PageData;

public record PageDataDto(
    string Module,
    string Page,
    int PageNumber,
    int PageSize,
    int TotalCount,
    IReadOnlyCollection<PageRowDto> Rows,
    string? NoteKey = null);

public record PageRowDto(
    Dictionary<string, string> Columns,
    IReadOnlyCollection<PageRowActionDto>? Actions = null);

public record PageRowActionDto(
    string LabelKey,
    string Icon,
    string ActionKey);
