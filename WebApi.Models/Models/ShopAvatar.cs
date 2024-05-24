namespace WebApi.Entities.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class ShopAvatar
    {
        [Column("ShopAvatarId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "PublicId name is a required field.")]
        [MaxLength(100, ErrorMessage = "Maximum length for the PublicId is 60 characters.")]
        public string? PublicId { get; set; }

        [Required(ErrorMessage = "Url name is a required field.")]
        [MaxLength(5000, ErrorMessage = "Maximum length for the Url is 1000 characters.")]
        public string? Url { get; set; }
    }
}