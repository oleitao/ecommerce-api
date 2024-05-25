using AutoMapper;
using System.Linq;
using WebApi.Contracts;
using WebApi.Entities.Exceptions;
using WebApi.Entities.Models;
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

        public ProductDto CreateProductForCategory(Guid categoryId, ProductForCreationDto productForCreationDto, bool trackChanges)
        {
            var category = _repository.Category.GetCategory(categoryId, trackChanges);
            if(category == null)
                throw new ProductNotFoundException(categoryId);

            var productEntity = _mapper.Map<Product>(productForCreationDto);
            productEntity.CategoryId = categoryId;

            var images = _repository.ImageUrl.GetImageUrls(false).ToList();
            List<ImageUrl> onlyNewImages = new List<ImageUrl>();
            if (productEntity.ImageURLs is not null)
            {
                foreach (var image in images)
                {
                    if (productEntity.ImageURLs.Where(c => c.Id == image.Id).FirstOrDefault() != null)
                        onlyNewImages.Add(image);
                }
                
                if (onlyNewImages is not null && onlyNewImages.Count > 0)
                {
                    productEntity.ImageURLs.Clear();
                    productEntity.ImageURLs.Add(new ImageUrl() { Url = string.Empty, PublicUrl = string.Empty });
                }
            }


            _repository.Product.CreateGetProductsByCategory(categoryId, productEntity);
            _repository.Save();

            var productToReturn = _mapper.Map<ProductDto>(productEntity);

            return productToReturn;
        }
    }
}
