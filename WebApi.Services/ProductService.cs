using WebApi.Contracts;
using WebApi.Entities.Exceptions;
using WebApi.Entities.Models;
using WebApi.Service.Contracts;

namespace WebApi.Services
{
    internal sealed class ProductService : IProductService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public ProductService(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
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
    }
}
