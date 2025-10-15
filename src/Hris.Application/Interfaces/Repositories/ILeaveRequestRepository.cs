using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Hris.Application.DTOs;
using Hris.Application.DTOs.Leave;
using Hris.Domain.Entities;

namespace Hris.Application.Interfaces.Repositories;

public interface ILeaveRequestRepository
{
    Task<PagedResult<LeaveRequestSummaryDto>> GetMyRequestsAsync(
        Guid employeeId,
        LeaveRequestQueryDto query,
        int pageNumber,
        int pageSize,
        CancellationToken cancellationToken);

    Task<PagedResult<LeaveRequestSummaryDto>> GetTeamRequestsAsync(
        Guid managerId,
        LeaveRequestQueryDto query,
        int pageNumber,
        int pageSize,
        CancellationToken cancellationToken);

    Task<PagedResult<LeaveRequestSummaryDto>> GetHistoryAsync(
        Guid employeeId,
        LeaveRequestQueryDto query,
        int pageNumber,
        int pageSize,
        CancellationToken cancellationToken);

    Task<LeaveRequest?> FindByIdAsync(Guid requestId, CancellationToken cancellationToken);

    Task AddAsync(LeaveRequest request, CancellationToken cancellationToken);

    Task UpdateAsync(LeaveRequest request, CancellationToken cancellationToken);

    Task<LeaveBalanceDto[]> GetBalancesAsync(Guid employeeId, int year, CancellationToken cancellationToken);

    Task<LeaveTypeDto[]> GetLeaveTypesAsync(CancellationToken cancellationToken);
}
