namespace WebApi.Entities.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Review
    {
        [Column("ReviewId")]
        public Guid Id { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public User? User { get; set; }

        [Required(ErrorMessage = "Comment name is a required field.")]
        [MaxLength(1000, ErrorMessage = "Maximum length for the Comment is 60 characters.")]
        public string? Comment { get; set; }

        [Required(ErrorMessage = "Rating is a required field.")]
        public int? Rating { get; set; }
    }
}