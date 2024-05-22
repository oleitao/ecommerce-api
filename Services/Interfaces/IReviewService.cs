namespace WebApi.Services;

using System.Collections.Generic;
using WebApi.Entities;
using WebApi.Models.Users;

public interface IReviewService
{
    IEnumerable<Review> GetAll();
    Review GetById(int id);
    void Create(CreateReviewRequest model);
    void Update(int id, UpdateReviewRequest model);
    void Delete(int id);
}

