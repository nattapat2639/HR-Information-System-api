namespace Hris.Application.DTOs.Organization;

public record HeadcountRequestDto(
    string Department,
    int RequestedHeadcount,
    string RequestedBy,
    string Justification);
