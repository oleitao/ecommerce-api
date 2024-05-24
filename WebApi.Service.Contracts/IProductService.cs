using WebApi.Entities.Models;

namespace WebApi.Service.Contracts
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts(bool trackChanges);
        Product GetProduct(Guid id, bool trackChanges);
        IEnumerable<Product> GetProductsByCategory(Guid categoryId, bool trackChanges);
    }
}
