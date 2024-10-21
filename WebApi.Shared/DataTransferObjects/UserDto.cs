using System.ComponentModel.DataAnnotations;

namespace WebApi.Shared.DataTransferObjects
{
    [Serializable]
    public record UserDto(Guid Id, string FullName, string Gender, string UserName, DateTime Birthday, string Email);

    public record UserForReviewCreationDto(Guid Id);

    public record UserForCreationDto(

        [Required(ErrorMessage = "FullName name is a required field.")]
        [MaxLength(500, ErrorMessage = "Maximum length for the FullName is 500 characters.")]
        string FullName,

        [Required(ErrorMessage = "Sex name is a required field.")]
        [MaxLength(1, ErrorMessage = "Maximum length for the Sex is 1 characters.")]
        string Gender,

        string UserName,

        DateTime Birthday,

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        string Email
    );

    public record UserForUpdateDto(Guid Id, string Gender, string Address, int ZipCode, string Email, string PhoneNumber, string ShopDescription, string role);

    public record UserForDeleteDto(Guid Id);
}
