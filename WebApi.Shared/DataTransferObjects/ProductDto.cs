using System.ComponentModel.DataAnnotations;
using WebApi.Entities.Models;

namespace WebApi.Shared.DataTransferObjects
{
    [Serializable]
    public record ProductDto(
        Guid Id, 

        Guid CategoryId,

        [Required(ErrorMessage = "Name name is a required field.")]
        [MaxLength(500, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        string Name,

        [Required(ErrorMessage = "Description name is a required field.")]
        [MaxLength(5000, ErrorMessage = "Maximum length for the Description is 60 characters.")]
        string Description, 

        ICollection<ImageUrl> ImageURLs,

        [Required(ErrorMessage = "Price is a required field.")]
        int Price,

        [Required(ErrorMessage = "Discount Price is a required field.")]
        int Discount_Price,

        [Required(ErrorMessage = "Rating is a required field.")]
        [Range(1, 5)]
        int Rating, 

        ICollection<Review> Reviews,

        [Required(ErrorMessage = "Total Sell is a required field.")]
        int Total_Sell,

        [Required(ErrorMessage = "Stock is a required field.")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        int Stock
    );


    public record ProductForCreationDto(Guid CategoryId, string Name, string Description, ICollection<ImageUrl> ImageURLs, int Price, int Discount_Price, int Rating, ICollection<Review> Reviews, int Total_Sell, int Stock);

    public record ProductForUpdateDto(Guid CategoryId, string Name, string Description, ICollection<ImageUrl> ImageURLs, int Price, int Discount_Price, int Rating, ICollection<Review> Reviews, int Total_Sell, int Stock);
}
