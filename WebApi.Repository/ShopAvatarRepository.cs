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

        #region Sync
        public IEnumerable<ShopAvatar> GetAllShopAvatars(bool trackChanges) =>
            FindAll(trackChanges).ToList();

        public ShopAvatar GetShopAvatar(Guid shopAvatarId, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(shopAvatarId), trackChanges)
            .SingleOrDefault();

        public void CreateShopAvatar(ShopAvatar shopAvatar)
        {
            Create(shopAvatar);
        }

        #endregion

        #region Async

        public async Task<IEnumerable<ShopAvatar>> GetAllShopAvatarsAsync(bool trackChanges)
        {
            return FindAll(trackChanges).ToList();
        }

        public Task<ShopAvatar> GetShopAvatarAsync(Guid shopAvatarId, bool trackChanges)
        {
            return FindByCondition(c => c.Id.Equals(shopAvatarId), trackChanges).SingleOrDefaultAsync();
        }

        public void DeleteShopAvatarAsync(ShopAvatar shopAvatar)
        {
            Delete(shopAvatar);
        }

        #endregion
    }
}
