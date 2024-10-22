using Model;

namespace WebApi.Contracts
{
    public interface IImageUrlRepository
    {
        public Task<IEnumerable<ImageUrl>> GetImageUrlsAsync(bool trackChanges);
        public Task<ImageUrl?> GetImageUrlAsync(Guid imageUrlId, bool trackChanges);
        public Task<IEnumerable<ImageUrl>> GetImageUrlByPublicIdAndUrlAsync(string public_id, string url, bool trackChanges);
        public void UpdateImageUrlAsync(ImageUrl imageUrl);
        public Task<IEnumerable<ImageUrl>> GetImageUrlByPublicIdAsync(string public_id, bool trackChanges);
        public Task<IEnumerable<ImageUrl>> GetImageUrlByPoductIdAsync(Guid productId, bool trackChanges);
        void DeleteImageUrlProducts(IEnumerable<ImageUrl> imageUrls);
        public void DeleteImageUrlAsync(ImageUrl imageUrl);
        public void CreateImageUrlAsync(ImageUrl imageUrlEntity);
    }
}
