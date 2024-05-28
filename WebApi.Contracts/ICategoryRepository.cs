using WebApi.Entities.Models;

namespace WebApi.Contracts
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories(bool trackChanges);
        Category GetCategory(Guid categoryId, bool trackChanges);
        void CreateCategory(Category category);
        IEnumerable<Category> GetByIds(IEnumerable<Guid> ids, bool trackChanges);
    }
}
