namespace WebApi.Service.Contracts
{
    public interface IServiceManager
    {
        ICategoryService CategoryService { get; }
        IImageUrlService ImageUrlService { get; }
        IProductService ProductService { get; }
        IReviewService ReviewService { get; }
        IShopAvatarService ShopAvatarService { get; }
        IShopService ShopService { get; }
        IUserService UserService { get; }
    }
}
