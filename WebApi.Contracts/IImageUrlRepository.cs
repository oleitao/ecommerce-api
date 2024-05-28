using WebApi.Entities.Models;

namespace WebApi.Contracts
{
    public interface IImageUrlRepository
    {
        IEnumerable<ImageUrl> GetImageUrls(bool trackChanges);
        ImageUrl GetImageUrl(Guid imageUrlId, bool trackChanges);
        void CreateImageUrl(ImageUrl imageUrl);
        void DeleteImageUrl(ImageUrl id);
    }
}
