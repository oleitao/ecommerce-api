﻿using WebApi.Entities.Models;

namespace WebApi.Service.Contracts
{
    public interface IReviewService
    {
        IEnumerable<Review> GetAllReviews(bool trackChanges);
        Review GetReview(Guid id, bool trackChanges);
    }
}
