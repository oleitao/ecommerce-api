using WebApi.Contracts;
using WebApi.Service.Contracts;

namespace WebApi.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICategoryService> _categoryService;
        private readonly Lazy<IImageUrlService> _imageUrlService;
        private readonly Lazy<IProductService> _productService;
        private readonly Lazy<IReviewService> _reviewService;
        private readonly Lazy<IShopAvatarService> _shopAvatarService;
        private readonly Lazy<IShopService> _shopService;
        private readonly Lazy<IUserService> _userService;
        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger)
        {
            _categoryService = new Lazy<ICategoryService>(() => new CategoryService(repositoryManager, logger));
            _imageUrlService = new Lazy<IImageUrlService>(() => new ImageUrlService(repositoryManager, logger));
            _productService = new Lazy<IProductService>(() => new ProductService(repositoryManager, logger));
            _reviewService = new Lazy<IReviewService>(() => new ReviewService(repositoryManager, logger));
            _shopService = new Lazy<IShopService>(() => new ShopService(repositoryManager, logger));
            _shopAvatarService = new Lazy<IShopAvatarService>(() => new ShopAvatarService(repositoryManager, logger));
            _userService = new Lazy<IUserService>(() => new UserService(repositoryManager, logger));
        }

        public ICategoryService CategoryService => _categoryService.Value;
        public IImageUrlService ImageUrlService => _imageUrlService.Value;
        public IProductService ProductService => _productService.Value;
        public IReviewService ReviewService => _reviewService.Value;
        public IShopAvatarService ShopAvatarService => _shopAvatarService.Value;
        public IShopService ShopService => _shopService.Value;
        public IUserService UserService => _userService.Value;
    }
}
