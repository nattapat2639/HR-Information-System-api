using Hris.Application.DTOs.EmployeeRecords;
using Hris.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Hris.Api.Controllers;

[ApiController]
[Route("api/employee-fields")]
public class EmployeeFieldDefinitionsController : ControllerBase
{
    private readonly IEmployeeFieldDefinitionService _service;

    public EmployeeFieldDefinitionsController(IEmployeeFieldDefinitionService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IReadOnlyCollection<EmployeeFieldDefinitionDto>>> GetAll(CancellationToken cancellationToken)
    {
        var definitions = await _service.GetAllAsync(cancellationToken);
        return Ok(definitions);
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<EmployeeFieldDefinitionDto>> GetById(Guid id, CancellationToken cancellationToken)
    {
        var definition = await _service.GetByIdAsync(id, cancellationToken);
        if (definition is null)
        {
            return NotFound();
        }

        return Ok(definition);
    }

    [HttpPost]
    public async Task<ActionResult<EmployeeFieldDefinitionDto>> Create(
        [FromBody] EmployeeFieldDefinitionRequest request,
        CancellationToken cancellationToken)
    {
        try
        {
            var definition = await _service.CreateAsync(request, cancellationToken);
            return CreatedAtAction(nameof(GetById), new { id = definition.Id }, definition);
        }
        catch (InvalidOperationException ex)
        {
            return MapInvalidOperation(ex);
        }
    }

    [HttpPut("{id:guid}")]
    public async Task<ActionResult<EmployeeFieldDefinitionDto>> Update(
        Guid id,
        [FromBody] EmployeeFieldDefinitionRequest request,
        CancellationToken cancellationToken)
    {
        try
        {
            var definition = await _service.UpdateAsync(id, request, cancellationToken);
            if (definition is null)
            {
                return NotFound();
            }

            return Ok(definition);
        }
        catch (InvalidOperationException ex)
        {
            return MapInvalidOperation(ex);
        }
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id, CancellationToken cancellationToken)
    {
        var deleted = await _service.DeleteAsync(id, cancellationToken);
        if (!deleted)
        {
            return NotFound();
        }

        return NoContent();
    }

    private ActionResult MapInvalidOperation(InvalidOperationException exception)
    {
        return exception.Message switch
        {
            "FIELD_KEY_EXISTS" => Conflict(new { message = exception.Message }),
            "FIELD_KEY_REQUIRED" => BadRequest(new { message = exception.Message }),
            _ => BadRequest(new { message = exception.Message })
        };
    }
}
