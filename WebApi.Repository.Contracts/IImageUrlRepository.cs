using Model;

namespace WebApi.Contracts
{
    public interface IImageUrlRepository
    {
        #region Sync
        IEnumerable<ImageUrl> GetImageUrls(bool trackChanges);
        ImageUrl GetImageUrl(Guid imageUrlId, bool trackChanges);
        void CreateImageUrl(ImageUrl imageUrl);
        void DeleteImageUrl(ImageUrl id);
        #endregion

        #region Async
        Task<IEnumerable<ImageUrl>> GetImageUrlsAsync(bool trackChanges);
        Task<ImageUrl> GetImageUrlAsync(Guid imageUrlId, bool trackChanges);
        #endregion
    }
}
