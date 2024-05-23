using AutoMapper;
using System.Collections.Generic;
using WebApi.Entities;
using WebApi.Helpers;
using WebApi.Models.Products;

namespace WebApi.Services
{
    public class ProductService : IProductService
    {
        private DataContext _context;
        private readonly IMapper _mapper;

        public ProductService(
            DataContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products;
        }

        public Product GetById(int id)
        {
            return getProduct(id);
        }

        public void Create(CreateProductRequest model)
        {
            // map model to new product object
            var product = _mapper.Map<Product>(model);

            // save product
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Update(int id, UpdateProductRequest model)
        {
            var product = getProduct(id);

            // copy model to product and save
            _mapper.Map(model, product);
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var product = getProduct(id);
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        // helper methods

        private Product getProduct(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null) throw new KeyNotFoundException("Product not found");
            return product;
        }
    }
}
