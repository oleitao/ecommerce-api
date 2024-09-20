using Microsoft.EntityFrameworkCore;
using Model;
using WebApi.Contracts;

namespace WebApi.Repository
{
    public class InboxRepository : RepositoryBase<Inbox>, IInboxRepository
    {
        public InboxRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }

        public async Task CreateInboxAsync(Inbox inbox)
        {
            await CreateInboxAsync(inbox).ConfigureAwait(false);
        }


        #region Async

        public async Task<List<Inbox>?> GetInboxFromAsync(Guid to, bool trackChanges)
        {
            return await FindByCondition(c => c.To.Equals(to), trackChanges).ToListAsync<Inbox>();
        }

        #endregion
    }
}
