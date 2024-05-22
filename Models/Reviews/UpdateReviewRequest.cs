namespace WebApi.Models.Users;

using System;
using System.ComponentModel.DataAnnotations;
using WebApi.Entities;

public class UpdateReviewRequest
{
    [Required]
    public User User { get; set; }

    public string Comment { get; set; }

    [Required]
    public int Rating { get; set; }


    private string replaceEmptyWithNull(string value)
    {
        return string.IsNullOrEmpty(value) ? null : value;
    }
}