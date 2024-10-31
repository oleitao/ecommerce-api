using Model;
using WebApi.Entities.RequestFeatures;

namespace WebApi.Contracts
{
    public interface IOrderStatusRepository
    {
        public Task<OrderStatus?> GetOrderStatusByIdAsync(Guid orderStatusId, bool trackChanges);
    }
}
