using Microsoft.EntityFrameworkCore;
using WebApi.Contracts;
using WebApi.Entities.Models;

namespace WebApi.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }

        #region Sync

        public IEnumerable<User> GetAllUsers(bool trackChanges) =>
            FindAll(trackChanges).ToList();

        public User GetUser(Guid userId, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(userId), trackChanges)
            .SingleOrDefault();

        public void CreateUser(User user)
        {
            Create(user);
        }

        #endregion

        #region Async
        
        public async Task<IEnumerable<User>> GetAllUsersAsync(bool trackChanges)
        {
            return FindAll(trackChanges);
        }

        public async Task<User> GetUserAsync(Guid userId, bool trackChanges)
        {
            return await FindByCondition(c => c.Id.Equals(userId), trackChanges).SingleOrDefaultAsync();
        }

        #endregion
    }
}
