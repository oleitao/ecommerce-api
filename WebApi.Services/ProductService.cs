using AutoMapper;
using Model;
using WebApi.Contracts;
using WebApi.Entities.Exceptions;
using WebApi.Entities.RequestFeatures;
using WebApi.Service.Contracts;
using WebApi.Shared.DataTransferObjects;
using static System.Net.Mime.MediaTypeNames;

namespace WebApi.Services
{
    internal sealed class ProductService : IProductService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        public ProductService(IRepositoryManager repository, ILoggerManager logger, AutoMapper.IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        #region Sync

        public IEnumerable<Product> GetAllProducts(bool trackChanges)
        {
            try
            {
                var products = _repository.Product.GetAllProducts(trackChanges);
                return products;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetAllProducts)} service method {ex}");
                throw;
            }
        }

        public Product GetProduct(Guid id, bool trackChanges)
        {
            try
            {
                var product = _repository.Product.GetProduct(id, trackChanges);
                if (product == null)
                    throw new ProductNotFoundException(id);

                return product;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetProduct)} service method {ex}");
                throw;
            }
        }

        public IEnumerable<Product> GetProductsByCategory(Guid categoryId, bool trackChanges)
        {
            try
            {
                var products = _repository.Product.GetProductsByCategory(categoryId, trackChanges);
                return products;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetProductsByCategory)} service method {ex}");
                throw;
            }
        }

        public ProductDto CreateProduct(ProductForCreationDto product)
        {
            var productEntity = _mapper.Map<Product>(product);

            _repository.Product.CreateProduct(productEntity);
            _repository.Save();

            var productReturn = _mapper.Map<ProductDto>(productEntity);

            return productReturn;
        }


        public void SaveChangesForPatch(ProductForUpdateDto productToPatch, Product productEntity)
        {
            _mapper.Map(productToPatch, productEntity);
            _repository.Save();
        }

        public (ProductForUpdateDto productToPatch, Product productEntity) GetProductForPatch(Guid categoryId, Guid id, bool catTrackChanges, bool prodTrackChanges)
        {
            var category = _repository.Category.GetCategory(categoryId, catTrackChanges);
            if (category == null)
                throw new CategoryNotFoundException(categoryId);

            var productEntity = _repository.Product.GetProduct(categoryId, prodTrackChanges);
            if (productEntity is null)
                throw new ProductNotFoundException(categoryId);

            var productToPatch = _mapper.Map<ProductForUpdateDto>(productEntity);

            return (productToPatch, productEntity);
        }


        #endregion

        #region Async

        public async Task<IEnumerable<Product>> GetAllProductsAsync(bool trackChanges)
        {
            try
            {
                var products = await _repository.Product.GetAllProductsAsync(trackChanges);
                if (products is null)
                    throw new ProductsNotFoundException();

                List<Product> result = new List<Product>();
                foreach (var product in products)
                {
                    result.Add(await GetProductByIdAsync(product.Id, trackChanges));
                }

                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetAllProducts)} service method {ex}");
                throw;
            }
        }

        public async Task<Product> GetProductAsync(Guid id, bool trackChanges)
        {
            try
            {
                var product = await GetProductByIdAsync(id, trackChanges);

                return product;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetProduct)} service method {ex}");
                throw;
            }
        }

        #region Methods

        public async Task<Product> GetProductByIdAsync(Guid productId, bool trackChanges)
        {
            try
            {
                var product = await _repository.Product.GetProductAsync(productId, trackChanges);
                if (product is null)
                    throw new ProductNotFoundException(productId);

                var category = await _repository.Category.GetCategoryAsync(product.CategoryId, trackChanges);
                if (category is null)
                    throw new CategoryNotFoundException(product.CategoryId);

                product.CategoryId = category.Id;

                //image_urls
                var imageUrls = await _repository.ImageUrl.GetImageUrlByPoductIdAsync(productId, trackChanges);
                if (imageUrls is null)
                    throw new ImageUrlsNotFoundException();

                product.Image_Url = new List<ImageUrl>();

                foreach (var image in imageUrls)
                {
                    product.Image_Url.Add(image);
                }

                //reviews
                var reviews = await _repository.Review.GetReviewsByPoductIdAsync(productId, trackChanges);
                if (reviews is null)
                    throw new ReviewsNotFoundException();

                product.Reviews = new List<Review>();

                foreach (var review in reviews)
                {
                    var user = await _repository.User.GetUserAsync(review.UserId, trackChanges);
                    if (reviews is not null)
                    {
                        if(review.User is null) 
                            review.User = new User();
                        
                        product.Reviews.Add(review);
                    }

                }

                //shop
                var shop = await _repository.Shop.GetShopAsync(product.ShopId, trackChanges);
                if (shop is null)
                    throw new ShopNotFoundException(product.ShopId);

                product.Shop = shop;

                //shop avatar
                var shopAvatar = await _repository.ShopAvatar.GetShopAvatarAsync(shop.ShopAvatarId, trackChanges);
                if (shopAvatar is null)
                    throw new ShopAvatarNotFoundException(product.ShopId);

                product.Shop.Shop_avatar = new ShopAvatar();
                product.Shop.Shop_avatar = shopAvatar;

                return product;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetProductByIdAsync)} service method {ex}");
                throw;
            }
        }

        #endregion

        public async Task<IEnumerable<Product>> GetProductsByCategoryAsync(Guid categoryId, bool trackChanges)
        {
            try
            {
                var products = await _repository.Product.GetProductsByCategoryAsync(categoryId, trackChanges);
                return products;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetProductsByCategory)} service method {ex}");
                throw;
            }
        }

        public async Task<ProductDto> CreateProductAsync(ProductForCreationDto productForCreationDto)
        {
            var category = await _repository.Category.GetCategoryByName(productForCreationDto.Category, false);
            if (category is null)
                throw new CategoryNotFoundException();

            try
            {
                var productEntity = _mapper.Map<Product>(productForCreationDto);

                if (category != null)
                    productEntity.CategoryId = category.Id;

                if (productEntity.Id == Guid.Empty)
                    productEntity.Id = Guid.NewGuid();

                ShopAvatar shopAvatar = new ShopAvatar() 
                { 
                    Id= Guid.NewGuid(),
                    Public_id = productForCreationDto.Shop.Shop_avatar.Public_id,
                    Url = productForCreationDto.Shop.Shop_avatar.Url
                };

                _repository.ShopAvatar.CreateShopAvatar(shopAvatar);

                Shop shop = new Shop()
                {
                    Name = productForCreationDto.Shop.Name,
                    Ratings = productForCreationDto.Shop.Ratings,
                    ShopAvatarId = shopAvatar.Id,
                    Id = Guid.NewGuid()
                };

                productEntity.Shop = shop;
                productEntity.ShopId = shop.Id;
                shop.ProductId = productEntity.Id;
                shop.Shop_avatar = shopAvatar;

                _repository.Shop.CreateShop(shop);

                _repository.Product.CreateProduct(productEntity);

                await _repository.SaveAsync();


                var productReturn = _mapper.Map<ProductDto>(new ProductDto(
                    productEntity.Id,
                    productEntity.Name,
                    productEntity.Description,
                    productEntity.Price,
                    productEntity.Discount_price,
                    productEntity.Rating,
                    productEntity.Total_sell,
                    productEntity.Stock,
                    productEntity.CategoryId,
                    productEntity.ShopId,
                    productEntity.Image_Url,
                    productEntity.Reviews,
                    productEntity.Shop));

                return productReturn;
            }
            catch(Exception ex)
            {
                throw new Exception();
            }
        }

        public async Task UpdateProductAsync(Guid id, ProductForUpdateDto productForUpdateDto, bool trackChanges)
        {
            //var productEntity = _mapper.Map<Product>(productForUpdateDto);

            try
            {
                Guid categoryId = Guid.Empty;

                var categoryEntity = await _repository.Category.GetCategoryByName(productForUpdateDto.Category, false);
                if (categoryEntity != null)
                    categoryId = categoryEntity.Id;

                var productEntity = await _repository.Product.GetProductAsync(id, trackChanges);


                //_mapper.Map(productForUpdateDto, productEntity);

                if (productEntity is not null)
                {
                    productEntity.CategoryId = categoryId;
                    productEntity.Name = productForUpdateDto.Name;
                    productEntity.Description = productForUpdateDto.Description;
                    productEntity.Price = productForUpdateDto.Price;
                    productEntity.Discount_price = productEntity.Discount_price;
                    productEntity.Rating = productForUpdateDto.Rating;
                    productEntity.Total_sell = productEntity.Total_sell;
                    productEntity.Stock = productForUpdateDto.Stock;

                    _repository.Product.UpdateProductAsync(productEntity);

                    if (productForUpdateDto.Reviews is not null && productForUpdateDto.Reviews.Count > 0)
                    {
                        foreach (var review in productForUpdateDto.Reviews)
                        {
                            var reviewEntities = await _repository.Review.GetReviewByUserAsync(Guid.Parse(review.User.Id), trackChanges);
                            if (reviewEntities is null)
                                throw new ReviewNotFoundException(id);

                            //_repository.Review.UpdateReviewAsync(reviewEntities);
                        }
                    }

                    if (productForUpdateDto.Image_Url is not null && productForUpdateDto.Image_Url.Count > 0)
                    {
                        foreach (var image in productForUpdateDto.Image_Url)
                        {
                            var imageList = await _repository.ImageUrl.GetImageUrlByPublicIdAsync(image.Public_id, trackChanges);
                            
                            foreach (var imageUrl in imageList)
                            {
                                imageUrl.Url = image.Url;

                                _repository.ImageUrl.UpdateImageUrlAsync(imageUrl);
                            }
                        }
                    }

                    if (productForUpdateDto.Shop is not null)
                    {
                        ShopAvatar shopAvatar = new ShopAvatar()
                        {
                            Id = Guid.NewGuid(),
                            Public_id = productForUpdateDto.Shop.Shop_avatar.Public_id,
                            Url = productForUpdateDto.Shop.Shop_avatar.Url
                        };

                        _repository.ShopAvatar.CreateShopAvatar(shopAvatar);

                        Shop shop = new Shop()
                        {
                            Name = productForUpdateDto.Shop.Name,
                            Ratings = productForUpdateDto.Shop.Ratings,
                            ShopAvatarId = shopAvatar.Id,
                            Id = Guid.NewGuid()
                        };

                        _repository.Shop.CreateShop(shop);
                    }

                    await _repository.SaveAsync();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<ProductDto> CreateProductForCategoryAsync(Guid categoryId, ProductForCreationDto productForCreationDto, bool trackChanges)
        {
            var category = await _repository.Category.GetCategoryAsync(categoryId, trackChanges);
            if (category == null)
                throw new ProductNotFoundException(categoryId);

            var productEntity = _mapper.Map<Product>(productForCreationDto);
            productEntity.CategoryId = categoryId;

            var images = await _repository.ImageUrl.GetImageUrlsAsync(false);
            var productImages = images.Where(x => x.ProductId == productEntity.Id).ToList();


            if (productImages is null)
            {
                /*
                foreach (var image in productForCreationDto.ImageUrls)
                {
                    _repository.Image_Url.CreateImageUrl(new Image_Url()
                    {
                        Id = Guid.NewGuid(),
                        Public_id = image.Public_id,
                        Url = image.Url,
                        ProductId = productEntity.Id
                    });
                }
                */
            }
            else
            {
                /*
                foreach (var image in productForCreationDto.ImageUrls)
                {
                    if (!images.Contains(image))
                    {
                        _repository.Image_Url.CreateImageUrl(new Image_Url()
                        {
                            Id = Guid.NewGuid(),
                            Public_id = image.Public_id,
                            Url = image.Url,
                            ProductId = productEntity.Id
                        });
                    }
                }
                */
            }


            _repository.Product.CreateGetProductsByCategory(categoryId, productEntity);
            await _repository.SaveAsync();

            var productToReturn = _mapper.Map<ProductDto>(productEntity);

            return productToReturn;
        }

        public async Task<(ProductForUpdateDto productToPatch, Product productEntity)> GetProductForPatchAsync(Guid categoryId, Guid id, bool catTrackChanges, bool prodTrackChanges)
        {
            var category = await _repository.Category.GetCategoryAsync(categoryId, catTrackChanges);
            if (category == null)
                throw new CategoryNotFoundException(categoryId);

            var productEntity = await _repository.Product.GetProductAsync(categoryId, prodTrackChanges);
            if (productEntity is null)
                throw new ProductNotFoundException(categoryId);

            var productToPatch = _mapper.Map<ProductForUpdateDto>(productEntity);

            return (productToPatch, productEntity);
        }

        public async Task SaveChangesForPatchAsync(ProductForUpdateDto productToPatch, Product productEntity)
        {
            _mapper.Map(productToPatch, productEntity);
            await _repository.SaveAsync();
        }

        public async Task DeleteProductAsync(Guid id, bool trackChanges)
        {
            var product = await _repository.Product.GetProductAsync(id, trackChanges: trackChanges);
            if (product is null)
                throw new Exception();

            _repository.Product.DeleteProduct(product);
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<ProductDto>> GetPagingProductsAsync(Guid categoryId, ProductParameters productParameters, bool trackChanges)
        {
            if (!productParameters.ValidNameRange)
                throw new MaxNameRangeBadRequestException();

            await CheckIfCategoryExists(categoryId, trackChanges);

            var productFromDb = await _repository.Product.GetPagingProductsAsync(categoryId, productParameters, trackChanges: false);
            var productDto = _mapper.Map<IEnumerable<ProductDto>>(productFromDb);

            return productDto;
        }

        public async Task<(IEnumerable<ProductDto> products, MetaData metaData)> GetPagedProductsAsync(Guid categoryId, ProductParameters productParameters, bool trackChanges)
        {
            await CheckIfCategoryExists(categoryId, trackChanges);
            
            var productsWithMetaData = await _repository.Product.GetPagedProductsAsync(categoryId, productParameters, trackChanges: false);
            var productDto = _mapper.Map<IEnumerable<ProductDto>>(productsWithMetaData);

            return (products: productDto, metaData: productsWithMetaData.MetaData);
        }

        public async Task<IEnumerable<Product>> FilterProductsSortedAsync(ProductParameters productParameters, bool trackChanges)
        {
            try
            {
                var products = await _repository.Product.FilterProductsSortedAsync(productParameters, trackChanges);
                return products;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(FilterProductsSortedAsync)} service method {ex}");
                throw;
            }
        }
        #endregion

        private async Task CheckIfCategoryExists(Guid categoryId, bool trackChanges)
        {
            var result = await _repository.Category.GetCategoryAsync(categoryId, trackChanges);
        }

        public ProductDto CreateProductForCategory(Guid categoryId, ProductForCreationDto productForCreationDto, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteProductByCategoryAsync(Guid categoryId)
        {
            var productCatogory = await _repository.Product.GetProductsByCategoryAsync(categoryId, false);
            if (productCatogory is null)
                throw new Exception();

            _repository.Product.DeleteCategoryProducts(productCatogory);
            await _repository.SaveAsync();
        }
    }
}
