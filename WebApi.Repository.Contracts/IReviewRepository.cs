using Model;

namespace WebApi.Contracts
{
    public interface IReviewRepository
    {
        public Task<IEnumerable<Review>> GetAllReviewsAsync(bool trackChanges);
        public Task<Review> GetReviewAsync(Guid reviewId, bool trackChanges);
        public Task DeleteAsync(Review review);
        public Task<IEnumerable<Review>> GetReviewByUserAsync(Guid guid, bool trackChanges);
        public Task<IEnumerable<Review>> GetReviewsByPoductIdAsync(Guid productId, bool trackChanges);
        public Task<IEnumerable<Review>> GetReviewByProductIdAsync(Guid productId, bool trackChanges);
        public Task DeleteReviewByProductIdAsync(IEnumerable<Review> reviews);
        public void CreateReviewAsync(Review reviewEntity);
    }
}
