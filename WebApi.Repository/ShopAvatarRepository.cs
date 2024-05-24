using WebApi.Contracts;
using WebApi.Entities.Models;

namespace WebApi.Repository
{
    public class ShopAvatarRepository : RepositoryBase<ShopAvatar>, IShopAvatarRepository
    {
        public ShopAvatarRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }

        public IEnumerable<ShopAvatar> GetAllShopAvatars(bool trackChanges) =>
            FindAll(trackChanges).ToList();
    }
}
