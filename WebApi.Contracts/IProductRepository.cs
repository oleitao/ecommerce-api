using WebApi.Entities.Models;

namespace WebApi.Contracts
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts(bool trackChanges);
        IEnumerable<Product> GetProductsByCategory(Guid categoryId, bool trackChanges);
        Product GetProduct(Guid productId, bool trackChanges);
    }
}
