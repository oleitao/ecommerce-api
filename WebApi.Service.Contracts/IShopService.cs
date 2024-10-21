using Model;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Service.Contracts
{
    public interface IShopService
    {
        public Task<IEnumerable<ShopDto>> GetAllShopsAsync(bool trackChanges);
        public Task<ShopDto> GetShopAsync(Guid id, bool trackChanges);
        public Task<ShopDto> CreateShopAsync(ShopForCreationDto shop);
        public Task UpdateShopAsync(Guid id, ShopForUpdateDto model, bool trackChanges);
        public Task DeleteShopAsync(Guid id, bool trackChanges);
        public Task DeleteShopByProductIdAsync(Guid productId, bool trackChanges);
    }
}
