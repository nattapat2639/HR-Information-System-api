using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Hris.Application.DTOs;
using Hris.Application.DTOs.Leave;
using Hris.Application.Interfaces.Repositories;
using Hris.Application.Interfaces.Services;
using Hris.Domain.Entities;

namespace Hris.Application.Services;

public sealed class LeaveManagementService : ILeaveManagementService
{
    private readonly ILeaveRequestRepository _repository;

    public LeaveManagementService(ILeaveRequestRepository repository)
    {
        _repository = repository;
    }

    public Task<PagedResult<LeaveRequestSummaryDto>> GetMyRequestsAsync(
        Guid employeeId,
        LeaveRequestQueryDto query,
        int pageNumber,
        int pageSize,
        CancellationToken cancellationToken = default)
        => _repository.GetMyRequestsAsync(employeeId, query, pageNumber, pageSize, cancellationToken);

    public Task<PagedResult<LeaveRequestSummaryDto>> GetTeamRequestsAsync(
        Guid managerId,
        LeaveRequestQueryDto query,
        int pageNumber,
        int pageSize,
        CancellationToken cancellationToken = default)
        => _repository.GetTeamRequestsAsync(managerId, query, pageNumber, pageSize, cancellationToken);

    public Task<PagedResult<LeaveRequestSummaryDto>> GetHistoryAsync(
        Guid employeeId,
        LeaveRequestQueryDto query,
        int pageNumber,
        int pageSize,
        CancellationToken cancellationToken = default)
        => _repository.GetHistoryAsync(employeeId, query, pageNumber, pageSize, cancellationToken);

    public async Task<LeaveRequestDetailDto?> GetByIdAsync(
        Guid requestId,
        CancellationToken cancellationToken = default)
    {
        var entity = await _repository.FindByIdAsync(requestId, cancellationToken);
        return entity is null ? null : ToDetail(entity);
    }

    public async Task<LeaveRequestDetailDto> SubmitAsync(
        Guid employeeId,
        string employeeName,
        CreateLeaveRequestDto payload,
        CancellationToken cancellationToken = default)
    {
        ValidateCreatePayload(payload);

        var request = new LeaveRequest
        {
            Id = Guid.NewGuid(),
            EmployeeId = employeeId,
            Reference = GenerateReference(DateTime.UtcNow),
            LeaveType = payload.LeaveType.Trim(),
            Reason = payload.Reason.Trim(),
            IsHalfDay = payload.IsHalfDay,
            ContactDuringLeave = NormalizeOptional(payload.ContactDuringLeave),
            SupportingDocumentUrl = NormalizeOptional(payload.SupportingDocumentUrl),
            StartDate = payload.StartDate.Date,
            EndDate = payload.EndDate.Date,
            Status = "Pending",
            RequestedOn = DateTime.UtcNow,
            ApproverId = null,
            ApproverName = null,
            DecisionOn = null,
            ManagerComment = null
        };

        await _repository.AddAsync(request, cancellationToken);
        var persisted = await _repository.FindByIdAsync(request.Id, cancellationToken);
        if (persisted is null)
        {
            throw new InvalidOperationException("LEAVE_NOT_FOUND");
        }

        // Ensure navigation loaded for timeline
        persisted.Employee ??= new Employee
        {
            Id = employeeId,
            FullName = employeeName
        };

        return ToDetail(persisted);
    }

    public async Task<LeaveRequestDetailDto> WithdrawAsync(
        Guid requestId,
        Guid employeeId,
        string comment,
        CancellationToken cancellationToken = default)
    {
        var entity = await _repository.FindByIdAsync(requestId, cancellationToken);
        if (entity is null)
        {
            throw new InvalidOperationException("LEAVE_NOT_FOUND");
        }

        if (entity.EmployeeId != employeeId)
        {
            throw new InvalidOperationException("LEAVE_NOT_OWNER");
        }

        EnsurePending(entity);

        entity.Status = "Withdrawn";
        entity.DecisionOn = DateTime.UtcNow;
        entity.ApproverId = entity.EmployeeId;
        entity.ApproverName = entity.Employee?.FullName ?? "Requester";
        entity.ManagerComment = string.IsNullOrWhiteSpace(comment)
            ? "Withdrawn by requester."
            : comment.Trim();

        await _repository.UpdateAsync(entity, cancellationToken);
        var reloaded = await _repository.FindByIdAsync(entity.Id, cancellationToken);
        if (reloaded is null)
        {
            throw new InvalidOperationException("LEAVE_NOT_FOUND");
        }

        return ToDetail(reloaded);
    }

