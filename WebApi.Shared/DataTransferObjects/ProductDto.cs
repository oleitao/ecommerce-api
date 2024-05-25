using WebApi.Entities.Models;

namespace WebApi.Shared.DataTransferObjects
{
    [Serializable]
    public record ProductDto(Guid Id, Category Category, string Name, string Description, ICollection<ImageUrl> ImageURLs, int Price, int Discount_Price, int Rating, ICollection<Review> Reviews, int Total_Sell, int Stock);
}
