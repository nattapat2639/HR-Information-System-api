using System;
using System.Threading;
using System.Threading.Tasks;
using Hris.Application.DTOs;
using Hris.Application.DTOs.Leave;

namespace Hris.Application.Interfaces.Services;

public interface ILeaveManagementService
{
    Task<PagedResult<LeaveRequestSummaryDto>> GetMyRequestsAsync(
        Guid employeeId,
        LeaveRequestQueryDto query,
        int pageNumber,
        int pageSize,
        CancellationToken cancellationToken = default);

    Task<PagedResult<LeaveRequestSummaryDto>> GetTeamRequestsAsync(
        Guid managerId,
        LeaveRequestQueryDto query,
        int pageNumber,
        int pageSize,
        CancellationToken cancellationToken = default);

    Task<PagedResult<LeaveRequestSummaryDto>> GetHistoryAsync(
        Guid employeeId,
        LeaveRequestQueryDto query,
        int pageNumber,
        int pageSize,
        CancellationToken cancellationToken = default);

    Task<LeaveRequestDetailDto?> GetByIdAsync(
        Guid requestId,
        CancellationToken cancellationToken = default);

    Task<LeaveRequestDetailDto> SubmitAsync(
        Guid employeeId,
        string employeeName,
        CreateLeaveRequestDto payload,
        CancellationToken cancellationToken = default);

    Task<LeaveRequestDetailDto> WithdrawAsync(
        Guid requestId,
        Guid employeeId,
        string comment,
        CancellationToken cancellationToken = default);

    Task<LeaveRequestDetailDto> ApproveAsync(
        Guid requestId,
        Guid managerId,
        string managerName,
        LeaveDecisionDto decision,
        CancellationToken cancellationToken = default);

    Task<LeaveRequestDetailDto> RejectAsync(
        Guid requestId,
        Guid managerId,
        string managerName,
        LeaveDecisionDto decision,
        CancellationToken cancellationToken = default);

    Task<LeaveRequestDetailDto> UpdateDatesAsync(
        Guid requestId,
        Guid employeeId,
        UpdateLeaveRequestDatesDto payload,
        CancellationToken cancellationToken = default);

    Task<LeaveBalanceDto[]> GetBalancesAsync(
        Guid employeeId,
        int year,
        CancellationToken cancellationToken = default);

    Task<LeaveTypeDto[]> GetLeaveTypesAsync(CancellationToken cancellationToken = default);
}
