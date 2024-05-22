namespace WebApi.Models.Products;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebApi.Entities;

public class UpdateProductRequest
{
    [Required]
    public string Title { get; set; }


    public string SubTitle { get; set; }


    [Required]
    public string ImageUrl { get; set; }


    [Required]
    public Category Category { get; set; }


    [Required]
    public string Name { get; set; }


    [Required]
    public string Description { get; set; }


    [Required]
    public int Price { get; set; }


    [Required]
    public int Discount_Price { get; set; }


    [Required]
    public int Rating { get; set; }


    [Required]
    public int Total_Sell { get; set; }


    [Required]
    public int Stock { get; set; }


    private string replaceEmptyWithNull(string value)
    {
        return string.IsNullOrEmpty(value) ? null : value;
    }
}