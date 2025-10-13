using System;
using System.Collections.Generic;

namespace Hris.Application.DTOs.Organization;

public record OrganizationOverviewDto(
    DateTime? LastSyncedAtUtc,
    int TotalHeadcount,
    int TotalOpenRoles,
    int DepartmentCount,
    int TotalApprovedHeadcount,
    IReadOnlyCollection<AttritionBreakdownDto> AttritionBreakdown,
    IReadOnlyCollection<DepartmentPlanSummaryDto> DepartmentPlans,
    IReadOnlyCollection<FocusAreaSummaryDto> FocusAreas);

public record AttritionBreakdownDto(
    string RiskLevel,
    int Count);

public record DepartmentPlanSummaryDto(
    string Department,
    string Lead,
    string Focus,
    int CurrentHeadcount,
    int ApprovedHeadcount,
    int OpenRoles,
    string AttritionRisk);

public record FocusAreaSummaryDto(
    string FocusArea,
    int DepartmentCount);
