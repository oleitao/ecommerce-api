using AutoMapper;
using Model;
using WebApi.Contracts;
using WebApi.Entities.Exceptions;
using WebApi.Entities.RequestFeatures;
using WebApi.Service.Contracts;
using WebApi.Shared.DataTransferObjects;

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
                return products;
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
                var product = await _repository.Product.GetProductAsync(id, trackChanges);
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
            var productEntity = _mapper.Map<Product>(productForCreationDto);

            if(productEntity.Id == Guid.Empty)
                productEntity.Id = Guid.NewGuid();


            try
            {
                var category = await _repository.Category.GetCategoryByName(productForCreationDto.Category, false);
                if (category != null)
                    productEntity.CategoryId = category.Id;


                _repository.Product.CreateProduct(productEntity);

                if (productForCreationDto.Reviews is not null && productForCreationDto.Reviews.Count > 0)
                {
                    foreach (var review in productForCreationDto.Reviews)
                    {
                        _repository.Review.CreateReview(new Review()
                        {
                            UserId = Guid.NewGuid(),
                            Comment = review.Comment,
                            ProductId = productEntity.Id,
                            Rating = review.Rating
                        });
                    }
                }

                if (productForCreationDto.Image_Url is not null && productForCreationDto.Image_Url.Count > 0)
                {
                    foreach (var image in productForCreationDto.Image_Url)
                    {
                        _repository.ImageUrl.CreateImageUrl(new ImageUrl()
                        {
                            Id = Guid.NewGuid(),
                            ProductId = productEntity.Id,
                            PublicId = image.Public_id,
                            Url = image.Url
                        });
                    }
                }

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

                shopAvatar.ShopId = shop.Id;
                
                _repository.Shop.CreateShop(shop);

                await _repository.SaveAsync();
            }
            catch (Exception ex)
            {
                throw;
            }

            var productReturn = _mapper.Map<ProductDto>(productEntity);

            return productReturn;
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
                    productEntity.DiscountPrice = productEntity.DiscountPrice;
                    productEntity.Rating = productForUpdateDto.Rating;
                    productEntity.TotalSell = productEntity.TotalSell;
                    productEntity.Stock = productForUpdateDto.Stock;

                    _repository.Product.UpdateProductAsync(productEntity);

                    if (productForUpdateDto.Reviews is not null && productForUpdateDto.Reviews.Count > 0)
                    {
                        foreach (var review in productForUpdateDto.Reviews)
                        {
                            var reviewEntities = await _repository.Review.GetReviewByUserAsync(Guid.Parse(review.User.Id), trackChanges);
                            if (reviewEntities is null)
                                throw new ReviewNotFoundException(id);

                            _repository.Review.UpdateReviewAsync(reviewEntities);
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

                        shopAvatar.ShopId = shop.Id;

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
                    _repository.ImageUrl.CreateImageUrl(new ImageUrl()
                    {
                        Id = Guid.NewGuid(),
                        PublicId = image.PublicId,
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
                        _repository.ImageUrl.CreateImageUrl(new ImageUrl()
                        {
                            Id = Guid.NewGuid(),
                            PublicId = image.PublicId,
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
