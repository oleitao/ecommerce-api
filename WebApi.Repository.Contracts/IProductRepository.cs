using Model;
using WebApi.Entities.RequestFeatures;

namespace WebApi.Contracts
{
    public interface IProductRepository
    {
        public Task<IEnumerable<Product>> GetAllProductsAsync(bool trackChanges);
        public Task<IEnumerable<Product>> GetTopProductsAsync(bool trackChanges);
        public Task<IEnumerable<Product?>> GetProductsByCategoryAsync(Guid categoryId, bool trackChanges);
        public Task<Product?> GetProductAsync(Guid productId, bool trackChanges);
        public Task<IEnumerable<Product>> GetPagingProductsAsync(Guid companyId, ProductParameters productParameters, bool trackChanges);
        public Task<PagedList<Product>> GetPagedProductsAsync(Guid companyId, ProductParameters productParameters, bool trackChanges);
        public Task<IEnumerable<Product?>> FilterProductsSortedAsync(ProductParameters productParameters, bool trackChanges);
        public Task DeleteCategoryProducts(IEnumerable<Product> productCatogory);
        public Task DeleteProduct(Product product);
        public Task UpdateProductAsync(Product productEntity);
        public Task<IEnumerable<Product?>> GetProductsByShopAsync(Guid shopId, bool trackChanges);
        public Task DeleteShopProducts(IEnumerable<Product> productShop);
        public void CreateProductAsync(Product productEntity);
        public void CreateGetProductsByCategory(Guid categoryId, Product productEntity);
    }
}
