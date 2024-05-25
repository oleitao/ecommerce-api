using WebApi.Entities.Models;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Service.Contracts
{
    public interface IShopService
    {
        IEnumerable<Shop> GetAllShops(bool trackChanges);
        public Shop GetShop(Guid id, bool trackChanges);
        ShopDto CreateShop(ShopForCreationDto shop);
    }
}
