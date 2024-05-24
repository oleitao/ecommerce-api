﻿using WebApi.Contracts;
using WebApi.Entities.Models;

namespace WebApi.Repository
{
    public class ImageUrlRepository : RepositoryBase<ImageUrl>, IImageUrlRepository
    {
        public ImageUrlRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }

        public IEnumerable<ImageUrl> GetImageUrls(bool trackChnages) =>
            FindAll(trackChnages).ToList();
    }
}
