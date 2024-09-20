using AutoMapper;
using Model;
using System.Dynamic;
using WebApi.Contracts;
using WebApi.Entities.Exceptions;
using WebApi.Entities.RequestFeatures;
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


        #region Async


        public async Task<List<InboxDto>> GetInboxAsync(Guid to, bool trackChanges)
        {
            try
            {
                var inbox = await _repository.Inbox.GetInboxFromAsync(to, trackChanges);
                if (inbox == null)
                    throw new InboxNotFoundException(to);


                var inboxDto = _mapper.Map<List<InboxDto>>(inbox);
                return inboxDto;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(GetInboxAsync)} : {ex}");
            }
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

        #endregion
    }
}
