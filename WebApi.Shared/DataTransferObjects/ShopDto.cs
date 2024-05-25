using WebApi.Entities.Models;

namespace WebApi.Shared.DataTransferObjects
{
    [Serializable]
    public record ShopDto(Guid Id, Product Product, string Name, ShopAvatar ShopAvatars, int Ratings);
}
