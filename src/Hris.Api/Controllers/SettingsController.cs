using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Hris.Application.DTOs.Common;
using Hris.Application.DTOs.Settings;
using Hris.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hris.Api.Controllers;

[ApiController]
[Route("api/settings")]
public class SettingsController : ControllerBase
{
    private static readonly IReadOnlyDictionary<string, string> DefaultSystemConfiguration =
        new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            ["PrimaryTimezone"] = "(UTC+07:00) Bangkok",
            ["WorkweekTemplate"] = "Mon-Fri, 09:00-18:00",
            ["HolidayCalendar"] = "Thailand 2025",
            ["DataResidency"] = "ap-southeast-1"
        };

    private readonly HrisDbContext _context;

    public SettingsController(HrisDbContext context)
    {
        _context = context;
    }

    [HttpPut("system")]
    public async Task<ActionResult<ActionResponse>> UpdateSystemConfiguration(
        [FromBody] SystemConfigurationUpdateDto request,
        CancellationToken cancellationToken)
    {
        var configs = await _context.SystemConfigurations
            .Where(config => DefaultSystemConfiguration.ContainsKey(config.Key))
            .ToListAsync(cancellationToken);

        var now = DateTime.UtcNow;
        var applied = 0;

        foreach (var config in configs)
        {
            var newValue = config.Key switch
            {
                "PrimaryTimezone" => request.PrimaryTimezone,
                "WorkweekTemplate" => request.WorkweekTemplate,
                "HolidayCalendar" => request.HolidayCalendar,
                "DataResidency" => request.DataResidency,
                _ => null
            };

            if (string.IsNullOrWhiteSpace(newValue))
            {
                continue;
            }

            config.Value = newValue;
            config.UpdatedAtUtc = now;
            applied++;
        }

        if (applied == 0)
        {
            return BadRequest(new ActionResponse("SETTINGS.SYSTEM.NO_CHANGES"));
        }

        await _context.SaveChangesAsync(cancellationToken);

        return Ok(new ActionResponse("SETTINGS.SYSTEM.UPDATE_SUCCESS", TimestampUtc: now));
    }

    [HttpPost("system/reset")]
    public async Task<ActionResult<ActionResponse>> ResetSystemConfiguration(CancellationToken cancellationToken)
    {
        var configs = await _context.SystemConfigurations
            .Where(config => DefaultSystemConfiguration.ContainsKey(config.Key))
            .ToListAsync(cancellationToken);

        var now = DateTime.UtcNow;

        foreach (var config in configs)
        {
            config.Value = DefaultSystemConfiguration[config.Key];
            config.UpdatedAtUtc = now;
        }

        await _context.SaveChangesAsync(cancellationToken);

        return Ok(new ActionResponse("SETTINGS.SYSTEM.RESET_SUCCESS", TimestampUtc: now));
    }

    [HttpPost("system/sync")]
    public async Task<ActionResult<ActionResponse>> SyncSystemConfiguration(CancellationToken cancellationToken)
    {
        var configs = await _context.SystemConfigurations.ToListAsync(cancellationToken);
        var now = DateTime.UtcNow;

        foreach (var config in configs)
        {
            config.UpdatedAtUtc = now;
        }

        await _context.SaveChangesAsync(cancellationToken);

        return Ok(new ActionResponse("SETTINGS.SYSTEM.SYNC_SUCCESS", TimestampUtc: now));
    }

    [HttpPut("security")]
    public async Task<ActionResult<ActionResponse>> UpdateSecuritySettings(
        [FromBody] SecuritySettingsUpdateDto request,
        CancellationToken cancellationToken)
    {
        if (request.Controls == null || request.Controls.Count == 0)
        {
            return BadRequest(new ActionResponse("SETTINGS.SECURITY.NO_CONTROLS"));
        }

        var controls = await _context.SecuritySettings.ToListAsync(cancellationToken);
        var controlLookup = controls.ToDictionary(control => control.Control, StringComparer.OrdinalIgnoreCase);

        var now = DateTime.UtcNow;
        var applied = 0;

        foreach (var update in request.Controls)
        {
            if (!controlLookup.TryGetValue(update.Control, out var control))
            {
                continue;
            }

            control.Status = update.Status;
            control.Owner = update.Owner;
            control.Severity = update.Severity;
            control.LastReviewedAtUtc = now;
            applied++;
        }

        if (applied == 0)
        {
            return BadRequest(new ActionResponse("SETTINGS.SECURITY.NO_CHANGES"));
        }

        await _context.SaveChangesAsync(cancellationToken);

        return Ok(new ActionResponse("SETTINGS.SECURITY.UPDATE_SUCCESS", TimestampUtc: now));
    }

    [HttpPost("security/enforce")]
    public async Task<ActionResult<ActionResponse>> EnforceSecurityPolicies(CancellationToken cancellationToken)
    {
        var controls = await _context.SecuritySettings.ToListAsync(cancellationToken);
        var now = DateTime.UtcNow;

        foreach (var control in controls)
        {
            if (!control.Status.Contains("Enforced", StringComparison.OrdinalIgnoreCase))
            {
                control.Status = $"Enforced ({now:yyyy-MM-dd})";
            }

            control.LastReviewedAtUtc = now;
        }

        await _context.SaveChangesAsync(cancellationToken);

        return Ok(new ActionResponse("SETTINGS.SECURITY.ENFORCE_SUCCESS", TimestampUtc: now));
    }

    [HttpPost("security/run-audit")]
    public async Task<ActionResult<ActionResponse>> RunSecurityAudit(CancellationToken cancellationToken)
    {
        var audit = new Hris.Domain.Entities.SecurityAuditLog
        {
            Id = Guid.NewGuid(),
            RunAtUtc = DateTime.UtcNow,
            PerformedBy = "Automation",
            Status = "Completed",
            Summary = "Automated audit executed via API trigger."
        };

        await _context.SecurityAuditLogs.AddAsync(audit, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);

        return Ok(new ActionResponse("SETTINGS.SECURITY.AUDIT_SUCCESS", TimestampUtc: audit.RunAtUtc));
    }
}
