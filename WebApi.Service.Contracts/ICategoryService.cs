using WebApi.Shared.DataTransferObjects;

namespace WebApi.Service.Contracts
{
    public interface ICategoryService
    {
        IEnumerable<CategoryDto> GetAllCategories(bool trackChanges);
        CategoryDto GetCategory(Guid id, bool trackChanges);
        CategoryDto CreateCategory(CategoryForCreationDto category);
        void UpdateCategory(Guid id, CategoryForUpdateDto category, bool trackChanges);
        IEnumerable<CategoryDto> GetByIds(IEnumerable<Guid> ids, bool trackChanges);
        (IEnumerable<CategoryDto> categories, string ids) CreateCategoryCollection(IEnumerable<CategoryForCreationDto> categories);
    }
}
