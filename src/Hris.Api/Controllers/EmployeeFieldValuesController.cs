using Hris.Application.DTOs.EmployeeRecords;
using Hris.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Hris.Api.Controllers;

[ApiController]
[Route("api/employee-records/{employeeNumber}/fields")]
public class EmployeeFieldValuesController : ControllerBase
{
    private readonly IEmployeeFieldValueService _fieldValueService;

    public EmployeeFieldValuesController(IEmployeeFieldValueService fieldValueService)
    {
        _fieldValueService = fieldValueService;
    }

    [HttpGet]
    public async Task<ActionResult<EmployeeFieldValueSetDto>> Get(string employeeNumber, CancellationToken cancellationToken)
    {
        var result = await _fieldValueService.GetForEmployeeAsync(employeeNumber, cancellationToken);
        if (result is null)
        {
            return NotFound();
        }

        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult<EmployeeFieldValueSetDto>> Update(
        string employeeNumber,
        [FromBody] EmployeeFieldValueUpdateCommand? command,
        CancellationToken cancellationToken)
    {
        command ??= new EmployeeFieldValueUpdateCommand(string.Empty, Array.Empty<EmployeeFieldValueUpdateItem>());

        try
        {
            var result = await _fieldValueService.UpdateForEmployeeAsync(employeeNumber, command, cancellationToken);
            if (result is null)
            {
                return NotFound();
            }

            return Ok(result);
        }
        catch (InvalidOperationException exception)
        {
            return BadRequest(new { message = exception.Message });
        }
    }
}
