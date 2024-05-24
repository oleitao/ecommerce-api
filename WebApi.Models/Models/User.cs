namespace WebApi.Entities.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class User
    {
        [Column("UserId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "FullName name is a required field.")]
        [MaxLength(500, ErrorMessage = "Maximum length for the FullName is 500 characters.")]
        public string? FullName { get; set; }

        [Required(ErrorMessage = "Sex name is a required field.")]
        [MaxLength(80, ErrorMessage = "Maximum length for the Sex is 60 characters.")]
        public char? Sex { get; set; }

        [Required(ErrorMessage = "Age is a required field.")]
        public int? Age { get; set; }

        public DateTime? Birthday { get; set; }

        [Required(ErrorMessage = "Hobby name is a required field.")]
        [MaxLength(80, ErrorMessage = "Maximum length for the Hobby is 60 characters.")]
        public string? Hobby { get; set; }

        [Required(ErrorMessage = "Email name is a required field.")]
        [MaxLength(80, ErrorMessage = "Maximum length for the Email is 60 characters.")]
        public string? Email { get; set; }
    }
}