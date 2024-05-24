using WebApi.Entities.Models;

namespace WebApi.Service.Contracts
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers(bool trackChanges);
        User GetUser(Guid id, bool trackChanges);
    }
}
