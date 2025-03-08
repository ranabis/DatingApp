using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace API.DTOs;

public class RegisterDto
{
    [Required]
    [MinLength(4, ErrorMessage ="The username must be at least 4 characters")]
    [MaxLength(64, ErrorMessage ="The username cannot be more than 64 characters.")]
    public string Username { get; set; } = string.Empty;
    
    [Required]
    [MinLength(8, ErrorMessage ="The password must be at least 8 characters")]
    [MaxLength(64, ErrorMessage ="The password cannot be more than 64 characters.")]
    //[PasswordPropertyText]
    public string Password { get; set; } = string.Empty;
}