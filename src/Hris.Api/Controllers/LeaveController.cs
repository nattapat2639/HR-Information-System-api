using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Hris.Application.DTOs;
using Hris.Application.DTOs.Leave;
using Hris.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hris.Api.Controllers;

[ApiController]
[Route("api/leave")]
public class LeaveController : ControllerBase
{
    private static readonly Guid DefaultEmployeeId = Guid.Parse("00000064-0000-0001-0000-00660000309E");
    private static readonly Guid DefaultManagerId = Guid.Parse("00000064-0000-0002-0000-00600000309F");
    private const string DefaultEmployeeName = "Alex Morgan";
    private const string DefaultManagerName = "Jamie Wong";

    private readonly ILeaveManagementService _leaveService;

    public LeaveController(ILeaveManagementService leaveService)
    {
        _leaveService = leaveService;
    }

    [HttpGet("my")]
    [ProducesResponseType(typeof(PagedResult<LeaveRequestSummaryDto>), StatusCodes.Status200OK)]
    public async Task<ActionResult<PagedResult<LeaveRequestSummaryDto>>> GetMyRequests(
        [FromQuery] LeaveQueryParameters query,
        CancellationToken cancellationToken = default)
    {
        var (page, pageSize) = ResolvePagination(Request.Query);
        var employeeId = ResolveGuid(Request, "X-Employee-Id", DefaultEmployeeId);
        var result = await _leaveService.GetMyRequestsAsync(
            employeeId,
            query.ToDto(),
            page,
            pageSize,
            cancellationToken);

        return Ok(result);
    }

    [HttpGet("team")]
    [ProducesResponseType(typeof(PagedResult<LeaveRequestSummaryDto>), StatusCodes.Status200OK)]
    public async Task<ActionResult<PagedResult<LeaveRequestSummaryDto>>> GetTeamRequests(
        [FromQuery] LeaveQueryParameters query,
        CancellationToken cancellationToken = default)
    {
        var (page, pageSize) = ResolvePagination(Request.Query);
        var managerId = ResolveGuid(Request, "X-Manager-Id", DefaultManagerId);
        var result = await _leaveService.GetTeamRequestsAsync(
            managerId,
            query.ToDto(),
            page,
            pageSize,
            cancellationToken);

        return Ok(result);
    }

    [HttpGet("history")]
    [ProducesResponseType(typeof(PagedResult<LeaveRequestSummaryDto>), StatusCodes.Status200OK)]
    public async Task<ActionResult<PagedResult<LeaveRequestSummaryDto>>> GetHistory(
        [FromQuery] LeaveQueryParameters query,
        CancellationToken cancellationToken = default)
    {
        var (page, pageSize) = ResolvePagination(Request.Query);
        var employeeId = ResolveGuid(Request, "X-Employee-Id", DefaultEmployeeId);
        var result = await _leaveService.GetHistoryAsync(
            employeeId,
            query.ToDto(),
            page,
            pageSize,
            cancellationToken);

        return Ok(result);
    }

    [HttpGet("history/export")]
    [ProducesResponseType(typeof(FileContentResult), StatusCodes.Status200OK)]
    public async Task<IActionResult> ExportHistory(
        [FromQuery] LeaveQueryParameters query,
        CancellationToken cancellationToken = default)
    {
        var employeeId = ResolveGuid(Request, "X-Employee-Id", DefaultEmployeeId);
        var history = await _leaveService.GetHistoryAsync(
            employeeId,
            query.ToDto(),
            pageNumber: 1,
            pageSize: 500,
            cancellationToken);

        var builder = new StringBuilder();
        builder.AppendLine("Reference,LeaveType,StartDate,EndDate,Status,DecisionOn,Approver,Reason");

        foreach (var item in history.Items)
        {
            builder
                .Append(Escape(item.Reference)).Append(',')
                .Append(Escape(item.LeaveType)).Append(',')
                .Append(item.StartDate.ToString("yyyy-MM-dd"))
                .Append(',').Append(item.EndDate.ToString("yyyy-MM-dd"))
                .Append(',').Append(Escape(item.Status))
                .Append(',').Append(item.DecisionOn?.ToString("yyyy-MM-dd") ?? string.Empty)
                .Append(',').Append(Escape(item.ApproverName ?? string.Empty))
                .Append(',').Append(Escape(item.Reason ?? string.Empty))
                .AppendLine();
        }

        var bytes = Encoding.UTF8.GetBytes(builder.ToString());
        var fileName = $"leave-history-{DateTime.UtcNow:yyyyMMddHHmmss}.csv";
        return File(bytes, "text/csv", fileName);

        static string Escape(string value)
        {
            if (value.Contains('"') || value.Contains(',') || value.Contains('\n'))
            {
                return '"' + value.Replace("\"", "\"\"") + '"';
            }
            return value;
        }
    }

