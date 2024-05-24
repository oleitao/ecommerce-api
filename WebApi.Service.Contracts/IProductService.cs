using WebApi.Entities.Models;

namespace WebApi.Service.Contracts
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts(bool trackChanges);
    }
}
