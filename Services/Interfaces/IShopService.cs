namespace WebApi.Services;

using System.Collections.Generic;
using WebApi.Entities;
using WebApi.Models.Users;

public interface IShopService
{
   IEnumerable<Shop> GetAll();
    Shop GetById(int id);
    void Create(CreateShopRequest model);
    void Update(int id, UpdateShopRequest model);
    void Delete(int id);
}

