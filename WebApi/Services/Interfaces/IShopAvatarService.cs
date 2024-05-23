namespace WebApi.Services;

using System.Collections.Generic;
using WebApi.Entities;
using WebApi.Models.Users;

public interface IShopAvatarService
{
    IEnumerable<ShopAvatar> GetAll();
    ShopAvatar GetById(int id);
    void Create(CreateShopAvatarRequest model);
    void Update(int id, UpdateShopAvatarRequest model);
    void Delete(int id);
}

