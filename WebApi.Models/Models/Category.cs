namespace WebApi.Entities.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Category
    {
        [Column("CategoryId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Title name is a required field.")]
        [MaxLength(80, ErrorMessage = "Maximum length for the Title is 80 characters.")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "SubTitle name is a required field.")]
        [MaxLength(100, ErrorMessage = "Maximum length for the SubTitle is 100 characters.")]
        public string? SubTitle { get; set; }

        [Required(ErrorMessage = "ImageUrl name is a required field.")]
        [MaxLength(1000, ErrorMessage = "Maximum length for the ImageUrl is 1000 characters.")]
        public string? ImageUrl { get; set; }
    }
}