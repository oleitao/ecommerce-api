using Microsoft.EntityFrameworkCore;
using Model;
using WebApi.Contracts;

namespace WebApi.Repository
{
    public class OrderStatusRepository : RepositoryBase<OrderStatus>, IOrderStatusRepository
    {
        public OrderStatusRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }

        public async Task<OrderStatus?> GetOrderStatusByIdAsync(Guid orderStatusId, bool trackChanges)
        {
            return await FindByCondition(c => c.Id.Equals(orderStatusId), trackChanges).SingleOrDefaultAsync();
        }
    }
}
