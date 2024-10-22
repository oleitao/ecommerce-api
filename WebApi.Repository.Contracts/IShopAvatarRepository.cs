using Model;

namespace WebApi.Contracts
{
    public interface IShopAvatarRepository
    {
        public Task<IEnumerable<ShopAvatar>> GetAllShopAvatarsAsync(bool trackChanges);
        public Task<ShopAvatar?> GetShopAvatarAsync(Guid shopAvatarId, bool trackChanges);
        public Task DeleteShopAvatarAsync(ShopAvatar shopAvatar);
        public void CreateShopAvatarAsync(ShopAvatar shopAvatar);
    }
}
