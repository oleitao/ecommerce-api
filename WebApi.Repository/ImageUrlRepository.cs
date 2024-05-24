using WebApi.Contracts;
using WebApi.Entities.Models;

namespace WebApi.Repository
{
    public class ImageUrlRepository : RepositoryBase<ImageUrl>, IImageUrlRepository
    {
        public ImageUrlRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }

        public ImageUrl GetImageUrl(Guid imageUrlId, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(imageUrlId), trackChanges)
            .SingleOrDefault();

        public IEnumerable<ImageUrl> GetImageUrls(bool trackChnages) =>
            FindAll(trackChnages).ToList();
    }
}
