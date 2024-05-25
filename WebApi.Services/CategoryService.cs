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
    }
}
