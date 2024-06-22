using AutoMapper;
using Azure;
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

        public async Task<IEnumerable<Review>> GetAllReviewsAsync(bool trackChanges)
        {
            try
            {
                var reviews = await _repository.Review.GetAllReviewsAsync(trackChanges);
                if (reviews is null)
                    throw new ReviewsNotFoundException();

                List<Review> reviewsList = new List<Review>();
                foreach (var review in reviews)
                {
                    var rev = await GetReviewByIdAsync(review.Id, trackChanges);
                    if(rev is not null)
                        reviewsList.Add(rev);
                }

                return reviewsList;
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
                var review = await GetReviewByIdAsync(id, trackChanges);
                if(review is null)
                    throw new ReviewsNotFoundException();

                var user = await _repository.User.GetUserAsync(review.UserId, trackChanges);
                if (user is null)
                    throw new UserNotFoundException(review.UserId);

                review.User = user;

                return review;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetReviewAsync)} service method {ex}");
                throw;
            }
        }

        public async Task<Review> GetReviewByIdAsync(Guid reviewId, bool trackChanges)
        {
            var review = await _repository.Review.GetReviewAsync(reviewId, trackChanges);
            if (review == null)
                throw new ReviewNotFoundException(reviewId);

            var user = await _repository.User.GetUserAsync(review.UserId, trackChanges: false);
            if (user == null)
                throw new UserNotFoundException(review.UserId);

            if (review.User is null)
                review.User = new User();

            review.User = user;

            return review;
        }

        public async Task<ReviewDto> CreateReviewAsync(ReviewForCreationDto review)
        {
            var user = _repository.User.GetUserAsync(review.User.Id, trackChanges: false);
            if (user == null && review.User is null)
                throw new UserNotFoundException(review.User.Id);

            var rev = new Review()
            {
                Id = Guid.NewGuid(),
                Comment = review.Comment,
                ProductId = review.ProductId,
                Rating = review.Rating,
                UserId = Guid.Parse(user.Result.Id)
            };

            _repository.Review.CreateReview(rev);


            await _repository.SaveAsync();

            var reviewReturn = _mapper.Map<ReviewDto>(new ReviewDto(rev.Id, rev.Comment, rev.Rating, rev.UserId, rev.ProductId));

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
