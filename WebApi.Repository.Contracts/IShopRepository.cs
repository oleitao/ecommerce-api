using WebApi.Entities.Models;

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

        #endregion
    }
}
