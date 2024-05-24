using WebApi.Entities.Models;

namespace WebApi.Contracts
{
    public interface IImageUrlRepository
    {
        IEnumerable<ImageUrl> GetImageUrls(bool trackChanges);
    }
}
