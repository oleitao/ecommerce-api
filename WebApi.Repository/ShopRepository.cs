using WebApi.Contracts;
using WebApi.Entities.Models;

namespace WebApi.Repository
{
    public class ShopRepository : RepositoryBase<Shop>, IShopRepository
    {
        public ShopRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }

        public IEnumerable<Shop> GetAllShops(bool trackChanges) =>
            FindAll(trackChanges).ToList();

        public Shop GetShop(Guid shopId, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(shopId), trackChanges)
            .SingleOrDefault();

        public void CreateShop(Shop shop)
        {
            Create(shop);
        }
    }
}
