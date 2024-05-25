using WebApi.Entities.Models;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Service.Contracts
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts(bool trackChanges);
        Product GetProduct(Guid id, bool trackChanges);
        IEnumerable<Product> GetProductsByCategory(Guid categoryId, bool trackChanges);
        ProductDto CreateProduct(ProductForCreationDto product);
        ProductDto CreateProductForCategory(Guid categoryId, ProductForCreationDto productForCreationDto, bool trackChanges);
    }
}
