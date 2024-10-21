using System.ComponentModel.DataAnnotations;

namespace WebApi.Shared.DataTransferObjects
{
    public record UserForRegistrationDto
    {
        public string? FirstName { get; init; }
        public string? LastName { get; init; }
        [Required(ErrorMessage = "Username is required")] public string? UserName { get; init; }
        [Required(ErrorMessage = "Password is required")] public string? Password { get; init; }
        public string? Email { get; init; }
        public string? PhoneNumber { get; init; }        
        public string FullName { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public ICollection<string>? Roles { get; init; }
    }

    public record SellerForRegistrationDto
    {
        public string Name { get; init; }
        public string Email { get; init; }
        [Required(ErrorMessage = "Password is required")] public string? Password { get; init; }
        public int ZipCode { get; set; }
        public string Address { get; set; } = null!;
        public string ShopDescription { get; set; } = null!;
        public ICollection<string>? Roles { get; init; }
    }
}
