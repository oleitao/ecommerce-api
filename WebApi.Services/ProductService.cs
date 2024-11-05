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
        private readonly IMapper _mapper;
        public ProductService(IRepositoryManager repository, AutoMapper.IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDto>> GetAllProductsAsync(bool trackChanges)
        {
            try
            {
                var productsEntity = await _repository.Product.GetAllProductsAsync(trackChanges);
                if (productsEntity is null)
                    throw new ProductsNotFoundException();

                List<ProductDto> returnList = new List<ProductDto>();
                foreach (var productEntity in productsEntity)
                {
                    //var product = await GetProductByIdAsync(product.Id, trackChanges);
                    var returnProduct = _mapper.Map<ProductDto>(productEntity);
                    returnList.Add(returnProduct);
                }

                return returnList;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(GetAllProductsAsync)} : {ex}");
            }
        }

        public async Task<IEnumerable<Product>> GetTopProductsAsync(bool trackChanges)
        {
            try
            {
                var products = await _repository.Product.GetTopProductsAsync(trackChanges);
                if (products is null)
                    throw new ProductsNotFoundException();

                foreach (var product in products)
                {
                    if(product.Image_Url is null)
                        product.Image_Url = new List<ImageUrl>();

                    var images = await _repository.ImageUrl.GetImageUrlByPublicIdAsync(product.Id.ToString(), false);
                    if (images is null)
                        throw new ImageUrlsNotFoundException();

                    product.Image_Url = images.ToList();

                    if (product.Shop is null)
                        product.Shop = new Shop();

                    var shop = await _repository.Shop.GetShopByProductIdAsync(product.Id, false);
                    if (shop is null)
                        throw new ShopNotFoundException();

                    product.Shop = shop.FirstOrDefault();
                }

                return products;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(GetTopProductsAsync)} : {ex}");
            }
        }

        public async Task<ProductDto> GetProductAsync(Guid id, bool trackChanges)
        {
            try
            {
                var productEntity = await GetProductByIdAsync(id, trackChanges);
                if (productEntity is null)
                    throw new ProductNotFoundException(id);

                var returnProduct = _mapper.Map<ProductDto>(productEntity);

                return returnProduct;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(GetProductAsync)} : {ex}");
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
                var shopAvatar = await _repository.ShopAvatar.GetShopAvatarAsync(shop.Shop_avatarId, trackChanges);
                if (shopAvatar is null)
                    throw new ShopAvatarNotFoundException(product.ShopId);

                product.Shop.Shop_avatar = new ShopAvatar();
                product.Shop.Shop_avatar = shopAvatar;

                return product;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(GetProductByIdAsync)} : {ex}");
            }
        }

        #endregion

        public async Task<IEnumerable<ProductDto>> GetProductsByCategoryAsync(Guid categoryId, bool trackChanges)
        {
            try
            {
                var productsEntity = await _repository.Product.GetProductsByCategoryAsync(categoryId, trackChanges);

                List<ProductDto> returnProducts = new List<ProductDto>();

                foreach (var product in productsEntity)
                {
                    var returnProduct = _mapper.Map<ProductDto>(product);
                    returnProducts.Add(returnProduct);
                }

                return returnProducts;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(GetProductsByCategoryAsync)} : {ex}");
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

                _repository.ShopAvatar.CreateShopAvatarAsync(shopAvatar);

                Shop shop = new Shop()
                {
                    Name = productForCreationDto.Shop.Name,
                    Ratings = productForCreationDto.Shop.Ratings,
                    Shop_avatarId = shopAvatar.Id,
                    Id = Guid.NewGuid()
                };

                productEntity.Shop = shop;
                productEntity.ShopId = shop.Id;
                shop.Shop_avatar = shopAvatar;

                _repository.Shop.CreateShopAsync(shop);

                _repository.Product.CreateProductAsync(productEntity);

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
                throw new Exception($"{nameof(CreateProductAsync)} : {ex}");
            }
        }

        public async Task UpdateProductAsync(Guid id, ProductForUpdateDto productForUpdateDto, bool trackChanges)
        {
            //var product = _mapper.Map<Product>(productForUpdateDto);

            try
            {
                Guid categoryId = Guid.Empty;

                var categoryEntity = await _repository.Category.GetCategoryByName(productForUpdateDto.Category, false);
                if (categoryEntity != null)
                    categoryId = categoryEntity.Id;

                var productEntity = await _repository.Product.GetProductAsync(id, trackChanges);


                //_mapper.Map(productForUpdateDto, product);

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

                        _repository.ShopAvatar.CreateShopAvatarAsync(shopAvatar);

                        Shop shop = new Shop()
                        {
                            Name = productForUpdateDto.Shop.Name,
                            Ratings = productForUpdateDto.Shop.Ratings,
                            Shop_avatarId = shopAvatar.Id,
                            Id = Guid.NewGuid()
                        };

                        _repository.Shop.CreateShopAsync(shop);
                    }

                    await _repository.SaveAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(UpdateProductAsync)} : {ex}");
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
                        ProductId = product.Id
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
                            ProductId = product.Id
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

        public async Task<IEnumerable<ProductDto>> FilterProductsSortedAsync(ProductParameters productParameters, bool trackChanges)
        {
            try
            {
                var productsEntity = await _repository.Product.FilterProductsSortedAsync(productParameters, trackChanges);

                List<ProductDto> returnList = new List<ProductDto>();
                foreach (var product in productsEntity)
                {
                    var returnProduct = _mapper.Map<ProductDto>(product);
                    returnList.Add(returnProduct);
                }

                return returnList;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(FilterProductsSortedAsync)} : {ex}");
            }
        }

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

        public async Task DeleteProductByShopAsync(Guid shopId)
        {
            var productShops = await _repository.Product.GetProductsByShopAsync(shopId, false);
            if (productShops is null)
                throw new Exception();

            _repository.Product.DeleteShopProducts(productShops);
            await _repository.SaveAsync();
        }


        public async Task<IEnumerable<Product>> GetShopProductsByShopIdAsync(Guid shopId, bool trackChanges)
        {
            var shop = await _repository.Shop.GetAllShopsAsync(trackChanges);
            if(shop is null)
                throw new Exception();

            var shopItem = shop.Where(c => c.UserId == shopId).FirstOrDefault();
            if(shopItem is null)
                throw new Exception();

            var productShops = await _repository.Product.GetAllProductsAsync(trackChanges);
            if (productShops is null)
                throw new Exception();

            return productShops.Where(c => c.ShopId == shopItem.Id).ToList();
        }
    }
}
