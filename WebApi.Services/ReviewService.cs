using AutoMapper;
using WebApi.Contracts;
using WebApi.Entities.Exceptions;
using WebApi.Entities.Models;
using WebApi.Service.Contracts;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Services
{
    internal sealed class ReviewService : IReviewService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        public ReviewService(IRepositoryManager repository, ILoggerManager logger, AutoMapper.IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
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

        public Review GetReview(Guid id, bool trackChanges)
        {
            try
            {
                var review = _repository.Review.GetReview(id, trackChanges);
                if (review == null)
                    throw new ReviewNotFoundException(id);

                return review;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetReview)} service method {ex}");
                throw;
            }
        }

        public ReviewDto CreateReview(ReviewForCreationDto review)
        {
            var reviewEntity = _mapper.Map<Review>(review);

            _repository.Review.CreateReview(reviewEntity);
            _repository.Save();

            var reviewReturn = _mapper.Map<ReviewDto>(reviewEntity);

            return reviewReturn;
        }
    }
}
