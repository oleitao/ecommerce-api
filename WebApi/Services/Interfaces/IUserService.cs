namespace WebApi.Services;

using System.Collections.Generic;
using WebApi.Entities;
using WebApi.Models.Users;

public interface IUserService
{
    IEnumerable<User> GetAll();
    User GetById(int id);
    void Create(CreateUserRequest model);
    void Update(int id, UpdateUserRequest model);
    void Delete(int id);
}

