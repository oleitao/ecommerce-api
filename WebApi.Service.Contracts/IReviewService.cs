using Model;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Service.Contracts
{
    public interface IReviewService
    {
        public Task<IEnumerable<ReviewDto>> GetAllReviewsAsync(bool trackChanges);
        public Task<IEnumerable<Review>> GetReviewsByProductIdAsync(Guid productId, bool trackChanges);
        public Task<ReviewDto> GetReviewAsync(Guid id, bool trackChanges);
        public Task<ReviewDto> CreateReviewAsync(ReviewForCreationDto review);
        public Task UpdateReviewAsync(Guid id, ReviewForUpdateDto review, bool trackChanges);
        public Task DeleteReviewAsync(Guid id, bool trackChanges);
        public Task DeleteReviewByProductIdAsync(Guid productId, bool trackChanges);
    }
}
