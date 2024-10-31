using Microsoft.EntityFrameworkCore;
using Model;
using System.Security.Cryptography.X509Certificates;
using WebApi.Contracts;

namespace WebApi.Repository
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }

        public async Task<IEnumerable<Order>> GetAllOrdersAsync(bool trackChanges)
        {
            return await FindAll(trackChanges).ToListAsync();
        }

        public async Task<List<Order>>? GetOrdersByBuyerIdAsync(Guid userId, bool trackChanges)
        {
            return await FindByCondition(c => c.BuyerId.Equals(userId), trackChanges).ToListAsync();
        }

        public async Task<List<Order>>? GetOrderBySellerIdAsync(Guid userId, bool trackChanges)
        {
            return await FindByCondition(c => c.SellerId.Equals(userId), trackChanges).ToListAsync();
        }

        public Task<bool?> UpdateOrderByUserIdAsync(Guid userId, Order order, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public async Task CreateOrderAsync(Guid userId, Order order)
        {
            await CreateOrderAsync(userId, order).ConfigureAwait(false);
        }

        public async Task DeleteOrderAsync(Order order)
        {
            Delete(order);
        }

        public async Task<Order>? GetOrderByIdAsync(Guid orderId, bool trackChanges)
        {
            return await FindByCondition(c => c.Id.Equals(orderId), trackChanges).FirstOrDefaultAsync();
        }
    }
}
