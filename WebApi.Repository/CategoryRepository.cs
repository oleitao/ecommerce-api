using WebApi.Contracts;
using WebApi.Entities.Models;
using WebApi.Services;

namespace WebApi.Repository
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }
    }
}
