using WebApi.Entities.Models;

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

        Task<User> GetUserAsync(Guid userId, bool trackChanges);

        #endregion

    }
}
