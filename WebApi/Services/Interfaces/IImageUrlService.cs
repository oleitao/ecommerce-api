namespace WebApi.Services;

using System.Collections.Generic;
using WebApi.Entities;
using WebApi.Models.Users;

public interface IImageUrlService
{
    IEnumerable<ImageUrl> GetAll();
    ImageUrl GetById(int id);
    void Create(CreateImageURLRequest model);
    void Update(int id, UpdateImageURLRequest model);
    void Delete(int id);
}

