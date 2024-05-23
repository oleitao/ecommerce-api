namespace WebApi.Services;

using System.Collections.Generic;
using WebApi.Entities;
using WebApi.Models.Products;

public interface IProductService
{
    IEnumerable<Product> GetAll();
    Product GetById(int id);
    void Create(CreateProductRequest model);
    void Update(int id, UpdateProductRequest model);
    void Delete(int id);
}

