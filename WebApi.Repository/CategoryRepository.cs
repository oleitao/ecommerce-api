using Microsoft.EntityFrameworkCore;
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

        #region Sync

        public IEnumerable<Category> GetAllCategories(bool trackChanges) =>
            FindAll(trackChanges).ToList();

        public Category GetCategory(Guid categoryId, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(categoryId), trackChanges)
            .SingleOrDefault();

        public void CreateCategory(Category category)
        {
            Create(category);
        }

        public IEnumerable<Category> GetByIds(IEnumerable<Guid> ids, bool trackChanges)
        {
            return FindByCondition(x => ids.Contains(x.Id), trackChanges).ToList();
        }

        #endregion

        #region Async

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync(bool trackChanges)
        {
            return FindAll(trackChanges).ToList();
        }

        public Task<Category> GetCategoryAsync(Guid categoryId, bool trackChanges)
        {
            return FindByCondition(c => c.Id.Equals(categoryId), trackChanges).SingleOrDefaultAsync();            
        }

        public async Task<IEnumerable<Category>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges)
        {
            return FindByCondition(x => ids.Contains(x.Id), trackChanges).ToList();
        }

        #endregion
    }
}
