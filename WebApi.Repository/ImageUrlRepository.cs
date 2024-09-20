using Microsoft.EntityFrameworkCore;
using Model;
using System;
using WebApi.Contracts;

namespace WebApi.Repository
{
    public class ImageUrlRepository : RepositoryBase<ImageUrl>, IImageUrlRepository
    {
        public ImageUrlRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }

        #region Sync
        public ImageUrl? GetImageUrl(Guid imageUrlId, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(imageUrlId), trackChanges)
            .SingleOrDefault();

        public IEnumerable<ImageUrl> GetImageUrls(bool trackChnages) =>
            FindAll(trackChnages).ToList();

        public void CreateImageUrl(ImageUrl imageUrl)
        {
            Create(imageUrl);
        }

        public void DeleteImageUrl(ImageUrl imageUrl)
        {
            Delete(imageUrl);
        }

        #endregion

        #region Async

        public async Task<IEnumerable<ImageUrl>> GetImageUrlsAsync(bool trackChanges)
        {
            return await FindAll(trackChanges).ToListAsync();
        }

        public async Task<ImageUrl?> GetImageUrlAsync(Guid imageUrlId, bool trackChanges)
        {
            return await FindByCondition(c => c.Id.Equals(imageUrlId), trackChanges).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<ImageUrl>> GetImageUrlByPublicIdAndUrlAsync(string public_id, string url, bool trackChanges)
        {
            return await FindByCondition(c => c.Public_id.Equals(public_id) && c.Url.Equals(url), trackChanges).ToListAsync();
        }

        public void UpdateImageUrlAsync(ImageUrl imageUrl)
        {
            Update(imageUrl);
        }

        public async Task<IEnumerable<ImageUrl>> GetImageUrlByPublicIdAsync(string public_id, bool trackChanges)
        {
            return await FindByCondition(c => c.Public_id.Equals(public_id), trackChanges).ToListAsync();
        }

        public async Task<IEnumerable<ImageUrl>> GetImageUrlByPoductIdAsync(Guid productId, bool trackChanges)
        {
            return await FindByCondition(c => c.ProductId.Equals(productId), trackChanges).ToListAsync();
        }

        public void DeleteImageUrlProducts(IEnumerable<ImageUrl> imageUrls)
        {
            foreach (var imageUrl in imageUrls) {
                Delete(imageUrl);
            }
        }

        #endregion
    }
}
