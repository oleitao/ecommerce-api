using Model;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Shared.DataTransferObjects
{
    [Serializable]
    public record ProductDto(
        Guid Id,

        [Required(ErrorMessage = "Name name is a required field.")]
        [MaxLength(500, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        string Name,

        [Required(ErrorMessage = "Subject name is a required field.")]
        [MaxLength(5000, ErrorMessage = "Maximum length for the Subject is 60 characters.")]
        string Description,

        [Required(ErrorMessage = "Price is a required field.")]
        int Price,

        [Required(ErrorMessage = "Discount Price is a required field.")]
        int Discount_price,

        [Required(ErrorMessage = "Rating is a required field.")]
        [Range(1, 5)]
        double Rating,

        [Required(ErrorMessage = "Total Sell is a required field.")]
        int Total_sell,

        [Required(ErrorMessage = "Stock is a required field.")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        int Stock,

        Guid CategoryId,

        Guid ShopId,

        ICollection<ImageUrl>? Image_Url,

        ICollection<Review>? Reviews,

        Shop? Shop
    );


    public record ProductForCreationDto
    (
        string Category,
        string Name,
        string Description,
        int Price,
        int Discount_price,
        double Rating,
        int Total_sell,
        int Stock,
        ICollection<ImageUrlForCreationDto>? Image_Url,
        ICollection<ReviewForCreationDto>? Reviews,
        ShopForCreationDto? Shop
    );

    public record ProductForUpdateDto
    (
        string Category,
        string Name, 
        string Description,
        int Price,
        int Discount_price,
        int Rating,
        int Total_sell,
        int Stock,
        ICollection<ImageUrlForUpdateDto> Image_Url,
        ICollection<ReviewForUpdateDto> Reviews,
        ShopForCreationDto Shop        
    );
}
