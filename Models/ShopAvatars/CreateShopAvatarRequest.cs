namespace WebApi.Models.Users;

using System.ComponentModel.DataAnnotations;

public class CreateShopAvatarRequest
{
    [Required]
    public string PublicId { get; set; }

    [Required]
    public string Url { get; set; }
}