using Microsoft.EntityFrameworkCore;
using Model;
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
        public ImageUrl GetImageUrl(Guid imageUrlId, bool trackChanges) =>
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
            return FindAll(trackChanges).ToList();
        }

        public Task<ImageUrl> GetImageUrlAsync(Guid imageUrlId, bool trackChanges)
        {
            return FindByCondition(c => c.Id.Equals(imageUrlId), trackChanges).SingleOrDefaultAsync();
        }

        #endregion
    }
}
