﻿using Model;

namespace WebApi.Contracts
{
    public interface IReviewRepository
    {
        #region Sync
        IEnumerable<Review> GetAllReviews(bool trackChanges);
        Review GetReview(Guid reviewId, bool trackChanges);
        void CreateReview(Review review);
        #endregion

        #region Async

        Task<IEnumerable<Review>> GetAllReviewsAsync(bool trackChanges);
        Task<Review> GetReviewAsync(Guid reviewId, bool trackChanges);
        void DeleteAsync(Review review);
        Task<IEnumerable<Review>> GetReviewByUserAsync(Guid guid, bool trackChanges);
        Task<IEnumerable<Review>> GetReviewsByPoductIdAsync(Guid productId, bool trackChanges);
        Task<IEnumerable<Review>> GetReviewByProductIdAsync(Guid productId, bool trackChanges);
        void DeleteReviewByProductIdAsync(IEnumerable<Review> reviews);

        #endregion
    }
}
