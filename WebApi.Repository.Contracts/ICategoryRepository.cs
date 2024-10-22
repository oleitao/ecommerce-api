using Model;
using WebApi.Entities.RequestFeatures;

namespace WebApi.Contracts
{
    public interface ICategoryRepository
    {
        public Task<IEnumerable<Category>> GetAllCategoriesAsync(bool trackChanges);
        public Task<Category?> GetCategoryAsync(Guid categoryId, bool trackChanges);
        public Task<IEnumerable<Category>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);
        public Task<PagedList<Category>> GetPagedListCategoriesAsync(CategoryParameters categoryParameters, bool trackChanges);
        public void DeleteCategory(Category category);
        public Task<Category?> GetCategoryByName(string category, bool trackChanges);
        public Task CreateCategoryAsync(Category category);
        public Task DeleteCategoryAsync(Category category);
    }
}
