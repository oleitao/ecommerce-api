using Microsoft.EntityFrameworkCore;
using Model;
using WebApi.Contracts;
using WebApi.Entities.RequestFeatures;

namespace WebApi.Repository
{
    public class EmailRepository : RepositoryBase<Email>, IEmailRepository
    {
        public EmailRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }

        #region Async

        public async Task<Email> GetEmailContent(Guid id, bool trackChanges)
        {
            return await FindByCondition(c => c.Id.Equals(id), trackChanges).SingleOrDefaultAsync();
        }

        #endregion
    }
}
