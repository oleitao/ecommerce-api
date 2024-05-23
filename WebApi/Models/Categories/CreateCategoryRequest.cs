namespace WebApi.Models.Categories;

using System.ComponentModel.DataAnnotations;

public class CreateCategoryRequest
{
    [Required]
    public string Title { get; set; }

    public string SubTitle { get; set; }

    [Required]
    public string ImageUrl { get; set; }
}