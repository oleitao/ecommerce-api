using AutoMapper;
using WebApi.Contracts;
using WebApi.Entities.Exceptions;
using WebApi.Service.Contracts;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Services
{
    internal sealed class OrderStatusService : IOrderStatusService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        private readonly IDataShaper<CategoryDto> _dataShaper;
        public OrderStatusService(IRepositoryManager repository, AutoMapper.IMapper mapper, IDataShaper<CategoryDto> dataShaper)
        {
            _repository = repository;
            _mapper = mapper;
            _dataShaper = dataShaper;
        }

        public OrderStatusService(IRepositoryManager repository, AutoMapper.IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OrderStatusDto> GetOrderStatusByIdAsync(Guid orderStatusId, bool trackChanges)
        {
            try
            {
                var orderStatus = await _repository.OrderStatus.GetOrderStatusByIdAsync(orderStatusId, trackChanges);
                if (orderStatus == null)
                    throw new OrderStatusNotFoundException(orderStatusId);


                var orderStatusDto = _mapper.Map<OrderStatusDto>(orderStatus);
                return orderStatusDto;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(GetOrderStatusByIdAsync)} : {ex}");
            }
        }
    }
}
