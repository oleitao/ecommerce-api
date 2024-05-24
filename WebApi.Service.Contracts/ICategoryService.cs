using WebApi.Entities.Models;

namespace WebApi.Service.Contracts
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAllCategories(bool trackChanges);
        Category GetCategory(Guid id, bool trackChanges);
    }
}
