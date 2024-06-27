using AutoMapper;
using Model;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
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

        public async Task<IEnumerable<ReviewDto>> GetAllReviewsAsync(bool trackChanges)
        {
            try
            {
                var reviewsEntity = await _repository.Review.GetAllReviewsAsync(trackChanges);
                if (reviewsEntity is null)
                    throw new ReviewsNotFoundException();

                List<ReviewDto> returnList = new List<ReviewDto>();
                foreach (var review in reviewsEntity)
                {
                    var returnReview = await GetReviewByIdAsync(review.Id, trackChanges);                    
                    returnList.Add(returnReview);
                }

                return returnList;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetAllReviews)} service method {ex}");
                throw;
            }
        }

        public async Task<ReviewDto> GetReviewAsync(Guid id, bool trackChanges)
        {
            try
            {
                var review = await GetReviewByIdAsync(id, trackChanges);
                if(review is null)
                    throw new ReviewsNotFoundException();

                var user = await _repository.User.GetUserAsync(review.UserId, trackChanges);
                if (user is null)
                    throw new UserNotFoundException(review.UserId);

                return review;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetReviewAsync)} service method {ex}");
                throw;
            }
        }

        public async Task<ReviewDto> GetReviewByIdAsync(Guid reviewId, bool trackChanges)
        {
            var reviewEntity = await _repository.Review.GetReviewAsync(reviewId, trackChanges);
            if (reviewEntity == null)
                throw new ReviewNotFoundException(reviewId);

            var userEntity = await _repository.User.GetUserAsync(reviewEntity.UserId, trackChanges: false);
            if (userEntity == null)
                throw new UserNotFoundException(reviewEntity.UserId);

            if (reviewEntity.User is null)
                reviewEntity.User = new User();

            var returnUser = _mapper.Map<UserDto>(userEntity);
            var reviewReturn = _mapper.Map<ReviewDto>(new ReviewDto(reviewEntity.Id, reviewEntity.Comment, reviewEntity.Rating, reviewEntity.UserId, reviewEntity.ProductId, returnUser));

            return reviewReturn;
        }

        public async Task<ReviewDto> CreateReviewAsync(ReviewForCreationDto reviewCreate)
        {
            try
            {
                var userEntity = _repository.User.GetUserAsync(reviewCreate.User.Id, trackChanges: false);
                if (userEntity == null && reviewCreate.User is null)
                    throw new UserNotFoundException(reviewCreate.User.Id);

                var reviewEntity = new Review()
                {
                    Id = Guid.NewGuid(),
                    Comment = reviewCreate.Comment,
                    ProductId = reviewCreate.ProductId,
                    Rating = reviewCreate.Rating,
                    UserId = Guid.Parse(userEntity.Result.Id),
                    User = userEntity.Result
                };


                var returnReview = _mapper.Map<ReviewDto>(reviewEntity);

                _repository.Review.CreateReview(reviewEntity);
                await _repository.SaveAsync();

                return returnReview;
            }
            catch (Exception ex)
            {

                throw;
            }
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

        public async Task DeleteReviewByProductIdAsync(Guid productId, bool trackChanges)
        {
            var reviews = await _repository.Review.GetReviewByProductIdAsync(productId, trackChanges);
            if (reviews is null)
                throw new ReviewsNotFoundException();


            _repository.Review.DeleteReviewByProductIdAsync(reviews);
            await _repository.SaveAsync();
        }

        #endregion
    }
}
