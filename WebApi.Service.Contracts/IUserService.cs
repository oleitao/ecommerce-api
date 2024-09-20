using Model;
using WebApi.Entities.RequestFeatures;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Service.Contracts
{
    public interface IUserService
    {
        #region Sync
        public IEnumerable<User> GetAllUsers(bool trackChanges);
        public User GetUser(Guid id, bool trackChanges);
        public UserDto CreateUser(UserForCreationDto user);
        #endregion

        #region Async
        public Task<IEnumerable<UserDto>> GetAllUsersAsync(UserParameters userParameters, bool trackChanges);
        public Task<IEnumerable<UserDto>> GetAllUsersAsync(bool trackChanges);
        public Task<UserDto> GetUserAsync(Guid id, bool trackChanges);
        public Task<UserDto> CreateUserAsync(UserForCreationDto user);
        public Task UpdateUserAsync(Guid id, UserForUpdateDto category, bool trackChanges);
        public Task DeleteUserAsync(Guid id, bool trackChanges);
        public Task<UserDto> FindByEmailAsync(string email, bool trackChanges);
        public Task<User> FindUserByEmailAsync(string email, bool trackChanges);
        public Task<bool> ConfirmEmailAsync(UserDto user);
        public Task<Model.User> MapToUser(UserDto userEntity);
        #endregion
    }
}
