using WebApi.Entities.Models;

namespace WebApi.Contracts
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers(bool trackChanges);
    }
}
