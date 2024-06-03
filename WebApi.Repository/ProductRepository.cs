using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;
using WebApi.Contracts;
using WebApi.Entities.Models;
using WebApi.Entities.RequestFeatures;
using WebApi.Repository.Extensions;

namespace WebApi.Repository
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }

        #region Sync
        public IEnumerable<Product> GetAllProducts(bool trackChanges) =>
            FindAll(trackChanges).ToList();

        public Product GetProduct(Guid productId, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(productId), trackChanges)
            .SingleOrDefault();

        public IEnumerable<Product> GetProductsByCategory(Guid categoryId, bool trackChanges) => 
            FindByCondition(p => p.CategoryId.Equals(categoryId), trackChanges)
            .OrderBy(p => p.Name).ToList();

        public void CreateProduct(Product product)
        {
            Create(product);
        }

        public void CreateGetProductsByCategory(Guid categoryId, Product product)
        {
            product.CategoryId = categoryId;
            Create(product);
        }

        #endregion

        #region Async

        public async Task<IEnumerable<Product>> GetAllProductsAsync(bool trackChanges)
        {
            return FindAll(trackChanges).ToList();
        }

        public async Task<IEnumerable<Product>> GetProductsByCategoryAsync(Guid categoryId, bool trackChanges)
        {
            return FindByCondition(p => p.CategoryId.Equals(categoryId), trackChanges)
            .OrderBy(p => p.Name).ToImmutableList<Product>();
        }

        public Task<Product> GetProductAsync(Guid productId, bool trackChanges)
        {
            return FindByCondition(c => c.Id.Equals(productId), trackChanges).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<Product>> GetPagingProductsAsync(Guid categoryId, ProductParameters productParameters, bool trackChanges)
        {
            return await FindByCondition(e => e.CategoryId.Equals(categoryId), trackChanges)
                .OrderBy(e => e.Name)
                .Skip((productParameters.PageNumber - 1) * productParameters.PageSize)
                .Take(productParameters.PageSize)
                .ToListAsync();
        }

        public async Task<PagedList<Product>> GetPagedProductsAsync(Guid categoryId, ProductParameters productParameters, bool trackChanges)
        {
            var products = await FindByCondition(e => e.CategoryId.Equals(categoryId) && (e.Name.Length >= productParameters.MinName) &&
                (e.Name.Length <= productParameters.MaxName), trackChanges)
                .OrderBy(e => e.Name)
                .Skip((productParameters.PageNumber - 1) * productParameters.PageSize)
                .Take(productParameters.PageSize)
                .ToListAsync();

            var count = await FindByCondition(e => e.CategoryId.Equals(categoryId), trackChanges).CountAsync();

            return PagedList<Product>
                .ToPagedList(products, count, productParameters.PageNumber, productParameters.PageSize);

        }

        public async Task<IEnumerable<Product>> FilterProductsSortedAsync(ProductParameters productParameters, bool trackChanges)
        {
            return FindAll(trackChanges)
                .Sort(productParameters.OrderBy)
                .Search(productParameters.SearchTerm)
                .ToList();
        }

        #endregion
    }
}
