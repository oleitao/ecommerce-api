using WebApi.Entities.Models;

namespace WebApi.Contracts
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories(bool trackChanges);
    }
}
