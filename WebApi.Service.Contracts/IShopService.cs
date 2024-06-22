using Model;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Service.Contracts
{
    public interface IShopService
    {
        #region Sync
        public IEnumerable<Shop> GetAllShops(bool trackChanges);
        public Shop GetShop(Guid id, bool trackChanges);
        public ShopDto CreateShop(ShopForCreationDto shop);
        #endregion

        #region Async
        public Task<IEnumerable<Shop>> GetAllShopsAsync(bool trackChanges);
        public Task<Shop> GetShopAsync(Guid id, bool trackChanges);
        public Task<ShopDto> CreateShopAsync(ShopForCreationDto shop);
        Task UpdateShopAsync(Guid id, ShopForUpdateDto model, bool trackChanges);
        Task DeleteShopAsync(Guid id, bool trackChanges);
        Task DeleteShopByProductIdAsync(Guid productId, bool trackChanges);
        #endregion
    }
}
