using Microsoft.EntityFrameworkCore;
using Model;
using WebApi.Contracts;

namespace WebApi.Repository
{
    public class RoleRepository : RepositoryBase<Role>, IRoleRepository
    {
        public RoleRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }

        public async Task<Role?> GetUserRoleByIdAsync(string roleId, bool trackChanges)
        {
            return await FindByCondition(c => c.Id.Equals(roleId), trackChanges).SingleOrDefaultAsync();
        }
    }
}
