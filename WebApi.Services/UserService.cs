using AutoMapper;
using Model;
using WebApi.Contracts;
using WebApi.Entities.Exceptions;
using WebApi.Entities.RequestFeatures;
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

        #region Sync

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

        #endregion

        #region Async

        public async Task<IEnumerable<User>> GetAllUsersAsync(bool trackChanges)
        {
            try
            {
                var users = await _repository.User.GetAllUsersAsync(trackChanges);
                return users;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetAllUsersAsync)} service method {ex}");
                throw;
            }
        }

        public async Task<User> GetUserAsync(Guid id, bool trackChanges)
        {
            try
            {
                var user = await _repository.User.GetUserAsync(id, trackChanges);
                if (user == null)
                    throw new UserNotFoundException(id);

                return user;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetUserAsync)} service method {ex}");
                throw;
            }
        }

        public async Task<UserDto> CreateUserAsync(UserForCreationDto user)
        {
            var userEntity = _mapper.Map<User>(user);

            _repository.User.CreateUser(userEntity);
            await _repository.SaveAsync();

            var userReturn = _mapper.Map<UserDto>(userEntity);

            return userReturn;
        }

        public async Task UpdateUserAsync(Guid id, UserForUpdateDto user, bool trackChanges)
        {
            var userEntities = await _repository.User.GetUserAsync(id, trackChanges);
            if (userEntities is null)
                throw new UserNotFoundException(id);


            _mapper.Map(user, userEntities);
            await _repository.SaveAsync();
        }

        public Task DeleteUserAsync(Guid id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync(UserParameters userParameters, bool trackChanges)
        {
            try
            {
                var users = await _repository.User.GetAllUsersAsync(userParameters, trackChanges);
                return users;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetAllUsersAsync)} service method {ex}");
                throw;
            }
        }

        #endregion
    }
}
