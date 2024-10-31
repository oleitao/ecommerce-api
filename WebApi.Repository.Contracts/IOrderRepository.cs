using Model;
using WebApi.Entities.RequestFeatures;

namespace WebApi.Contracts
{
    public interface IOrderRepository
    {
        public Task<IEnumerable<Order>> GetAllOrdersAsync(bool trackChanges);
        public Task<Order>? GetOrderByIdAsync(Guid orderId, bool trackChanges);
        public Task<List<Order>>? GetOrdersByBuyerIdAsync(Guid userId, bool trackChanges);
        public Task<List<Order>>? GetOrderBySellerIdAsync(Guid userId, bool trackChanges);
        public Task<bool?> UpdateOrderByUserIdAsync(Guid userId, Order order, bool trackChanges);
        public Task CreateOrderAsync(Guid userId, Order order);
        public Task DeleteOrderAsync(Order order);
    }
}
