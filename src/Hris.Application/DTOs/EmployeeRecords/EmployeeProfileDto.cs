using System;
using System.Collections.Generic;

namespace Hris.Application.DTOs.EmployeeRecords;

public record EmployeeProfileDto(
    string EmployeeNumber,
    string FullName,
    IReadOnlyCollection<EmployeeProfileFieldDto> Personal,
    IReadOnlyCollection<EmployeeProfileFieldDto> Job,
    IReadOnlyCollection<EmployeeProfileFieldDto> Contact,
    IReadOnlyCollection<EmployeeTimelineEventDto> Timeline,
    IReadOnlyCollection<EmployeeDocumentDto> Documents);

public record EmployeeProfileFieldDto(string Label, string Value);

public record EmployeeTimelineEventDto(
    DateTime Date,
    string Category,
    string Tone,
    string Title,
    string Description,
    string Icon);

public record EmployeeDocumentDto(
    string Name,
    DateTime UpdatedAt);

public record EmployeeSearchInsightsDto(
    IReadOnlyCollection<DistributionItemDto> Status,
    IReadOnlyCollection<DistributionItemDto> TopDepartments);

public record DistributionItemDto(string Label, int Count);
