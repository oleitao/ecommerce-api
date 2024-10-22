using Microsoft.EntityFrameworkCore;
using Model;
using WebApi.Contracts;

namespace WebApi.Repository
{
    public class ShopAvatarRepository : RepositoryBase<ShopAvatar>, IShopAvatarRepository
    {
        public ShopAvatarRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }

        public async Task<IEnumerable<ShopAvatar>> GetAllShopAvatarsAsync(bool trackChanges)
        {
            return await FindAll(trackChanges).ToListAsync();
        }

        public async Task<ShopAvatar?> GetShopAvatarAsync(Guid shopAvatarId, bool trackChanges)
        {
            return await FindByCondition(c => c.Id.Equals(shopAvatarId), trackChanges).SingleOrDefaultAsync();
        }

        public async Task DeleteShopAvatarAsync(ShopAvatar shopAvatar)
        {
            Delete(shopAvatar);

            await Task.CompletedTask;
        }

        public void CreateShopAvatarAsync(ShopAvatar shopAvatar)
        {
            Create(shopAvatar);
        }
    }
}
