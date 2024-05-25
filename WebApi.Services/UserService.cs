using AutoMapper;
using WebApi.Contracts;
using WebApi.Entities.Exceptions;
using WebApi.Entities.Models;
using WebApi.Service.Contracts;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Services
{
    internal sealed class UserService : IUserService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        public UserService(IRepositoryManager repository, ILoggerManager logger, AutoMapper.IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
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

        public User GetUser(Guid id, bool trackChanges)
        {
            try
            {
                var user = _repository.User.GetUser(id, trackChanges);
                if (user == null)
                    throw new UserNotFoundException(id);

                return user;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetUser)} service method {ex}");
                throw;
            }
        }

        public UserDto CreateUser(UserForCreationDto user)
        {
            var userEntity = _mapper.Map<User>(user);

            _repository.User.CreateUser(userEntity);
            _repository.Save();

            var userReturn = _mapper.Map<UserDto>(userEntity);

            return userReturn;
        }
    }
}
