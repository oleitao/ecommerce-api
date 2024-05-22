namespace WebApi.Models.Users;

using System;
using System.ComponentModel.DataAnnotations;
using WebApi.Entities;

public class UpdateUserRequest
{
    [Required]
    public string FullName { get; set; }

    [Required]
    public char Sex { get; set; }

    public int Age { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "YYYY-MM-DD")]
    public DateTime? Birthday { get; set; }

    public string Hobby { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    private string replaceEmptyWithNull(string value)
    {
        return string.IsNullOrEmpty(value) ? null : value;
    }
}