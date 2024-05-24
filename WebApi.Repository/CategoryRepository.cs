using WebApi.Contracts;
using WebApi.Entities.Models;

namespace WebApi.Repository
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }

        public IEnumerable<Category> GetAllCategories(bool trackChanges) =>
            FindAll(trackChanges).ToList();
    }
}
