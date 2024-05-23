namespace WebApi.Models.Users;

using System;
using System.ComponentModel.DataAnnotations;
using WebApi.Entities;

public class UpdateImageURLRequest
{
    [Required]
    public int ProductId { get; set; }

    [Required]
    public string PublicUrl { get; set; }

    [Required]
    public string Url { get; set; }

    private string replaceEmptyWithNull(string value)
    {
        return string.IsNullOrEmpty(value) ? null : value;
    }
}