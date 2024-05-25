using WebApi.Entities.Models;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Service.Contracts
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers(bool trackChanges);
        User GetUser(Guid id, bool trackChanges);
        UserDto CreateUser(UserForCreationDto user);
    }
}
