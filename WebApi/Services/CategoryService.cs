using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using WebApi.Entities;
using WebApi.Helpers;
using WebApi.Models.Categories;

namespace WebApi.Services
{
    public class CategoryService : ICategoryService
    {
        private DataContext _context;
        private readonly IMapper _mapper;

        public CategoryService(
            DataContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<Category> GetAll()
        {
            return _context.Categories;
        }

        public Category GetById(int id)
        {
            return getCategory(id);
        }

        public void Create(CreateCategoryRequest model)
        {
            // map model to new category object
            var category = _mapper.Map<Category>(model);

            // save category
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void Update(int id, UpdateCategoryRequest model)
        {
            var category = getCategory(id);
            
            // copy model to category and save
            _mapper.Map(model, category);
            _context.Categories.Update(category);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var category = getCategory(id);
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }

        // helper methods

        private Category getCategory(int id)
        {
            var category = _context.Categories.Find(id);
            if (category == null) throw new KeyNotFoundException("Category not found");
            return category;
        }
    }
}
