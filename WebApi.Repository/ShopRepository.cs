﻿using WebApi.Contracts;
using WebApi.Entities.Models;

namespace WebApi.Repository
{
    public class ShopRepository : RepositoryBase<Shop>, IShopRepository
    {
        public ShopRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }
    }
}