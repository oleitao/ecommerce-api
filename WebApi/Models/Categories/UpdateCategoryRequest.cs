namespace WebApi.Models.Categories;

using System;
using System.ComponentModel.DataAnnotations;
using WebApi.Entities;

public class UpdateCategoryRequest
{
    [Required]
    public string Title { get; set; }

    public string SubTitle { get; set; }

    [Required]
    public string ImageUrl { get; set; }

    private string replaceEmptyWithNull(string value)
    {
        return string.IsNullOrEmpty(value) ? null : value;
    }
}