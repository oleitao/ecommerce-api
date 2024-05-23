using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using WebApi.Entities;
using WebApi.Helpers;
using WebApi.Models.Users;

namespace WebApi.Services
{
    public class ShopService : IShopService
    {
        private DataContext _context;
        private readonly IMapper _mapper;

        public ShopService(
            DataContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<Shop> GetAll()
        {
            return _context.Shops.ToList();
        }

        public Shop GetById(int id)
        {
            return getShop(id);
        }

        public void Create(CreateShopRequest model)
        {
            // map model to new shop object
            var shop = _mapper.Map<Shop>(model);

            // save shop
            _context.Shops.Add(shop);
            _context.SaveChanges();
        }

        public void Update(int id, UpdateShopRequest model)
        {
            var shop = getShop(id);

            // copy model to shop and save
            _mapper.Map(model, shop);
            _context.Shops.Update(shop);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var shop = getShop(id);
            _context.Shops.Remove(shop);
            _context.SaveChanges();
        }

        // helper methods

        private Shop getShop(int id)
        {
            var shop = _context.Shops.Find(id);
            if (shop == null) throw new KeyNotFoundException("Shop not found");
            return shop;
        }
    }
}
