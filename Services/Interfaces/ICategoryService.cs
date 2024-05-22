namespace WebApi.Services;

using System.Collections.Generic;
using WebApi.Entities;
using WebApi.Models.Categories;

public interface ICategoryService
{
    IEnumerable<Category> GetAll();
    Category GetById(int id);
    void Create(CreateCategoryRequest model);
    void Update(int id, UpdateCategoryRequest model);
    void Delete(int id);
}

