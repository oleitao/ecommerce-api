using AutoMapper;
using WebApi.Contracts;
using WebApi.Entities.Exceptions;
using WebApi.Entities.Models;
using WebApi.Service.Contracts;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Services
{
    internal sealed class CategoryService : ICategoryService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        public CategoryService(IRepositoryManager repository, ILoggerManager logger, AutoMapper.IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public IEnumerable<CategoryDto> GetAllCategories(bool trackChanges)
        {
            try
            {
                var categories = _repository.Category.GetAllCategories(trackChanges);

                var categotiesDto = categories.Select(c => new CategoryDto(c.Id, c.Title ?? "", c.SubTitle ?? "", c.ImageUrl ?? "")).ToList();

                return categotiesDto;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetAllCategories)} service method {ex}");
                throw;
            }
        }

        public CategoryDto GetCategory(Guid id, bool trackChanges)
        {
            try
            {
                var categorie = _repository.Category.GetCategory(id, trackChanges);
                if (categorie == null)
                    throw new CategoryNotFoundException(id);


                var categoryDto = _mapper.Map<CategoryDto>(categorie);
                return categoryDto;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetCategory)} service method {ex}");
                throw;
            }
        }

        public CategoryDto CreateCategory(CategoryForCreationDto category)
        {
            var categoryEntity = _mapper.Map<Category>(category);

            _repository.Category.CreateCategory(categoryEntity);
            _repository.Save();

            var categoryReturn = _mapper.Map<CategoryDto>(categoryEntity);

            return categoryReturn;
        }

        public IEnumerable<CategoryDto> GetByIds(IEnumerable<Guid> ids, bool trackChanges)
        {
            if (ids is null)
                throw new IdParametersBadException();

            var categoryEntities = _repository.Category.GetByIds(ids, trackChanges);
            if(ids.Count() != categoryEntities.Count())
                throw new CollectionByIdsBadRequestException();

            var categoriesToReturn = _mapper.Map<IEnumerable<CategoryDto>>(categoryEntities);

            return categoriesToReturn;
        }

        public (IEnumerable<CategoryDto> categories, string ids) CreateCategoryCollection(IEnumerable<CategoryForCreationDto> categoriesCollection)
        {
            if(categoriesCollection is null)
                throw new CategoryCollectionBadRequest();

            var categoriyEntities = _mapper.Map<IEnumerable<Category>>(categoriesCollection);
            foreach (var category in categoriyEntities)
            {
                _repository.Category.CreateCategory(category);
            }

            _repository.Save();

            var categoryCollectionToReturn = _mapper.Map<IEnumerable<CategoryDto>>(categoriyEntities);
            var ids = string.Join(",", categoryCollectionToReturn.Select(c => c.Id));

            return (category: categoryCollectionToReturn, ids: ids);

        }

        public void UpdateCategory(Guid id, CategoryForUpdateDto categoryForUpdate, bool trackChanges)
        {
            var categoryEntities = _repository.Category.GetCategory(id, trackChanges);
            if (categoryEntities is null)
                throw new CategoryNotFoundException(id);


            _mapper.Map(categoryForUpdate, categoryEntities);
            _repository.Save();
        }
    }
}
