namespace WebApi.Entities.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class ImageUrl
    {
        [Column("ImageUrlId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Category name is a required field.")]
        [MaxLength(1000, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        public string? PublicUrl { get; set; }

        [Required(ErrorMessage = "Category name is a required field.")]
        [MaxLength(1000, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        public string? Url { get; set; }
    }
}
