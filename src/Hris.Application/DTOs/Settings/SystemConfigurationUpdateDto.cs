namespace Hris.Application.DTOs.Settings;

public record SystemConfigurationUpdateDto(
    string? PrimaryTimezone,
    string? WorkweekTemplate,
    string? HolidayCalendar,
    string? DataResidency);
