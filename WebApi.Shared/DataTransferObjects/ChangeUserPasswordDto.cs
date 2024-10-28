using System.ComponentModel.DataAnnotations;

namespace WebApi.Shared.DataTransferObjects
{
    public record ChangeUserPasswordDto
    { 
        [Required(ErrorMessage = "Email is required")] 
        public string? Email { get; init; }


        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string? OldPassword { get; init; }


        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string? NewPassword { get; init; }


        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string? ConfirmPassword { get; init; }
    }
}
