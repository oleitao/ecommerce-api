﻿using WebApi.Entities.Models;

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

        #endregion
    }
}