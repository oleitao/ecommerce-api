﻿using WebApi.Contracts;
using WebApi.Entities.Models;

namespace WebApi.Repository
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }

        public IEnumerable<Product> GetAllProducts(bool trackChanges) =>
            FindAll(trackChanges).ToList();

        public Product GetProduct(Guid productId, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(productId), trackChanges)
            .SingleOrDefault();

    }
}
