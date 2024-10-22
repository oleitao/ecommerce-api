using Microsoft.EntityFrameworkCore;
using Model;
using WebApi.Contracts;

namespace WebApi.Repository
{
    public class ShopRepository : RepositoryBase<Shop>, IShopRepository
    {
        public ShopRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }

        public async Task<IEnumerable<Shop>> GetAllShopsAsync(bool trackChanges)
        {
            return await FindAll(trackChanges).ToListAsync();
        }

        public async Task<Shop?> GetShopAsync(Guid shopId, bool trackChanges)
        {
            return await FindByCondition(c => c.Id.Equals(shopId), trackChanges).SingleOrDefaultAsync();            
        }

        public async Task DeleteShop(Shop shop)
        {
            Delete(shop);

            await Task.CompletedTask;
        }

        public async Task<IEnumerable<Shop>> GetShopByProductIdAsync(Guid productId, bool trackChanges)
        {
            return await FindByCondition(c => c.ProductId.Equals(productId), trackChanges).ToListAsync();
        }

        public async Task DeleteShopsByProductIdAsync(IEnumerable<Shop> shops)
        {
            foreach (var shop in shops) 
            {
                Delete(shop);
            }

            await Task.CompletedTask;
        }

        public async Task UpdateShop(Shop shopEntity)
        {
            Update(shopEntity);

            await Task.CompletedTask;
        }

        public void CreateShopAsync(Shop shop)
        {
            Create(shop);
        }
    }
}
