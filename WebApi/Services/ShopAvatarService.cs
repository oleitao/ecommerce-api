using AutoMapper;
using System.Collections.Generic;
using WebApi.Entities;
using WebApi.Helpers;
using WebApi.Models.Users;

namespace WebApi.Services
{
    public class ShopAvatarService : IShopAvatarService
    {
        private DataContext _context;
        private readonly IMapper _mapper;

        public ShopAvatarService(
            DataContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<ShopAvatar> GetAll()
        {
            return _context.ShopAvatars;
        }

        public ShopAvatar GetById(int id)
        {
            return getShopAvatar(id);
        }

        public void Create(CreateShopAvatarRequest model)
        {
            // map model to new shopAvatar object
            var shopAvatar = _mapper.Map<ShopAvatar>(model);

            // save shopAvatar
            _context.ShopAvatars.Add(shopAvatar);
            _context.SaveChanges();
        }

        public void Update(int id, UpdateShopAvatarRequest model)
        {
            var shopAvatar = getShopAvatar(id);
            
            // copy model to shopAvatar and save
            _mapper.Map(model, shopAvatar);
            _context.ShopAvatars.Update(shopAvatar);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var shopAvatar = getShopAvatar(id);
            _context.ShopAvatars.Remove(shopAvatar);
            _context.SaveChanges();
        }

        // helper methods

        private ShopAvatar getShopAvatar(int id)
        {
            var shopAvatar = _context.ShopAvatars.Find(id);
            if (shopAvatar == null) throw new KeyNotFoundException("ShopAvatar not found");
            return shopAvatar;
        }
    }
}
