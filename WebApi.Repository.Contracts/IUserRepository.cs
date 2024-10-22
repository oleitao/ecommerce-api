using Model;
using WebApi.Entities.RequestFeatures;

namespace WebApi.Contracts
{
    public interface IUserRepository
    {
        public Task<IEnumerable<User>> GetAllUsersAsync(bool trackChanges);

        public Task<User?> GetUserAsync(Guid userId, bool trackChanges);
        public Task<IEnumerable<User>> GetAllUsersAsync(UserParameters userParameters, bool trackChanges);
        public Task DeleteUser(User user);
        public Task<User?> FindByEmailAsync(string email, bool trackChanges);
        public Task<bool> ConfirmEmailAsync(User userEntity);
        public Task<User?> FindUserRoleByUserNameAsync(string userName, bool trackChanges);
        public void CreateUserAsync(User userEntity);
    }
}
