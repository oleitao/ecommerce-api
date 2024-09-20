using Model;

namespace WebApi.Contracts
{
    public interface IShopAvatarRepository
    {
        #region Sync
        IEnumerable<ShopAvatar> GetAllShopAvatars(bool trackChanges);
        ShopAvatar? GetShopAvatar(Guid shopAvatarId, bool trackChanges);
        void CreateShopAvatar(ShopAvatar shopAvatar);
        #endregion

        #region Async

        public Task<IEnumerable<ShopAvatar>> GetAllShopAvatarsAsync(bool trackChanges);
        public Task<ShopAvatar?> GetShopAvatarAsync(Guid shopAvatarId, bool trackChanges);
        public Task DeleteShopAvatarAsync(ShopAvatar shopAvatar);

        #endregion
    }
}