    public async Task<LeaveRequestDetailDto> ApproveAsync(
        Guid requestId,
        Guid managerId,
        string managerName,
        LeaveDecisionDto decision,
        CancellationToken cancellationToken = default)
    {
        var entity = await _repository.FindByIdAsync(requestId, cancellationToken);
        if (entity is null)
        {
            throw new InvalidOperationException("LEAVE_NOT_FOUND");
        }

        EnsurePending(entity);

        entity.Status = "Approved";
        entity.ApproverId = managerId;
        entity.ApproverName = managerName;
        entity.DecisionOn = DateTime.UtcNow;
        entity.ManagerComment = NormalizeDecision(decision.Comment, approved: true);

        await _repository.UpdateAsync(entity, cancellationToken);
        var reloaded = await _repository.FindByIdAsync(entity.Id, cancellationToken);
        return reloaded is null ? throw new InvalidOperationException("LEAVE_NOT_FOUND") : ToDetail(reloaded);
    }

    public async Task<LeaveRequestDetailDto> RejectAsync(
        Guid requestId,
        Guid managerId,
        string managerName,
        LeaveDecisionDto decision,
        CancellationToken cancellationToken = default)
    {
        var entity = await _repository.FindByIdAsync(requestId, cancellationToken);
        if (entity is null)
        {
            throw new InvalidOperationException("LEAVE_NOT_FOUND");
        }

        EnsurePending(entity);

        entity.Status = "Rejected";
        entity.ApproverId = managerId;
        entity.ApproverName = managerName;
        entity.DecisionOn = DateTime.UtcNow;
        entity.ManagerComment = NormalizeDecision(decision.Comment, approved: false);

        await _repository.UpdateAsync(entity, cancellationToken);
        var reloaded = await _repository.FindByIdAsync(entity.Id, cancellationToken);
        return reloaded is null ? throw new InvalidOperationException("LEAVE_NOT_FOUND") : ToDetail(reloaded);
    }

    public async Task<LeaveRequestDetailDto> UpdateDatesAsync(
        Guid requestId,
        Guid employeeId,
        UpdateLeaveRequestDatesDto payload,
        CancellationToken cancellationToken = default)
    {
        ValidateDateChange(payload);

        var entity = await _repository.FindByIdAsync(requestId, cancellationToken);
        if (entity is null)
        {
            throw new InvalidOperationException("LEAVE_NOT_FOUND");
        }

        if (entity.EmployeeId != employeeId)
        {
            throw new InvalidOperationException("LEAVE_NOT_OWNER");
        }

        EnsurePending(entity);

        entity.StartDate = payload.StartDate.Date;
        entity.EndDate = payload.EndDate.Date;
        entity.IsHalfDay = payload.IsHalfDay;
        entity.ManagerComment = "Updated by requester prior to approval.";
        entity.DecisionOn = null;
        entity.ApproverId = null;
        entity.ApproverName = null;

        await _repository.UpdateAsync(entity, cancellationToken);
        var reloaded = await _repository.FindByIdAsync(entity.Id, cancellationToken);
        return reloaded is null ? throw new InvalidOperationException("LEAVE_NOT_FOUND") : ToDetail(reloaded);
    }

    public Task<LeaveBalanceDto[]> GetBalancesAsync(
        Guid employeeId,
        int year,
        CancellationToken cancellationToken = default)
        => _repository.GetBalancesAsync(employeeId, year, cancellationToken);

    public Task<LeaveTypeDto[]> GetLeaveTypesAsync(CancellationToken cancellationToken = default)
        => _repository.GetLeaveTypesAsync(cancellationToken);

