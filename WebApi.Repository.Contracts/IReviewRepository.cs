using Model;

namespace WebApi.Contracts
{
    public interface IReviewRepository
    {
        #region Sync
        IEnumerable<Review> GetAllReviews(bool trackChanges);
        Review? GetReview(Guid reviewId, bool trackChanges);
        void CreateReview(Review review);
        #endregion

        #region Async

        public Task<IEnumerable<Review>> GetAllReviewsAsync(bool trackChanges);
        public Task<Review> GetReviewAsync(Guid reviewId, bool trackChanges);
        public Task DeleteAsync(Review review);
        public Task<IEnumerable<Review>> GetReviewByUserAsync(Guid guid, bool trackChanges);
        public Task<IEnumerable<Review>> GetReviewsByPoductIdAsync(Guid productId, bool trackChanges);
        public Task<IEnumerable<Review>> GetReviewByProductIdAsync(Guid productId, bool trackChanges);
        public Task DeleteReviewByProductIdAsync(IEnumerable<Review> reviews);

        #endregion
    }
}
