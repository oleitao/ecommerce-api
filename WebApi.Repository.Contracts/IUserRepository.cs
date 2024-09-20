using Model;
using WebApi.Entities.RequestFeatures;

namespace WebApi.Contracts
{
    public interface IUserRepository
    {
        #region Sync
        public IEnumerable<User> GetAllUsers(bool trackChanges);
        public User? GetUser(Guid userId, bool trackChanges);
        public void CreateUser(User user);
        #endregion

        #region Async

        public Task<IEnumerable<User>> GetAllUsersAsync(bool trackChanges);

        public Task<User?> GetUserAsync(Guid userId, bool trackChanges);
        public Task<IEnumerable<User>> GetAllUsersAsync(UserParameters userParameters, bool trackChanges);
        public Task DeleteUser(User user);
        public Task<User?> FindByEmailAsync(string email, bool trackChanges);
        public Task<bool> ConfirmEmailAsync(User userEntity);

        #endregion

    }
}
