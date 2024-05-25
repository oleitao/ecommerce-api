using WebApi.Entities.Models;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Service.Contracts
{
    public interface ICategoryService
    {
        IEnumerable<CategoryDto> GetAllCategories(bool trackChanges);
        Category GetCategory(Guid id, bool trackChanges);
    }
}