    private static void ValidateCreatePayload(CreateLeaveRequestDto payload)
    {
        if (string.IsNullOrWhiteSpace(payload.LeaveType))
        {
            throw new InvalidOperationException("LEAVE_TYPE_REQUIRED");
        }

        if (string.IsNullOrWhiteSpace(payload.Reason))
        {
            throw new InvalidOperationException("LEAVE_REASON_REQUIRED");
        }

        ValidateDateRange(payload.StartDate.Date, payload.EndDate.Date);

        if (payload.IsHalfDay && payload.StartDate.Date != payload.EndDate.Date)
        {
            throw new InvalidOperationException("LEAVE_HALF_DAY_RANGE");
        }
    }

    private static void ValidateDateChange(UpdateLeaveRequestDatesDto payload)
    {
        ValidateDateRange(payload.StartDate.Date, payload.EndDate.Date);

        if (payload.IsHalfDay && payload.StartDate.Date != payload.EndDate.Date)
        {
            throw new InvalidOperationException("LEAVE_HALF_DAY_RANGE");
        }
    }

    private static void ValidateDateRange(DateTime start, DateTime end)
    {
        if (end < start)
        {
            throw new InvalidOperationException("LEAVE_INVALID_RANGE");
        }

        if ((end - start).TotalDays > 30)
        {
            throw new InvalidOperationException("LEAVE_RANGE_EXCEEDS_LIMIT");
        }
    }

    private static void EnsurePending(LeaveRequest entity)
    {
        if (!string.Equals(entity.Status, "Pending", StringComparison.OrdinalIgnoreCase))
        {
            throw new InvalidOperationException("LEAVE_ALREADY_DECIDED");
        }
    }

    private static string NormalizeDecision(string comment, bool approved)
    {
        if (!string.IsNullOrWhiteSpace(comment))
        {
            return comment.Trim();
        }

        return approved
            ? "Approved - coverage confirmed."
            : "Rejected - please reschedule when coverage is available.";
    }

    private static string? NormalizeOptional(string? value)
    {
        return string.IsNullOrWhiteSpace(value) ? null : value.Trim();
    }

    private static string GenerateReference(DateTime date)
    {
        var suffix = Guid.NewGuid().ToString("N")[..6].ToUpperInvariant();
        return $"LV-{date:yyyy}-{suffix}";
    }

    private static LeaveRequestDetailDto ToDetail(LeaveRequest entity)
    {
        var employeeName = entity.Employee?.FullName ?? "Unknown";
        var timeline = BuildTimeline(entity, employeeName);
        return new LeaveRequestDetailDto(
            entity.Id,
            entity.EmployeeId,
            employeeName,
            entity.Reference,
            entity.LeaveType,
            entity.IsHalfDay,
            entity.StartDate,
            entity.EndDate,
            entity.Status,
            entity.RequestedOn,
            entity.Reason,
            entity.ContactDuringLeave,
            entity.SupportingDocumentUrl,
            entity.ApproverId,
            entity.ApproverName,
            entity.DecisionOn,
            entity.ManagerComment,
            timeline);
    }

    private static LeaveApprovalTimelineEntry[] BuildTimeline(LeaveRequest entity, string employeeName)
    {
        var entries = new List<LeaveApprovalTimelineEntry>
        {
            new(entity.RequestedOn, employeeName, "Submitted", entity.Reason)
        };

        if (!string.IsNullOrWhiteSpace(entity.ManagerComment) && entity.DecisionOn.HasValue)
        {
            var actor = entity.ApproverName ?? "Manager";
            var action = entity.Status switch
            {
                var status when status.Equals("Approved", StringComparison.OrdinalIgnoreCase) => "Approved",
                var status when status.Equals("Rejected", StringComparison.OrdinalIgnoreCase) => "Rejected",
                var status when status.Equals("Withdrawn", StringComparison.OrdinalIgnoreCase) => "Withdrawn",
                _ => "Updated"
            };

            entries.Add(new LeaveApprovalTimelineEntry(
                entity.DecisionOn.Value,
                actor,
                action,
                entity.ManagerComment));
        }

        return entries
            .OrderBy(entry => entry.OccurredOn)
            .ToArray();
    }
}
