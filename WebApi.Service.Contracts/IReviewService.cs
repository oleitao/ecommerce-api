using Model;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Service.Contracts
{
    public interface IReviewService
    {
        #region Sync
        public IEnumerable<Review> GetAllReviews(bool trackChanges);
        public Review GetReview(Guid id, bool trackChanges);
        public ReviewDto CreateReview(ReviewForCreationDto review);
        #endregion

        #region Async
        public Task<IEnumerable<Review>> GetAllReviewsAsync(bool trackChanges);
        public Task<Review> GetReviewAsync(Guid id, bool trackChanges);
        public Task<ReviewDto> CreateReviewAsync(ReviewForCreationDto review);
        Task UpdateReviewAsync(Guid id, ReviewForUpdateDto review, bool trackChanges);
        Task DeleteReviewAsync(Guid id, bool trackChanges);
        Task DeleteReviewByProductIdAsync(Guid productId, bool trackChanges);
        #endregion
    }
}
