using Model;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Service.Contracts
{
    public interface IImageUrlService
    {

        public Task<IEnumerable<ImageUrlDto>> GetAllImageUrlsAsync(bool trackChanges);
        public Task<ImageUrlDto> GetImageUrlAsync(Guid id, bool trackChanges);
        public Task<List<ImageUrlDto>> GetImageUrlByProductIdAsync(Guid productId, bool trackChanges);
        public Task<ImageUrlDto> CreateImageUrlAsync(ImageUrlForCreationDto imageUrlDto);
        public Task DeleteImageUrlAsync(Guid id, bool trackChanges);
        public Task UpdateImageUrlAsync(Guid id, ImageUrlForUpdateDto imageUrl, bool trackChanges);
        public Task DeleteImageUrlByProductIdAsync(Guid productId, bool trackChanges);
    }
}
