using Model;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Service.Contracts
{
    public interface IInboxService
    {
        public Task<List<InboxMessageDto>> GetInboxAsync(Guid to, bool trackChanges);

        public Task<InboxDto> CreateInboxAsync(InboxForCreationDto inbox);
    }
}
