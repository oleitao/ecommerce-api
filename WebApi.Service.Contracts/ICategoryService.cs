using WebApi.Shared.DataTransferObjects;

namespace WebApi.Service.Contracts
{
    public interface ICategoryService
    {
        #region Sync

        public IEnumerable<CategoryDto> GetAllCategories(bool trackChanges);
        public CategoryDto GetCategory(Guid id, bool trackChanges);
        public CategoryDto CreateCategory(CategoryForCreationDto category);
        public void UpdateCategory(Guid id, CategoryForUpdateDto category, bool trackChanges);
        public IEnumerable<CategoryDto> GetByIds(IEnumerable<Guid> ids, bool trackChanges);
        public (IEnumerable<CategoryDto> categories, string ids) CreateCategoryCollection(IEnumerable<CategoryForCreationDto> categories);
        #endregion

        #region Async

        public Task<IEnumerable<CategoryDto>> GetAllCategoriesAsync(bool trackChanges);
        public Task<CategoryDto> GetCategoryAsync(Guid id, bool trackChanges);
        public Task<CategoryDto> CreateCategoryAsync(CategoryForCreationDto category);
        public Task<IEnumerable<CategoryDto>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);
        public Task<(IEnumerable<CategoryDto> categories, string ids)> CreateCategoryCollectionAsync(IEnumerable<CategoryForCreationDto> categories);
        public Task DeleteCategoryAsync(Guid id, bool trackChanges);
        public Task UpdateCategoryAsync(Guid id, CategoryForUpdateDto category, bool trackChanges);

        #endregion
    }
}
