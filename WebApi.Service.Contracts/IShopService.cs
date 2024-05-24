using WebApi.Entities.Models;

namespace WebApi.Service.Contracts
{
    public interface IShopService
    {
        IEnumerable<Shop> GetAllShops(bool trackChanges);
        public Shop GetShop(Guid id, bool trackChanges);
    }
}
