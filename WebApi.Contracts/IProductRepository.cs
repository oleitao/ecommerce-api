using WebApi.Entities.Models;

namespace WebApi.Contracts
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts(bool trackChanges);
    }
}
