using WebApi.Entities.Models;
using WebApi.Entities.RequestFeatures;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Service.Contracts
{
    public interface IProductService
    {
        #region Sync
        public IEnumerable<Product> GetAllProducts(bool trackChanges);
        public Product GetProduct(Guid id, bool trackChanges);
        public IEnumerable<Product> GetProductsByCategory(Guid categoryId, bool trackChanges);
        public ProductDto CreateProduct(ProductForCreationDto product);
        public ProductDto CreateProductForCategory(Guid categoryId, ProductForCreationDto productForCreationDto, bool trackChanges);
        public (ProductForUpdateDto productToPatch, Product productEntity) GetProductForPatch(Guid categoryId, Guid id, bool catTrackChanges, bool prodTrackChanges);
        public void SaveChangesForPatch(ProductForUpdateDto productToPatch, Product productEntity);
        #endregion

        #region Async
        public Task<IEnumerable<Product>> GetAllProductsAsync(bool trackChanges);
        public Task<Product> GetProductAsync(Guid id, bool trackChanges);
        public Task<IEnumerable<Product>> GetProductsByCategoryAsync(Guid categoryId, bool trackChanges);
        public Task<ProductDto> CreateProductAsync(ProductForCreationDto product);
        public Task<ProductDto> CreateProductForCategoryAsync(Guid categoryId, ProductForCreationDto productForCreationDto, bool trackChanges);
        public Task<(ProductForUpdateDto productToPatch, Product productEntity)> GetProductForPatchAsync(Guid categoryId, Guid id, bool catTrackChanges, bool prodTrackChanges);
        public Task SaveChangesForPatchAsync(ProductForUpdateDto productToPatch, Product productEntity);
        Task UpdateProductAsync(Guid id, ProductForUpdateDto product, bool trackChanges);
        Task DeleteProductAsync(Guid id, bool trackChanges);
        Task<IEnumerable<ProductDto>> GetPagingProductsAsync(Guid categoryId, ProductParameters productParameters, bool trackChanges);
        Task<(IEnumerable<ProductDto> products, MetaData metaData)> GetPagedProductsAsync(Guid categoryId, ProductParameters productParameters, bool trackChanges);

        #endregion
    }
}
