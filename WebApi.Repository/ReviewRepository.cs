using WebApi.Contracts;
using WebApi.Entities.Models;

namespace WebApi.Repository
{
    public class ReviewRepository : RepositoryBase<Review>, IReviewRepository
    {
        public ReviewRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }

        public IEnumerable<Review> GetAllReviews(bool trackChanges) =>
            FindAll(trackChanges).ToList();

        public Review GetReview(Guid reviewId, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(reviewId), trackChanges)
            .SingleOrDefault();


        public void CreateReview(Review review)
        {
            Create(review);
        }
    }
}
