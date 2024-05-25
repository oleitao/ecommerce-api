using WebApi.Shared.DataTransferObjects;

namespace WebApi.Service.Contracts
{
    public interface ICategoryService
    {
        IEnumerable<CategoryDto> GetAllCategories(bool trackChanges);
        CategoryDto GetCategory(Guid id, bool trackChanges);
        CategoryDto CreateCategory(CategoryForCreationDto category);
    }
}
