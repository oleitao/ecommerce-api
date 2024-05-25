using WebApi.Entities.Models;

namespace WebApi.Contracts
{
    public interface IShopAvatarRepository
    {
        IEnumerable<ShopAvatar> GetAllShopAvatars(bool trackChanges);
        ShopAvatar GetShopAvatar(Guid shopAvatarId, bool trackChanges);
        void CreateShopAvatar(ShopAvatar shopAvatar);
    }
}
