namespace WebApi.Models.Users;

using System.ComponentModel.DataAnnotations;
using WebApi.Entities;

public class CreateReviewRequest
{    
    [Required]
    public User User { get; set; }

    public string Comment { get; set; }
    
    [Required]
    public int Rating { get; set; }

}