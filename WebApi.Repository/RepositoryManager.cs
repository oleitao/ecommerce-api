﻿using WebApi.Contracts;

namespace WebApi.Repository
{
    public sealed class RepositoryManager : IRepositoryManager 
    { 
        private readonly RepositoryContext _repositoryContext;
        
        private readonly Lazy<ICategoryRepository> _categoryRepository;
        private readonly Lazy<IImageUrlRepository> _imageUrlRepository;
        private readonly Lazy<IProductRepository> _productRepository;
        private readonly Lazy<IReviewRepository> _reviewRepository;
        private readonly Lazy<IShopAvatarRepository> _shopAvatarRepository;
        private readonly Lazy<IShopRepository> _shopRepository;
        private readonly Lazy<IUserRepository> _userRepository;

        public RepositoryManager(RepositoryContext repositoryContext) 
        { 
            _repositoryContext = repositoryContext;
            
            _categoryRepository = new Lazy<ICategoryRepository>(() => new CategoryRepository(repositoryContext));
            _imageUrlRepository = new Lazy<IImageUrlRepository>(() => new ImageUrlRepository(repositoryContext));
            _productRepository = new Lazy<IProductRepository>(() => new ProductRepository(repositoryContext));
            _reviewRepository = new Lazy<IReviewRepository>(() => new ReviewRepository(repositoryContext));
            _shopAvatarRepository = new Lazy<IShopAvatarRepository>(() => new ShopAvatarRepository(repositoryContext));
            _shopRepository = new Lazy<IShopRepository>(() => new ShopRepository(repositoryContext));
            _userRepository = new Lazy<IUserRepository>(() => new UserRepository(repositoryContext));
        } 
        
        public ICategoryRepository Category => _categoryRepository.Value;

        public IImageUrlRepository ImageUrl => _imageUrlRepository.Value;

        public IProductRepository Product => _productRepository.Value;

        public IReviewRepository Review => _reviewRepository.Value;

        public IShopAvatarRepository ShopAvatar => _shopAvatarRepository.Value;

        public IShopRepository Shop => _shopRepository.Value;

        public IUserRepository User => _userRepository.Value;

        public void Save() => _repositoryContext.SaveChanges();

        public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();
    }
}
