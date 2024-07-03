using Model;
using WebApi.Contracts;

namespace WebApi.Contracts
{
    public interface IRepositoryManager
    {
        ICategoryRepository Category { get; }

        IImageUrlRepository ImageUrl { get; }

        IProductRepository Product { get; }

        IReviewRepository Review { get; }

        IShopAvatarRepository ShopAvatar { get; }

        IShopRepository Shop { get; }

        IUserRepository User { get; }

        IEmailRepository Email { get; }
        void Save();
        Task SaveAsync();
    }
}
