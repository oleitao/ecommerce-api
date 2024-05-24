using WebApi.Contracts;
using WebApi.Entities.Models;
using WebApi.Service.Contracts;

namespace WebApi.Service
{
    internal sealed class UserService : IUserService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public UserService(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public IEnumerable<User> GetAllUsers(bool trackChanges)
        {
            try
            {
                var users = _repository.User.GetAllUsers(trackChanges);
                return users;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetAllUsers)} service method {ex}");
                throw;
            }
        }
    }
}