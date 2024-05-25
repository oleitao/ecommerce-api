using WebApi.Entities.Models;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Service.Contracts
{
    public interface IImageUrlService
    {
        IEnumerable<ImageUrl> GetAllImageUrls(bool trackChanges);
        ImageUrl GetImageUrl(Guid id, bool trackChanges);
        ImageUrlDto CreateImageUrl(ImageUrlForCreationDto imageUrlDto);
    }
}
