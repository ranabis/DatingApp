using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace API.DTOs;

public class RegisterDto
{
    [MaxLength(100)]
    public required string Username { get; set; }
    
    [MinLength(8)]
    //[PasswordPropertyText]
    public required string Password { get; set; }
}