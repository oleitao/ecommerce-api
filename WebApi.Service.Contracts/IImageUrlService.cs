using WebApi.Entities.Models;

namespace WebApi.Service.Contracts
{
    public interface IImageUrlService
    {
        IEnumerable<ImageUrl> GetAllImageUrls(bool trackChanges);
        ImageUrl GetImageUrl(Guid id, bool trackChanges);
    }
}
