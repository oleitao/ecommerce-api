namespace WebApi.Models.Users;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebApi.Entities;

public class CreateShopRequest
{    
    [Required]
    public string Name { get; set; }

    [Required]
    public IEnumerable<ShopAvatar> ShopAvatars { get; set; }

    [Required]
    public int Ratings { get; set; }
}