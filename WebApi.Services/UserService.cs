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
        private readonly IMapper _mapper;
        public UserService(IRepositoryManager repository, AutoMapper.IMapper mapper)
        {
            _repository = repository;
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
                throw new Exception($"{nameof(GetAllUsers)} : {ex}");
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
                throw new Exception($"{nameof(GetUser)} : {ex}");
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

        public async Task<IEnumerable<UserDto>> GetAllUsersAsync(bool trackChanges)
        {
            try
            {
                var usersEntity = await _repository.User.GetAllUsersAsync(trackChanges);

                List<UserDto> returnList = new List<UserDto>();
                foreach (var user in usersEntity)
                {
                    var returnUser = _mapper.Map<UserDto>(user);
                    returnList.Add(returnUser);
                }

                return returnList;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(GetAllUsersAsync)} : {ex}");
            }
        }

        public async Task<UserDto> GetUserAsync(Guid id, bool trackChanges)
        {
            try
            {
                var userEntity = await _repository.User.GetUserAsync(id, trackChanges);
                if (userEntity == null)
                    throw new UserNotFoundException(id);

                var userReturn = _mapper.Map<UserDto>(userEntity);

                return userReturn;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(GetUserAsync)} : {ex}");
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

        public async Task DeleteUserAsync(Guid id, bool trackChanges)
        {
            var user = await _repository.User.GetUserAsync(id, trackChanges: false);
            if (user is null)
                throw new Exception();

            _repository.User.DeleteUser(user);
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<UserDto>> GetAllUsersAsync(UserParameters userParameters, bool trackChanges)
        {
            try
            {
                var usersEntity = await _repository.User.GetAllUsersAsync(userParameters, trackChanges);

                List<UserDto> returnList = new List<UserDto>();

                foreach (var userEntity in usersEntity)
                {
                    var returnUser = _mapper.Map<UserDto>(userEntity);
                    returnList.Add(returnUser);
                }

                return returnList;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(GetAllUsersAsync)} : {ex}");
            }
        }

        public async Task<UserDto> FindByEmailAsync(string email, bool trackChanges)
        {
            try
            {
                var userEntity = await _repository.User.FindByEmailAsync(email, trackChanges);
                if (userEntity == null)
                    throw new UserNotFoundException(email);

                var userReturn = _mapper.Map<UserDto>(userEntity);

                return userReturn;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(GetUserAsync)} : {ex}");
            }
        }

        #endregion
    }
}
