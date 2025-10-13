using System;
using System.Collections.Generic;

namespace Hris.Application.DTOs.Auth;

public record LoginResponseDto(
    string Token,
    string DisplayName,
    string Email,
    IReadOnlyCollection<string> Roles,
    IReadOnlyCollection<string> Permissions,
    DateTime ExpiresAt);
