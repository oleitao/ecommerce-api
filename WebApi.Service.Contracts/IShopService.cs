using Model;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Service.Contracts
{
    public interface IShopService
    {
        public Task<IEnumerable<Shop>> GetAllShopsAsync(bool trackChanges);
        public Task<Shop> GetShopAsync(Guid id, bool trackChanges);
        public Task<Shop> GetShopByIdAsync(Guid id, bool trackChanges);
        public Task<List<ShopDto>> GetShopByProductIdAsync(Guid productId, bool trackChanges);
        public Task<ShopDto> CreateShopAsync(SellerShopCreationDto shop);
        public Task UpdateShopAsync(Guid id, ShopForUpdateDto model, bool trackChanges);
        public Task DeleteShopAsync(Guid id, bool trackChanges);
        public Task DeleteShopByProductIdAsync(Guid productId, bool trackChanges);
    }
}
