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

        public async Task<ProductDto> CreateProductAsync(ProductForCreationDto product)
        {
            var productEntity = _mapper.Map<Product>(product);

            _repository.Product.CreateProduct(productEntity);
            await _repository.SaveAsync();

            var productReturn = _mapper.Map<ProductDto>(productEntity);

            return productReturn;
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
                foreach (var image in productForCreationDto.ImageUrls)
                {
                    _repository.ImageUrl.CreateImageUrl(new ImageUrl()
                    {
                        Id = Guid.NewGuid(),
                        PublicUrl = image.PublicUrl,
                        Url = image.Url,
                        ProductId = productEntity.Id
                    });
                }                
            }
            else
            {
                foreach (var image in productForCreationDto.ImageUrls)
                {
                    if (!images.Contains(image))
                    {
                        _repository.ImageUrl.CreateImageUrl(new ImageUrl()
                        {
                            Id = Guid.NewGuid(),
                            PublicUrl = image.PublicUrl,
                            Url = image.Url,
                            ProductId = productEntity.Id
                        });
                    }
                }
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

        public async Task UpdateProductAsync(Guid id, ProductForUpdateDto product, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteProductAsync(Guid id, bool trackChanges)
        {
            throw new NotImplementedException();
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
    }
}
