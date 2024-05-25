using WebApi.Entities.Models;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Service.Contracts
{
    public interface IReviewService
    {
        IEnumerable<Review> GetAllReviews(bool trackChanges);
        Review GetReview(Guid id, bool trackChanges);
        ReviewDto CreateReview(ReviewForCreationDto review);
    }
}
