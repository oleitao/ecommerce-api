using Model;

namespace WebApi.Contracts
{
    public interface IShopRepository
    {
        #region Sync
        public IEnumerable<Shop> GetAllShops(bool trackChanges);

        public Shop? GetShop(Guid shopId, bool trackChanges);
        public void CreateShop(Shop shop);
        #endregion

        #region Async

        public Task<IEnumerable<Shop>> GetAllShopsAsync(bool trackChanges);
        public Task<Shop?> GetShopAsync(Guid shopId, bool trackChanges);
        public Task DeleteShop(Shop shop);
        public Task<IEnumerable<Shop>> GetShopByProductIdAsync(Guid productId, bool trackChanges);
        public Task DeleteShopsByProductIdAsync(IEnumerable<Shop> shops);
        public Task UpdateShop(Shop shopEntity);

        #endregion
    }
}
