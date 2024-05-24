using WebApi.Contracts;
using WebApi.Entities.Models;
using WebApi.Service.Contracts;

namespace WebApi.Service
{
    internal sealed class CategoryService : ICategoryService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public CategoryService(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public IEnumerable<Category> GetAllCategories(bool trackChanges)
        {
            try
            {
                var categories = _repository.Category.GetAllCategories(trackChanges);
                return categories;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetAllCategories)} service method {ex}");
                throw;
            }
        }

        public Category GetCategory(Guid id, bool trackChanges)
        {
            try
            {
                var categorie = _repository.Category.GetCategory(id, trackChanges);
                return categorie;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetCategory)} service method {ex}");
                throw;
            }
        }
    }
}