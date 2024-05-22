namespace WebApi.Models.Users;

using System;
using System.ComponentModel.DataAnnotations;
using WebApi.Entities;

public class UpdateShopAvatarRequest
{    
    [Required]
    public string PublicId { get; set; }

    [Required]
    public string Url { get; set; }


    private string replaceEmptyWithNull(string value)
    {
        return string.IsNullOrEmpty(value) ? null : value;
    }
}