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

        Task<IEnumerable<ShopAvatar>> GetAllShopAvatarsAsync(bool trackChanges);
        Task<ShopAvatar?> GetShopAvatarAsync(Guid shopAvatarId, bool trackChanges);
        Task DeleteShopAvatarAsync(ShopAvatar shopAvatar);

        #endregion
    }
}
