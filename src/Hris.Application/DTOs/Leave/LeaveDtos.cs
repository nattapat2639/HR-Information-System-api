using System;
using System.Collections.Generic;

namespace Hris.Application.DTOs.Leave;

public record LeaveRequestSummaryDto(
    Guid Id,
    Guid EmployeeId,
    string EmployeeName,
    string Reference,
    string LeaveType,
    bool IsHalfDay,
    DateTime StartDate,
    DateTime EndDate,
    string Status,
    DateTime RequestedOn,
    string? Reason,
    string? ContactDuringLeave,
    string? SupportingDocumentUrl,
    Guid? ApproverId,
    string? ApproverName,
    DateTime? DecisionOn,
    string? ManagerComment);

public record LeaveRequestDetailDto(
    Guid Id,
    Guid EmployeeId,
    string EmployeeName,
    string Reference,
    string LeaveType,
    bool IsHalfDay,
    DateTime StartDate,
    DateTime EndDate,
    string Status,
    DateTime RequestedOn,
    string? Reason,
    string? ContactDuringLeave,
    string? SupportingDocumentUrl,
    Guid? ApproverId,
    string? ApproverName,
    DateTime? DecisionOn,
    string? ManagerComment,
    IReadOnlyCollection<LeaveApprovalTimelineEntry> Timeline);

public record LeaveApprovalTimelineEntry(
    DateTime OccurredOn,
    string Actor,
    string Action,
    string? Remarks);

public record LeaveBalanceDto(
    Guid EmployeeId,
    int Year,
    string LeaveType,
    decimal OpeningBalance,
    decimal Accrued,
    decimal Taken,
    decimal Pending,
    decimal Remaining);

public record LeaveTypeDto(
    string Code,
    string Name,
    string Description,
    decimal DefaultAllowance,
    bool RequiresApproval,
    bool SupportsHalfDay);

public record CreateLeaveRequestDto(
    string LeaveType,
    DateTime StartDate,
    DateTime EndDate,
    bool IsHalfDay,
    string Reason,
    string? ContactDuringLeave,
    string? SupportingDocumentUrl);

public record UpdateLeaveRequestDatesDto(
    DateTime StartDate,
    DateTime EndDate,
    bool IsHalfDay);

public record LeaveDecisionDto(
    string Comment);

public record LeaveRequestQueryDto(
    string? LeaveType,
    string? Status,
    DateTime? StartDate,
    DateTime? EndDate,
    string? EmployeeKeyword);
