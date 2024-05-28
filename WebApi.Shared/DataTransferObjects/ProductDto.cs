using WebApi.Entities.Models;

namespace WebApi.Shared.DataTransferObjects
{
    [Serializable]
    public record ProductDto(Guid Id, Guid CategoryId, string Name, string Description, ICollection<ImageUrl> ImageURLs, int Price, int Discount_Price, int Rating, ICollection<Review> Reviews, int Total_Sell, int Stock);


    public record ProductForCreationDto(Guid CategoryId, string Name, string Description, ICollection<ImageUrl> ImageURLs, int Price, int Discount_Price, int Rating, ICollection<Review> Reviews, int Total_Sell, int Stock);

    public record ProductForUpdateDto(Guid CategoryId, string Name, string Description, ICollection<ImageUrl> ImageURLs, int Price, int Discount_Price, int Rating, ICollection<Review> Reviews, int Total_Sell, int Stock);
}
