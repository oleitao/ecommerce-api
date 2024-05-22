namespace WebApi.Models.Users;

using System;
using System.ComponentModel.DataAnnotations;
using WebApi.Entities;

public class CreateImageURLRequest
{
    [Required]
    public int ProductId { get; set; }

    [Required]
    public string PublicUrl { get; set; }

    [Required]
    public string Url { get; set; }
}