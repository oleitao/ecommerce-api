using Microsoft.EntityFrameworkCore;
using Model;
using WebApi.Contracts;
using WebApi.Entities.RequestFeatures;

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

        public async Task<Category> GetCategoryAsync(Guid categoryId, bool trackChanges)
        {
            return await FindByCondition(c => c.Id.Equals(categoryId), trackChanges).SingleOrDefaultAsync();            
        }

        public async Task<IEnumerable<Category>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges)
        {
            return await FindByCondition(x => ids.Contains(x.Id), trackChanges).ToListAsync();
        }

        public async Task<PagedList<Category>> GetPagedListCategoriesAsync(CategoryParameters categoryParameters, bool trackChanges)
        {
            var categories = await FindAll(trackChanges)
                .Skip((categoryParameters.PageNumber - 1) * categoryParameters.PageSize)
                .Take(categoryParameters.PageSize)
                .ToListAsync();

            return PagedList<Category>.ToPagedList(categories, categoryParameters.PageNumber, categoryParameters.PageSize);
        }

        public void DeleteCategory(Category category)
        {
            Delete(category);
        }

        public async Task<Category> GetCategoryByName(string category, bool trackChanges)
        {
            return await FindByCondition(c => c.Title.Equals(category), trackChanges).SingleOrDefaultAsync();
        }

        #endregion
    }
}
