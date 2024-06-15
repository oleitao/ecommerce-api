using Model;
using WebApi.Entities.RequestFeatures;

namespace WebApi.Contracts
{
    public interface IUserRepository
    {
        #region Sync
        IEnumerable<User> GetAllUsers(bool trackChanges);

        User GetUser(Guid userId, bool trackChanges);
        void CreateUser(User user);
        #endregion

        #region Async

        Task<IEnumerable<User>> GetAllUsersAsync(bool trackChanges);

        Task<User?> GetUserAsync(Guid userId, bool trackChanges);
        public Task<IEnumerable<User>> GetAllUsersAsync(UserParameters userParameters, bool trackChanges);
        void DeleteUser(User user);

        #endregion

    }
}
