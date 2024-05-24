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

        public IEnumerable<User> GetAllUsers(bool trackChanges) =>
            FindAll(trackChanges).ToList();

        public User GetUser(Guid userId, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(userId), trackChanges)
            .SingleOrDefault();

    }
}
