using AutoMapper;
using Model;
using WebApi.Contracts;
using WebApi.Entities.Exceptions;
using WebApi.Service.Contracts;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Services
{
    internal sealed class InboxService : IInboxService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        private readonly IDataShaper<CategoryDto> _dataShaper;
        public InboxService(IRepositoryManager repository, AutoMapper.IMapper mapper, IDataShaper<CategoryDto> dataShaper)
        {
            _repository = repository;
            _mapper = mapper;
            _dataShaper = dataShaper;
        }

        public InboxService(IRepositoryManager repository, AutoMapper.IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public async Task<List<InboxMessageDto>> GetInboxAsync(Guid to, bool trackChanges)
        {
            var inboxMessages = await _repository.Inbox.GetInboxFromAsync(to, trackChanges);
            if (inboxMessages == null)
                throw new InboxNotFoundException(to);


            List<InboxMessageDto> result = new List<InboxMessageDto>();
            foreach (var message in inboxMessages)
            {
                var from = await _repository.User.GetUserAsync(message.From, false);

                if(from != null && to != null)
                    result.Add(new InboxMessageDto(message.Id, message.Message, from.UserName, message.Stamp));
            }

            return result;
        }

        public async Task<InboxDto> CreateInboxAsync(InboxForCreationDto inbox)
        {
            var inboxEntity = _mapper.Map<Inbox>(inbox);

            if (inboxEntity.Id == Guid.Empty)
                inboxEntity.Id = Guid.NewGuid();

            await _repository.Inbox.CreateInboxAsync(inboxEntity);
            await _repository.SaveAsync();

            var inboxReturn = _mapper.Map<InboxDto>(inboxEntity);

            return inboxReturn;
        }
    }
}
