using WebApi.Entities.Models;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Service.Contracts
{
    public interface IShopAvatarService
    {
        IEnumerable<ShopAvatar> GetAllShopAvatars(bool trackChanges);
        ShopAvatar GetShopAvatar(Guid id, bool trackChanges);
        ShopAvatarDto CreateShopAvatar(ShopAvatarForCreationDto shopAvatar);
    }
}
