using WebApi.Entities.Models;

namespace WebApi.Service.Contracts
{
    public interface IShopAvatarService
    {
        IEnumerable<ShopAvatar> GetAllShopAvatars(bool trackChanges);
        ShopAvatar GetShopAvatar(Guid id, bool trackChanges);
    }
}
