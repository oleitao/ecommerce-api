using Model;

namespace WebApi.Contracts
{
    public interface IRoleRepository
    {
        public Task<Role?> GetUserRoleByIdAsync(string roleId, bool trackChanges);

    }
}
