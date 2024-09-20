using System.ComponentModel.DataAnnotations;

namespace WebApi.Shared.DataTransferObjects
{
    public record UserForLoginAuthenticationDto
    { 
        [Required(ErrorMessage = "Email is required")] 
        public string? Email { get; init; } 
        
        [Required(ErrorMessage = "Password name is required")] 
        public string? Password { get; init; }
    }
}
