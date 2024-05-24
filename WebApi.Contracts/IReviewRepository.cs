using WebApi.Entities.Models;

namespace WebApi.Contracts
{
    public interface IReviewRepository
    {
        IEnumerable<Review> GetAllReviews(bool trackChanges);
    }
}
