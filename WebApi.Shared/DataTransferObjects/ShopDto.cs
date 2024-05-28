using WebApi.Entities.Models;

namespace WebApi.Shared.DataTransferObjects
{
    [Serializable]
    public record ShopDto(Guid Id, Product Product, string Name, ShopAvatar ShopAvatars, int Ratings);


    public record ShopForCreationDto(Product Product, string Name, ShopAvatar ShopAvatars, int Ratings);

    public record ShopForUpdateDto(Product Product, string Name, ShopAvatar ShopAvatars, int Ratings);
}
