namespace WebApi.Entities.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Product
    {
        [Column("ProductId")]
        public Guid Id { get; set; }


        [Column("CategoryId")]
        public Guid CategoryId { get; set; }
        

        [Required(ErrorMessage = "Name name is a required field.")]
        [MaxLength(500, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Description name is a required field.")]
        [MaxLength(5000, ErrorMessage = "Maximum length for the Description is 60 characters.")]
        public string? Description { get; set; }

        public ICollection<ImageUrl>? ImageURLs { get; set; }

        [Required(ErrorMessage = "Price is a required field.")]
        public int? Price { get; set; }

        [Required(ErrorMessage = "Discount Price is a required field.")]
        public int? Discount_Price { get; set; }

        [Required(ErrorMessage = "Rating is a required field.")]
        [Range(1, 5)]
        public int? Rating { get; set; }

        public ICollection<Review>? Reviews { get; set; }

        [Required(ErrorMessage = "Total Sell is a required field.")]
        public int? Total_Sell { get; set; }

        [Required(ErrorMessage = "Stock is a required field.")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public int? Stock { get; set; }
    }
}