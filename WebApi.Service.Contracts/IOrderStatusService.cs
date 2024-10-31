using System.Dynamic;
using WebApi.Entities.RequestFeatures;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Service.Contracts
{
    public interface IOrderStatusService
    {
        public Task<OrderStatusDto> GetOrderStatusByIdAsync(Guid orderStatusId, bool trackChanges);
    }
}
