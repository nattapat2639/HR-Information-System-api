using Hris.Application.DTOs;
using Hris.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Hris.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeesController : ControllerBase
{
    private readonly IEmployeeService _employeeService;

    public EmployeesController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpGet]
    [ProducesResponseType(typeof(PagedResult<EmployeeDto>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetEmployees([FromQuery] int page = 1, [FromQuery] int pageSize = 10, CancellationToken cancellationToken = default)
    {
        var result = await _employeeService.GetEmployeesAsync(page, pageSize, cancellationToken);
        return Ok(result);
    }

    [HttpGet("{id:guid}")]
    [ProducesResponseType(typeof(EmployeeDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetEmployee(Guid id, CancellationToken cancellationToken = default)
    {
        var employee = await _employeeService.GetEmployeeAsync(id, cancellationToken);
        if (employee is null)
        {
            return NotFound();
        }

        return Ok(employee);
    }

    [HttpPost]
    [ProducesResponseType(typeof(EmployeeDto), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public async Task<IActionResult> CreateEmployee([FromBody] EmployeeCreateRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var employee = await _employeeService.CreateEmployeeAsync(request, cancellationToken);
            return CreatedAtAction(nameof(GetEmployee), new { id = employee.Id }, employee);
        }
        catch (InvalidOperationException ex)
        {
            return MapInvalidOperation(ex);
        }
    }

    private ActionResult MapInvalidOperation(InvalidOperationException exception)
    {
        return exception.Message switch
        {
            "EMPLOYEE_NUMBER_EXISTS" => Conflict(new { message = exception.Message }),
            "EMPLOYEE_NUMBER_REQUIRED" => BadRequest(new { message = exception.Message }),
            "EMPLOYEE_FULL_NAME_REQUIRED" => BadRequest(new { message = exception.Message }),
            "EMPLOYEE_DEPARTMENT_REQUIRED" => BadRequest(new { message = exception.Message }),
            "EMPLOYEE_POSITION_REQUIRED" => BadRequest(new { message = exception.Message }),
            _ => BadRequest(new { message = exception.Message })
        };
    }
}
