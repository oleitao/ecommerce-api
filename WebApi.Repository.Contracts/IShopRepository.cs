using Model;

namespace WebApi.Contracts
{
    public interface IShopRepository
    {
        #region Sync
        IEnumerable<Shop> GetAllShops(bool trackChanges);

        Shop GetShop(Guid shopId, bool trackChanges);
        void CreateShop(Shop shop);
        #endregion

        #region Async

        Task<IEnumerable<Shop>> GetAllShopsAsync(bool trackChanges);

        Task<Shop> GetShopAsync(Guid shopId, bool trackChanges);
        void DeleteShop(Shop shop);
        Task<IEnumerable<Shop>> GetShopByProductIdAsync(Guid productId, bool trackChanges);
        void DeleteShopsByProductIdAsync(IEnumerable<Shop> shops);
        void UpdateShop(Shop shopEntity);

        #endregion
    }
}
