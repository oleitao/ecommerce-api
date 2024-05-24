using WebApi.Contracts;
using WebApi.Service.Contracts;

namespace WebApi.Service
{
    internal sealed class ShopService : IShopService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public ShopService(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }
    }
}