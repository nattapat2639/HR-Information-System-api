using System;

namespace Hris.Application.DTOs.Common;

public record ActionResponse(string Message, string? Detail = null, DateTime? TimestampUtc = null);
