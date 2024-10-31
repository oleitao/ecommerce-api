using AutoMapper;
using Model;
using StackExchange.Redis;
using System.Dynamic;
using WebApi.Contracts;
using WebApi.Entities.Exceptions;
using WebApi.Entities.RequestFeatures;
using WebApi.Service.Contracts;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Services
{
    internal sealed class OrderService : IOrderService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        private readonly IDataShaper<CategoryDto> _dataShaper;
        public OrderService(IRepositoryManager repository, AutoMapper.IMapper mapper, IDataShaper<CategoryDto> dataShaper)
        {
            _repository = repository;
            _mapper = mapper;
            _dataShaper = dataShaper;
        }

        public OrderService(IRepositoryManager repository, AutoMapper.IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<OrderDto>> GetAllOrdersAsync(bool trackChanges)
        {
            try
            {
                var orders = await _repository.Order.GetAllOrdersAsync(trackChanges);

                //var ordersDto = orders.Select(c => new OrderDto(c.Id, 
                //    c.Seller ?? null,
                //    c.Buyer ?? null,
                //    c.OrderProduct ?? null,
                //    c.Quantity ?? "",
                //    c.StatusId ?? Guid.Parse(""))).ToList();

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(GetAllOrdersAsync)} : {ex}");
            }
        }

        public async Task<List<OrderDto>> GetOrderByBuyerIdAsync(Guid userId, bool trackChanges)
        {
            var orderEntity = await _repository.Order.GetOrdersByBuyerIdAsync(userId, trackChanges);
            if (orderEntity == null)
                throw new UserNotFoundException(userId);

            List<OrderDto> ordersReturn = new List<OrderDto>();

            foreach (var order in orderEntity)
            {
                var buyer = await _repository.User.GetUserAsync(order.BuyerId, trackChanges);
                var seller = await _repository.User.GetUserAsync(order.SellerId, trackChanges);
                var orderProduct = await _repository.Product.GetProductAsync(order.ProductId, trackChanges);

                if(orderProduct != null && buyer != null && seller != null)
                    ordersReturn.Add(new OrderDto(order.Id, seller, buyer, orderProduct, order.Quantity, order.StatusId));
            }

            return ordersReturn;
        }

        public async Task<List<OrderDto>> GetOrderBySellerIdAsync(Guid userId, bool trackChanges)
        {
            var orderEntity = await _repository.Order.GetOrdersByBuyerIdAsync(userId, trackChanges);
            if (orderEntity == null)
                throw new UserNotFoundException(userId);


            List<OrderDto> ordersReturn = new List<OrderDto>();

            foreach (var order in orderEntity)
            {
                var buyer = await _repository.User.GetUserAsync(order.BuyerId, trackChanges);
                var seller = await _repository.User.GetUserAsync(order.SellerId, trackChanges);
                var orderProduct = await _repository.Product.GetProductAsync(order.ProductId, trackChanges);

                if (orderProduct != null && buyer != null && seller != null)
                    ordersReturn.Add(new OrderDto(order.Id, seller, buyer, orderProduct, order.Quantity, order.StatusId));
            }

            return ordersReturn;
        }

        public async Task DeleteOrderAsync(Guid orderId, bool trackChanges)
        {
            var orderEntity = await _repository.Order.GetOrderByIdAsync(orderId, trackChanges: trackChanges);
            if (orderEntity is null)
                throw new Exception();

            await _repository.Order.DeleteOrderAsync(orderEntity);
            await _repository.SaveAsync();
        }

        public async Task UpdateOrderByUserIdAsync(Guid userId, OrderForUpdateDto orderToUpdate, bool trackChanges)
        {
            var orderEntity = _repository.Order.GetOrderByIdAsync(userId, trackChanges);
            if (orderEntity is null)
                throw new OrderNotFoundException(userId);

            await _mapper.Map(orderToUpdate, orderEntity);
            await _repository.SaveAsync();
        }

        public async Task<OrderDto> CreateOrderAsync(Guid userId, OrderForCreationDto order)
        {
            var orderEntity = _mapper.Map<Model.Order>(order);

            if (orderEntity.Id == Guid.Empty)
                orderEntity.Id = Guid.NewGuid();

            await _repository.Order.CreateOrderAsync(userId, orderEntity);
            await _repository.SaveAsync();

            var orderReturn = _mapper.Map<OrderDto>(orderEntity);

            return orderReturn;
        }

        public async Task<OrderDto> GetOrderByIdAsync(Guid orderId, bool trackChanges)
        {
            try
            {
                var orderEntity = await _repository.Order.GetOrderByIdAsync(orderId, trackChanges);
                if (orderEntity == null)
                    throw new OrderNotFoundException(orderId);


                var orderDto = _mapper.Map<OrderDto>(orderEntity);
                return orderDto;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(GetOrderByIdAsync)} : {ex}");
            }
        }
    }
}
