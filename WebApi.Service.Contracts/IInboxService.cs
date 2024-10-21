using Model;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Service.Contracts
{
    public interface IInboxService
    {
        public Task<List<InboxDto>> GetInboxAsync(Guid from, bool trackChanges);

        public Task<InboxDto> CreateInboxAsync(InboxForCreationDto inbox);
    }
}
