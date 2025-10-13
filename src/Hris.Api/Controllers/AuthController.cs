using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using Hris.Application.DTOs.Auth;
using Hris.Application.DTOs.Common;
using Hris.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hris.Api.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private static readonly Dictionary<string, string> RoleMap = new(StringComparer.OrdinalIgnoreCase)
    {
        ["Administrator"] = "Admin",
        ["Manager"] = "Manager",
        ["Employee"] = "User"
    };

    private static readonly Dictionary<string, string> RolePasswords = new(StringComparer.OrdinalIgnoreCase)
    {
        ["Admin"] = "Admin@123",
        ["Manager"] = "Manager@123",
        ["User"] = "Employee@123"
    };

    private static readonly Dictionary<string, string[]> RolePermissions = new(StringComparer.OrdinalIgnoreCase)
    {
        ["Admin"] = new[] { "settings:manage", "security:manage", "reports:access", "users:manage", "team:approve" },
        ["Manager"] = new[] { "team:approve" },
        ["User"] = Array.Empty<string>()
    };

    private static readonly ConcurrentDictionary<string, SessionRecord> Sessions = new(StringComparer.Ordinal);
    private static readonly TimeSpan TokenLifetime = TimeSpan.FromMinutes(30);
    private static readonly TimeSpan RefreshGracePeriod = TimeSpan.FromMinutes(10);
    private const string BearerPrefix = "Bearer ";

    private readonly HrisDbContext _context;

    public AuthController(HrisDbContext context)
    {
        _context = context;
    }

    [HttpPost("login")]
    public async Task<ActionResult<LoginResponseDto>> Login([FromBody] LoginRequestDto request, CancellationToken cancellationToken)
    {
        if (string.IsNullOrWhiteSpace(request.Email) || string.IsNullOrWhiteSpace(request.Password))
        {
            return BadRequest(new ActionResponse("AUTH.LOGIN.INVALID_INPUT"));
        }

        var normalizedEmail = request.Email.Trim().ToLowerInvariant();
        var user = await _context.UserAccounts
            .AsNoTracking()
            .FirstOrDefaultAsync(account => account.Email.ToLower() == normalizedEmail, cancellationToken);

        if (user is null)
        {
            return Unauthorized(new ActionResponse("AUTH.LOGIN.INVALID_CREDENTIALS"));
        }

        if (!string.Equals(user.Status, "Active", StringComparison.OrdinalIgnoreCase))
        {
            return Unauthorized(new ActionResponse("AUTH.LOGIN.SUSPENDED"));
        }

        if (!RoleMap.TryGetValue(user.Role, out var canonicalRole))
        {
            canonicalRole = "User";
        }

        if (!RolePasswords.TryGetValue(canonicalRole, out var expectedPassword) ||
            !string.Equals(expectedPassword, request.Password, StringComparison.Ordinal))
        {
            return Unauthorized(new ActionResponse("AUTH.LOGIN.INVALID_CREDENTIALS"));
        }

        var expiresAt = DateTime.UtcNow.Add(TokenLifetime);
        var token = GenerateToken();
        var permissions = RolePermissions.TryGetValue(canonicalRole, out var rolePermissions)
            ? rolePermissions
            : Array.Empty<string>();

        var session = new SessionRecord(
            user.Email,
            user.Name,
            canonicalRole,
            permissions,
            expiresAt);

        Sessions[token] = session;

        var response = new LoginResponseDto(
            token,
            user.Name,
            user.Email,
            new[] { canonicalRole },
            permissions,
            expiresAt);

        return Ok(response);
    }

    [HttpGet("profile")]
    public ActionResult<AuthProfileDto> GetProfile()
    {
        if (!TryGetSessionFromHeader(out var token, out var sessionRecord, out var errorResult))
        {
            return errorResult;
        }

        var session = sessionRecord!;

        if (session.ExpiresAt < DateTime.UtcNow)
        {
            Sessions.TryRemove(token, out _);
            return Unauthorized(new ActionResponse("AUTH.LOGIN.EXPIRED"));
        }

        var profile = new AuthProfileDto(
            session.DisplayName,
            session.Email,
            new[] { session.Role },
            session.Permissions,
            session.ExpiresAt);

        return Ok(profile);
    }

    [HttpPost("refresh")]
    public ActionResult<LoginResponseDto> RefreshToken()
    {
        if (!TryGetSessionFromHeader(out var token, out var sessionRecord, out var errorResult))
        {
            return errorResult;
        }

        var session = sessionRecord!;
        var now = DateTime.UtcNow;

        if (session.ExpiresAt.Add(RefreshGracePeriod) < now)
        {
            Sessions.TryRemove(token, out _);
            return Unauthorized(new ActionResponse("AUTH.LOGIN.EXPIRED"));
        }

        var newToken = GenerateToken();
        var updatedSession = session with { ExpiresAt = now.Add(TokenLifetime) };

        Sessions[newToken] = updatedSession;
        Sessions.TryRemove(token, out _);

        var response = new LoginResponseDto(
            newToken,
            updatedSession.DisplayName,
            updatedSession.Email,
            new[] { updatedSession.Role },
            updatedSession.Permissions,
            updatedSession.ExpiresAt);

        return Ok(response);
    }

    private static string GenerateToken()
    {
        var bytes = RandomNumberGenerator.GetBytes(32);
        return Convert.ToBase64String(bytes);
    }

    private bool TryGetSessionFromHeader(out string token, out SessionRecord? session, out ActionResult errorResult)
    {
        token = string.Empty;
        session = null;
        errorResult = Unauthorized(new ActionResponse("AUTH.LOGIN.MISSING_TOKEN"));

        if (!Request.Headers.TryGetValue("Authorization", out var headerValues))
        {
            return false;
        }

        var header = headerValues.FirstOrDefault();
        if (string.IsNullOrWhiteSpace(header) || !header.StartsWith(BearerPrefix, StringComparison.OrdinalIgnoreCase))
        {
            errorResult = Unauthorized(new ActionResponse("AUTH.LOGIN.INVALID_TOKEN"));
            return false;
        }

        token = header[BearerPrefix.Length..].Trim();
        if (string.IsNullOrWhiteSpace(token))
        {
            errorResult = Unauthorized(new ActionResponse("AUTH.LOGIN.INVALID_TOKEN"));
            return false;
        }

        if (!Sessions.TryGetValue(token, out session))
        {
            errorResult = Unauthorized(new ActionResponse("AUTH.LOGIN.INVALID_TOKEN"));
            return false;
        }

        return true;
    }

    private sealed record SessionRecord(string Email, string DisplayName, string Role, string[] Permissions, DateTime ExpiresAt);
}
