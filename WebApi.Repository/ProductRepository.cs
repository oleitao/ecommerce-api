﻿using Microsoft.EntityFrameworkCore;
using Model;
using System.Collections.Immutable;
using WebApi.Contracts;
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

        public Product? GetProduct(Guid productId, bool trackChanges) =>
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
            return await FindAll(trackChanges).ToListAsync();
        }

        public async Task<IEnumerable<Product?>> GetProductsByCategoryAsync(Guid categoryId, bool trackChanges)
        {
            return FindByCondition(p => p.CategoryId.Equals(categoryId), trackChanges)
            .OrderBy(p => p.Name).ToImmutableList<Product>();
        }

        public async Task<Product?> GetProductAsync(Guid productId, bool trackChanges)
        {
            return await FindByCondition(c => c.Id.Equals(productId), trackChanges).SingleOrDefaultAsync();
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

        public async Task<IEnumerable<Product?>> FilterProductsSortedAsync(ProductParameters productParameters, bool trackChanges)
        {
            return await FindAll(trackChanges)
                .Sort(productParameters.OrderBy)
                .Search(productParameters.SearchTerm)
                .ToListAsync();
        }

        public async Task DeleteCategoryProducts(IEnumerable<Product> productCatogory)
        {
            foreach (var item in productCatogory)
            {
                Delete(item);
            }

            await Task.CompletedTask;
        }

        public async Task DeleteProduct(Product product)
        {
            Delete(product);

            await Task.CompletedTask;
        }

        public async Task UpdateProductAsync(Product productEntity)
        {
            Update(productEntity);

            await Task.CompletedTask;
        }

        public async Task<IEnumerable<Product?>> GetProductsByShopAsync(Guid shopId, bool trackChanges)
        {
            return FindByCondition(p => p.ShopId.Equals(shopId), trackChanges)
            .ToImmutableList<Product>();
        }

        public async Task DeleteShopProducts(IEnumerable<Product> productShop)
        {
            foreach(var item in productShop)
            { 
                Delete(item);
            }

            await Task.CompletedTask;
        }


        #endregion
    }
}
