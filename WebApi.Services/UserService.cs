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

            _repository.User.CreateUserAsync(userEntity);
            await _repository.SaveAsync();

            var userReturn = _mapper.Map<UserDto>(userEntity);

            return userReturn;
        }

        public async Task UpdateSellerAsync(Guid id, SellerForUpdateDto sellerForUpdate, bool trackChanges)
        {
            var sellerEntities = await _repository.User.GetUserAsync(id, trackChanges);
            if (sellerEntities is null)
                throw new UserNotFoundException(id);


            _mapper.Map(sellerForUpdate, sellerEntities);
            await _repository.SaveAsync();
        }

        public async Task UpdateUserAsync(Guid id, UserForUpdateDto userForUpdate, bool trackChanges)
        {
            var userEntities = await _repository.User.GetUserAsync(id, trackChanges);
            if (userEntities is null)
                throw new UserNotFoundException(id);


            //_mapper.Map(userForUpdate, adminEntities);

            userEntities.PhoneNumber = userForUpdate.PhoneNumber;
            userEntities.Gender = userForUpdate.Gender;
            userEntities.Birthday = userForUpdate.Birthday;

            await _repository.SaveAsync();
        }

        public async Task UpdateAdminAsync(Guid id, AdminForUpdateDto adminForUpdate, bool trackChanges)
        {
            var adminEntities = await _repository.User.GetUserAsync(id, trackChanges);
            if (adminEntities is null)
                throw new UserNotFoundException(id);


            _mapper.Map(adminForUpdate, adminEntities);
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
                if (userEntity is not null)
                    return _mapper.Map<UserDto>(userEntity);

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(GetUserAsync)} : {ex}");
            }
        }

        public async Task<User> FindUserByEmailAsync(string email, bool trackChanges)
        {
            try
            {
                var userEntity = await _repository.User.FindByEmailAsync(email, trackChanges);
                if (userEntity is not null)
                    return userEntity;

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(GetUserAsync)} : {ex}");
            }
        }

        public async Task<bool> ConfirmEmailAsync(UserDto user)
        {
            try
            {
                var userEntity = await _repository.User.GetUserAsync(user.Id, trackChanges: false);
                if (userEntity == null)
                    throw new UserNotFoundException(user.Id);

                var result = await _repository.User.ConfirmEmailAsync(userEntity);
                await _repository.SaveAsync();

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(ConfirmEmailAsync)} : {ex}");
            }
        }

        public async Task<User> MapToUser(UserDto userEntity)
        {
            try
            {
                return new User()
                {
                    Id = userEntity.Id.ToString(),
                    Birthday = userEntity.Birthday,
                    FullName = userEntity.FullName,
                    Email = userEntity.Email,
                    Gender = userEntity.Gender,
                    UserName = userEntity.UserName
                };
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public async Task<string> GetUserRolesById(Guid id)
        {
            var userRolesEntity = await _repository.User.GetUserAsync(id, false);
            if (userRolesEntity == null)
                throw new UserNotFoundException(id);

            var roleEntity = await _repository.Role.GetUserRoleByIdAsync(userRolesEntity.RoleId, false);
            if (roleEntity == null)
                throw new RoleNotFoundException(id);

            return roleEntity.NormalizedName;
        }
    }
}
