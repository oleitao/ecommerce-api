using System.Dynamic;
using WebApi.Entities.RequestFeatures;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Service.Contracts
{
    public interface ICategoryService
    {
        public Task<IEnumerable<CategoryDto>> GetAllCategoriesAsync(bool trackChanges);
        public Task<CategoryDto> GetCategoryAsync(Guid id, bool trackChanges);
        public Task<CategoryDto> CreateCategoryAsync(CategoryForCreationDto category);
        public Task<IEnumerable<CategoryDto>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);
        public Task<(IEnumerable<CategoryDto> categories, string ids)> CreateCategoryCollectionAsync(IEnumerable<CategoryForCreationDto> categories);
        public Task DeleteCategoryAsync(Guid id, bool trackChanges);
        public Task UpdateCategoryAsync(Guid id, CategoryForUpdateDto category, bool trackChanges);
        public Task<(IEnumerable<ExpandoObject> categories, MetaData metadata)> GetAllCategoriesAsync(CategoryParameters categoryParameters, bool trackChanges);
    }
}
