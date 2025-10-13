using System.Collections.Generic;

namespace Hris.Application.DTOs.Settings;

public record SecuritySettingsUpdateDto(IReadOnlyList<SecurityControlUpdate> Controls);

public record SecurityControlUpdate(string Control, string Status, string Owner, string Severity);
