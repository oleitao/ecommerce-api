using Model;
using WebApi.Entities.RequestFeatures;

namespace WebApi.Contracts
{
    public interface ICategoryRepository
    {
        #region Sync
        IEnumerable<Category> GetAllCategories(bool trackChanges);
        Category GetCategory(Guid categoryId, bool trackChanges);
        void CreateCategory(Category category);
        IEnumerable<Category> GetByIds(IEnumerable<Guid> ids, bool trackChanges);
        #endregion

        #region Async

        Task<IEnumerable<Category>> GetAllCategoriesAsync(bool trackChanges);
        Task<Category> GetCategoryAsync(Guid categoryId, bool trackChanges);
        Task<IEnumerable<Category>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);
        Task<PagedList<Category>> GetPagedListCategoriesAsync(CategoryParameters categoryParameters, bool trackChanges);
        void DeleteCategory(Category category);

        #endregion
    }
}
