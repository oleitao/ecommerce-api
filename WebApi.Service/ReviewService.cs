using WebApi.Contracts;
using WebApi.Entities.Models;
using WebApi.Service.Contracts;

namespace WebApi.Service
{
    internal sealed class ReviewService : IReviewService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public ReviewService(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public IEnumerable<Review> GetAllReviews(bool trackChanges)
        {
            try
            {
                var reviews = _repository.Review.GetAllReviews(trackChanges);
                return reviews;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetAllReviews)} service method {ex}");
                throw;
            }
        }
    }
}