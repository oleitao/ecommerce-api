using Microsoft.EntityFrameworkCore;
using Model;
using WebApi.Contracts;

namespace WebApi.Repository
{
    public class ReviewRepository : RepositoryBase<Review>, IReviewRepository
    {
        public ReviewRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }

        #region Sync
        public IEnumerable<Review> GetAllReviews(bool trackChanges) =>
            FindAll(trackChanges).ToList();

        public Review GetReview(Guid reviewId, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(reviewId), trackChanges)
            .SingleOrDefault();


        public void CreateReview(Review review)
        {
            Create(review);
        }

        #endregion

        #region Async

        public async Task<IEnumerable<Review>> GetAllReviewsAsync(bool trackChanges)
        {
            return FindAll(trackChanges).ToList();
        }

        public async Task<Review> GetReviewAsync(Guid reviewId, bool trackChanges)
        {
            return await FindByCondition(c => c.Id.Equals(reviewId), trackChanges).SingleOrDefaultAsync();            
        }

        public void DeleteAsync(Review review)
        {
            Delete(review);
        }

        public async Task<IEnumerable<Review>> GetReviewByUserAsync(Guid guid, bool trackChanges)
        {
            return await FindByCondition(c => c.UserId.Equals(guid), trackChanges).ToListAsync();
        }

        #endregion
    }
}