    [HttpGet("balances")]
    [ProducesResponseType(typeof(LeaveBalanceDto[]), StatusCodes.Status200OK)]
    public async Task<ActionResult<LeaveBalanceDto[]>> GetBalances(
        [FromQuery] int? year,
        CancellationToken cancellationToken = default)
    {
        var employeeId = ResolveGuid(Request, "X-Employee-Id", DefaultEmployeeId);
        var targetYear = year is > 2000 and < 2100 ? year.Value : DateTime.UtcNow.Year;

        var balances = await _leaveService.GetBalancesAsync(employeeId, targetYear, cancellationToken);
        return Ok(balances);
    }

    [HttpGet("types")]
    [ProducesResponseType(typeof(LeaveTypeDto[]), StatusCodes.Status200OK)]
    public async Task<ActionResult<LeaveTypeDto[]>> GetLeaveTypes(CancellationToken cancellationToken = default)
    {
        var types = await _leaveService.GetLeaveTypesAsync(cancellationToken);
        return Ok(types);
    }

    [HttpPost]
    [ProducesResponseType(typeof(LeaveRequestDetailDto), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<LeaveRequestDetailDto>> SubmitRequest(
        [FromBody] CreateLeaveRequestDto request,
        CancellationToken cancellationToken = default)
    {
        try
        {
            var employeeId = ResolveGuid(Request, "X-Employee-Id", DefaultEmployeeId);
            var employeeName = Request.Headers.TryGetValue("X-Employee-Name", out var headerName) && !string.IsNullOrWhiteSpace(headerName)
                ? headerName.ToString()
                : DefaultEmployeeName;

            var result = await _leaveService.SubmitAsync(employeeId, employeeName, request, cancellationToken);
            return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
        }
        catch (InvalidOperationException ex)
        {
            return MapInvalidOperation(ex);
        }
    }

    [HttpGet("{id:guid}")]
    [ProducesResponseType(typeof(LeaveRequestDetailDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<LeaveRequestDetailDto>> GetById(Guid id, CancellationToken cancellationToken = default)
    {
        var detail = await _leaveService.GetByIdAsync(id, cancellationToken);
        if (detail is null)
        {
            return NotFound();
        }

        return Ok(detail);
    }

    [HttpPost("{id:guid}/withdraw")]
    [ProducesResponseType(typeof(LeaveRequestDetailDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<LeaveRequestDetailDto>> Withdraw(
        Guid id,
        [FromBody] LeaveDecisionDto? request,
        CancellationToken cancellationToken = default)
    {
        try
        {
            var employeeId = ResolveGuid(Request, "X-Employee-Id", DefaultEmployeeId);
            var comment = request?.Comment ?? string.Empty;
            var result = await _leaveService.WithdrawAsync(id, employeeId, comment, cancellationToken);
            return Ok(result);
        }
        catch (InvalidOperationException ex)
        {
            return MapInvalidOperation(ex);
        }
    }

    [HttpPost("{id:guid}/approve")]
    [ProducesResponseType(typeof(LeaveRequestDetailDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<LeaveRequestDetailDto>> Approve(
        Guid id,
        [FromBody] LeaveDecisionDto request,
        CancellationToken cancellationToken = default)
    {
        try
        {
            var managerId = ResolveGuid(Request, "X-Manager-Id", DefaultManagerId);
            var managerName = Request.Headers.TryGetValue("X-Manager-Name", out var headerName) && !string.IsNullOrWhiteSpace(headerName)
                ? headerName.ToString()
                : DefaultManagerName;

            var result = await _leaveService.ApproveAsync(id, managerId, managerName, request, cancellationToken);
            return Ok(result);
        }
        catch (InvalidOperationException ex)
        {
            return MapInvalidOperation(ex);
        }
    }

    [HttpPost("{id:guid}/reject")]
    [ProducesResponseType(typeof(LeaveRequestDetailDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<LeaveRequestDetailDto>> Reject(
        Guid id,
        [FromBody] LeaveDecisionDto request,
        CancellationToken cancellationToken = default)
    {
        try
        {
            var managerId = ResolveGuid(Request, "X-Manager-Id", DefaultManagerId);
            var managerName = Request.Headers.TryGetValue("X-Manager-Name", out var headerName) && !string.IsNullOrWhiteSpace(headerName)
                ? headerName.ToString()
                : DefaultManagerName;

            var result = await _leaveService.RejectAsync(id, managerId, managerName, request, cancellationToken);
            return Ok(result);
        }
        catch (InvalidOperationException ex)
        {
            return MapInvalidOperation(ex);
        }
    }

    [HttpPatch("{id:guid}/dates")]
    [ProducesResponseType(typeof(LeaveRequestDetailDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<LeaveRequestDetailDto>> UpdateDates(
        Guid id,
        [FromBody] UpdateLeaveRequestDatesDto request,
        CancellationToken cancellationToken = default)
    {
        try
        {
            var employeeId = ResolveGuid(Request, "X-Employee-Id", DefaultEmployeeId);
            var result = await _leaveService.UpdateDatesAsync(id, employeeId, request, cancellationToken);
            return Ok(result);
        }
        catch (InvalidOperationException ex)
        {
            return MapInvalidOperation(ex);
        }
    }

    private static (int Page, int PageSize) ResolvePagination(IQueryCollection query)
    {
        var page = TryParse(query, "pageNumber") ?? TryParse(query, "page") ?? 1;
        var size = TryParse(query, "pageSize") ?? 20;

        return (Math.Max(1, page), Math.Clamp(size, 5, 100));
    }

    private static int? TryParse(IQueryCollection query, string key)
    {
        if (query.TryGetValue(key, out var value) && int.TryParse(value, out var parsed))
        {
            return parsed;
        }

        return null;
    }

    private static Guid ResolveGuid(HttpRequest request, string headerName, Guid fallback)
    {
        if (request.Headers.TryGetValue(headerName, out var headerValue) &&
            Guid.TryParse(headerValue.ToString(), out var parsed))
        {
            return parsed;
        }

        if (request.Query.TryGetValue(headerName, out var queryValue) &&
            Guid.TryParse(queryValue.ToString(), out var parsedFromQuery))
        {
            return parsedFromQuery;
        }

        return fallback;
    }

    private ActionResult MapInvalidOperation(InvalidOperationException exception)
    {
        return exception.Message switch
        {
            "LEAVE_NOT_FOUND" => NotFound(new { message = exception.Message }),
            "LEAVE_NOT_OWNER" => Forbid(),
            "LEAVE_ALREADY_DECIDED" => Conflict(new { message = exception.Message }),
            "LEAVE_TYPE_REQUIRED" => BadRequest(new { message = exception.Message }),
            "LEAVE_REASON_REQUIRED" => BadRequest(new { message = exception.Message }),
            "LEAVE_INVALID_RANGE" => BadRequest(new { message = exception.Message }),
            "LEAVE_RANGE_EXCEEDS_LIMIT" => BadRequest(new { message = exception.Message }),
            "LEAVE_HALF_DAY_RANGE" => BadRequest(new { message = exception.Message }),
            _ => BadRequest(new { message = exception.Message })
        };
    }

    public class LeaveQueryParameters
    {
        public string? LeaveType { get; set; }
        public string? Status { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? EmployeeKeyword { get; set; }

        public LeaveRequestQueryDto ToDto()
        {
            return new LeaveRequestQueryDto(
                LeaveType,
                Status,
                StartDate?.Date,
                EndDate?.Date,
                EmployeeKeyword);
        }
    }
}
