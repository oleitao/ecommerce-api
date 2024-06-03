using WebApi.Entities.Models;
using WebApi.Entities.RequestFeatures;

namespace WebApi.Contracts
{
    public interface IProductRepository
    {
        #region Sync
        IEnumerable<Product> GetAllProducts(bool trackChanges);
        IEnumerable<Product> GetProductsByCategory(Guid categoryId, bool trackChanges);
        Product GetProduct(Guid productId, bool trackChanges);
        void CreateProduct(Product product);
        void CreateGetProductsByCategory(Guid categoryId, Product product);
        #endregion

        #region Async
        Task<IEnumerable<Product>> GetAllProductsAsync(bool trackChanges);
        Task<IEnumerable<Product>> GetProductsByCategoryAsync(Guid categoryId, bool trackChanges);
        Task<Product> GetProductAsync(Guid productId, bool trackChanges);
        Task<IEnumerable<Product>> GetPagingProductsAsync(Guid companyId, ProductParameters productParameters, bool trackChanges);
        Task<PagedList<Product>> GetPagedProductsAsync(Guid companyId, ProductParameters productParameters, bool trackChanges);
        Task<IEnumerable<Product>> FilterProductsSortedAsync(ProductParameters productParameters, bool trackChanges);

        #endregion
    }
}
