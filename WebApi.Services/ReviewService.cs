using AutoMapper;
using Model;
using WebApi.Contracts;
using WebApi.Entities.Exceptions;
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
        #region Sync
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

        #endregion

        #region Async

        public async Task<IEnumerable<Review>> GetAllReviewsAsync(bool trackChanges)
        {
            try
            {
                var reviews = await _repository.Review.GetAllReviewsAsync(trackChanges);
                return reviews;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetAllReviews)} service method {ex}");
                throw;
            }
        }

        public async Task<Review> GetReviewAsync(Guid id, bool trackChanges)
        {
            try
            {
                var review = await _repository.Review.GetReviewAsync(id, trackChanges);
                if (review == null)
                    throw new ReviewNotFoundException(id);

                return review;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetReviewAsync)} service method {ex}");
                throw;
            }
        }

        public async Task<ReviewDto> CreateReviewAsync(ReviewForCreationDto review)
        {
            var reviewEntity = _mapper.Map<Review>(review);

            if(reviewEntity.Id == Guid.Empty)
                reviewEntity.Id = Guid.NewGuid();

            _repository.Review.CreateReview(reviewEntity);
            await _repository.SaveAsync();

            var reviewReturn = _mapper.Map<ReviewDto>(reviewEntity);

            return reviewReturn;
        }

        public async Task UpdateReviewAsync(Guid id, ReviewForUpdateDto review, bool trackChanges)
        {
            var reviewEntitie = await _repository.Review.GetReviewAsync(id, trackChanges);
            if (reviewEntitie is null)
                throw new ReviewNotFoundException(id);

            _mapper.Map(review, reviewEntitie);
            await _repository.SaveAsync();
        }

        public async Task DeleteReviewAsync(Guid id, bool trackChanges)
        {
            try
            {
                var review = await _repository.Review.GetReviewAsync(id, trackChanges);
                if (review == null)
                    throw new ReviewNotFoundException(id);

                _repository.Review.DeleteAsync(review);
                await _repository.SaveAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(DeleteReviewAsync)} service method {ex}");
                throw;
            }
        }

        #endregion
    }
}
