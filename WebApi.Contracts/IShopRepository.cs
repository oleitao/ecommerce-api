using WebApi.Entities.Models;

namespace WebApi.Contracts
{
    public interface IShopRepository
    {
        IEnumerable<Shop> GetAllShops(bool trackChanges);

        Shop GetShop(Guid shopId, bool trackChanges);
    }
}
