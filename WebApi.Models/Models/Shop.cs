namespace WebApi.Entities.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Shop
    {
        [Column("ShopId")]
        public Guid Id { get; set; }

        [ForeignKey(nameof(Product))]
        public Guid ProductId { get; set; }
        public Product? Product { get; set; }

        [Required(ErrorMessage = "Name name is a required field.")]
        [MaxLength(100, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        public string? Name { get; set; }

        public ShopAvatar? ShopAvatars { get; set; }

        [Required(ErrorMessage = "Ratings is a required field.")]
        public int? Ratings { get; set; }
    }
}