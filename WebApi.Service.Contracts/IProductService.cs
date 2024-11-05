using Model;
using WebApi.Entities.RequestFeatures;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Service.Contracts
{
    public interface IProductService
    {
        public Task<IEnumerable<ProductDto>> GetAllProductsAsync(bool trackChanges);
        public Task<IEnumerable<Product>> GetTopProductsAsync(bool trackChanges);
        public Task<IEnumerable<ProductDto>> FilterProductsSortedAsync(ProductParameters productParameters, bool trackChanges);
        public Task<ProductDto> GetProductAsync(Guid id, bool trackChanges);
        public Task<IEnumerable<ProductDto>> GetProductsByCategoryAsync(Guid categoryId, bool trackChanges);
        public Task<ProductDto> CreateProductAsync(ProductForCreationDto product);
        public Task<ProductDto> CreateProductForCategoryAsync(Guid categoryId, ProductForCreationDto productForCreationDto, bool trackChanges);
        public Task<(ProductForUpdateDto productToPatch, Product productEntity)> GetProductForPatchAsync(Guid categoryId, Guid id, bool catTrackChanges, bool prodTrackChanges);
        public Task SaveChangesForPatchAsync(ProductForUpdateDto productToPatch, Product productEntity);
        public Task UpdateProductAsync(Guid id, ProductForUpdateDto product, bool trackChanges);
        public Task DeleteProductAsync(Guid id, bool trackChanges);
        public Task<IEnumerable<ProductDto>> GetPagingProductsAsync(Guid categoryId, ProductParameters productParameters, bool trackChanges);
        public Task<(IEnumerable<ProductDto> products, MetaData metaData)> GetPagedProductsAsync(Guid categoryId, ProductParameters productParameters, bool trackChanges);
        public Task DeleteProductByCategoryAsync(Guid categoryId);
        public Task DeleteProductByShopAsync(Guid shopId);
        public Task<IEnumerable<Product>> GetShopProductsByShopIdAsync(Guid shopId, bool trackChanges);
    }
}
