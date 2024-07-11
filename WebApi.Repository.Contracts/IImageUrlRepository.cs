using Model;

namespace WebApi.Contracts
{
    public interface IImageUrlRepository
    {
        #region Sync
        IEnumerable<ImageUrl> GetImageUrls(bool trackChanges);
        ImageUrl? GetImageUrl(Guid imageUrlId, bool trackChanges);
        void CreateImageUrl(ImageUrl imageUrl);
        void DeleteImageUrl(ImageUrl id);
        #endregion

        #region Async
        Task<IEnumerable<ImageUrl>> GetImageUrlsAsync(bool trackChanges);
        Task<ImageUrl?> GetImageUrlAsync(Guid imageUrlId, bool trackChanges);
        Task<IEnumerable<ImageUrl>> GetImageUrlByPublicIdAndUrlAsync(string public_id, string url, bool trackChanges);
        void UpdateImageUrlAsync(ImageUrl imageUrl);
        Task<IEnumerable<ImageUrl>> GetImageUrlByPublicIdAsync(string public_id, bool trackChanges);
        Task<IEnumerable<ImageUrl>> GetImageUrlByPoductIdAsync(Guid productId, bool trackChanges);
        void DeleteImageUrlProducts(IEnumerable<ImageUrl> imageUrls);
        #endregion
    }
}
