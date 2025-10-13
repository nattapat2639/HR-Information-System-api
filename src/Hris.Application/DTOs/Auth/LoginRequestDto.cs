using System.ComponentModel.DataAnnotations;

namespace Hris.Application.DTOs.Auth;

public record LoginRequestDto(
    [Required] string Email,
    [Required] string Password);
