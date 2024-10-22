using Model;

namespace WebApi.Contracts
{
    public interface IInboxRepository
    {
        public Task<List<Inbox?>> GetInboxFromAsync(Guid to, bool trackChanges);

        public Task CreateInboxAsync(Inbox inbox);
    }
}
