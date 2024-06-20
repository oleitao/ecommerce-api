using System.ComponentModel.DataAnnotations;

namespace WebApi.Shared.DataTransferObjects
{
    [Serializable]
    public record UserDto(Guid Id, string FullName, string Gender, string UserName, int Age, DateTime Birthday, string Hobby, string Email);

    public record UserForReviewCreationDto(Guid Id);

    public record UserForCreationDto(

        [Required(ErrorMessage = "FullName name is a required field.")]
        [MaxLength(500, ErrorMessage = "Maximum length for the FullName is 500 characters.")]
        string FullName,

        [Required(ErrorMessage = "Sex name is a required field.")]
        [MaxLength(1, ErrorMessage = "Maximum length for the Sex is 1 characters.")]
        string Gender,

        string UserName,

        [Required(ErrorMessage = "Age is a required field.")]
        int Age,

        DateTime Birthday,

        [Required(ErrorMessage = "Hobby name is a required field.")]
        [MaxLength(80, ErrorMessage = "Maximum length for the Hobby is 60 characters.")]
        string Hobby,

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        string Email
    );

    public record UserForUpdateDto(string FullName, string Gender, string UserName, int Age, DateTime Birthday, string Hobby, string Email);

    public record UserForDeleteDto(Guid Id);
}
