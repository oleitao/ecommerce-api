using AutoMapper;
using WebApi.Contracts;
using WebApi.Entities.Exceptions;
using WebApi.Entities.Models;
using WebApi.Service.Contracts;

namespace WebApi.Services
{
    internal sealed class ShopService : IShopService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        public ShopService(IRepositoryManager repository, ILoggerManager logger, AutoMapper.IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public IEnumerable<Shop> GetAllShops(bool trackChanges)
        {
            try
            {
                var shops = _repository.Shop.GetAllShops(trackChanges);
                return shops;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetAllShops)} service method {ex}");
                throw;
            }
        }

        public Shop GetShop(Guid id, bool trackChanges)
        {
            try
            {
                var shop = _repository.Shop.GetShop(id, trackChanges);
                if (shop == null)
                    throw new ShopNotFoundException(id);

                return shop;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetShop)} service method {ex}");
                throw;
            }
        }
    }
}
