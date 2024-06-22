using Model;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Service.Contracts
{
    public interface IImageUrlService
    {
        #region Sync
        public IEnumerable<ImageUrl> GetAllImageUrls(bool trackChanges);
        public ImageUrl GetImageUrl(Guid id, bool trackChanges);
        public ImageUrlDto CreateImageUrl(ImageUrlForCreationDto imageUrlDto);
        public void DeleteImageUrl(Guid id, bool trackChanges);

        #endregion

        #region Async

        public Task<IEnumerable<ImageUrl>> GetAllImageUrlsAsync(bool trackChanges);
        public Task<ImageUrl> GetImageUrlAsync(Guid id, bool trackChanges);
        public Task<ImageUrlDto> CreateImageUrlAsync(ImageUrlForCreationDto imageUrlDto);
        public Task DeleteImageUrlAsync(Guid id, bool trackChanges);
        public Task UpdateImageUrlAsync(Guid id, ImageUrlForUpdateDto imageUrl, bool trackChanges);
        Task DeleteImageUrlByProductIdAsync(Guid productId, bool trackChanges);

        #endregion
    }
}
