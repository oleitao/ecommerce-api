using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using WebApi.Entities;
using WebApi.Helpers;
using WebApi.Models.Users;

namespace WebApi.Services
{
    public class ReviewService : IReviewService
    {
        private DataContext _context;
        private readonly IMapper _mapper;

        public ReviewService(
            DataContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<Review> GetAll()
        {
            return _context.Reviews.ToList();
        }

        public Review GetById(int id)
        {
            return getReview(id);
        }

        public void Create(CreateReviewRequest model)
        {
            // map model to new review object
            var review = _mapper.Map<Review>(model);

            // save review
            _context.Reviews.Add(review);
            _context.SaveChanges();
        }

        public void Update(int id, UpdateReviewRequest model)
        {
            var review = getReview(id);
            
            // copy model to review and save
            _mapper.Map(model, review);
            _context.Reviews.Update(review);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var review = getReview(id);
            _context.Reviews.Remove(review);
            _context.SaveChanges();
        }

        // helper methods

        private Review getReview(int id)
        {
            var review = _context.Reviews.Find(id);
            if (review == null) throw new KeyNotFoundException("Review not found");
            return review;
        }
    }
}
