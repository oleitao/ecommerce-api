namespace WebApi.Service.Contracts
{
    public interface IServiceManager
    {
        ICategoryService CategoryService { get; }
        IInboxService InboxService { get; }
        IImageUrlService ImageUrlService { get; }
        IProductService ProductService { get; }
        IReviewService ReviewService { get; }
        IShopAvatarService ShopAvatarService { get; }
        IShopService ShopService { get; }
        IUserService UserService { get; }
        IOrderService OrderService { get; }
        IOrderStatusService OrderStatusService { get; }
        IAuthenticationService AuthenticationService { get; }
    }
}
