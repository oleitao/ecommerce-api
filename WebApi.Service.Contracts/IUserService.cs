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
        public Task<IEnumerable<User>> GetAllUsersAsync(UserParameters userParameters, bool trackChanges);
        public Task<IEnumerable<User>> GetAllUsersAsync(bool trackChanges);
        public Task<User> GetUserAsync(Guid id, bool trackChanges);
        public Task<UserDto> CreateUserAsync(UserForCreationDto user);
        public Task UpdateUserAsync(Guid id, UserForUpdateDto category, bool trackChanges);
        Task DeleteUserAsync(Guid id, bool trackChanges);
        #endregion
    }
}
