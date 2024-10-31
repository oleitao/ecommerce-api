using System.Dynamic;
using WebApi.Entities.RequestFeatures;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Service.Contracts
{
    public interface IOrderService
    {
        public Task<IEnumerable<OrderDto>> GetAllOrdersAsync(bool trackChanges);
        public Task<OrderDto> GetOrderByIdAsync(Guid orderId, bool trackChanges);
        public Task<List<OrderDto>> GetOrderByBuyerIdAsync(Guid userId, bool trackChanges);
        public Task<List<OrderDto>> GetOrderBySellerIdAsync(Guid userId, bool trackChanges);
        public Task UpdateOrderByUserIdAsync(Guid userId, OrderForUpdateDto orderToUpdate, bool trackChanges);
        public Task<OrderDto> CreateOrderAsync(Guid userId, OrderForCreationDto order);
        public Task DeleteOrderAsync(Guid orderId, bool trackChanges);
    }
}
