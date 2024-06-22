using AutoMapper;
using Model;
using WebApi.Contracts;
using WebApi.Entities.Exceptions;
using WebApi.Service.Contracts;
using WebApi.Shared.DataTransferObjects;

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

        #region Sync

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

        public ShopDto CreateShop(ShopForCreationDto shop)
        {
            var shopEntity = _mapper.Map<Shop>(shop);

            _repository.Shop.CreateShop(shopEntity);
            _repository.Save();

            var shopReturn = _mapper.Map<ShopDto>(shopEntity);

            return shopReturn;
        }

        #endregion

        #region Async

        public async Task<IEnumerable<Shop>> GetAllShopsAsync(bool trackChanges)
        {
            try
            {
                var shops = await _repository.Shop.GetAllShopsAsync(trackChanges);
                if (shops is null)
                    throw new ShopsNotFoundException();

                List<Shop> shopsList = new List<Shop>();
                foreach (var shop in shops)
                {
                    shopsList.Add(await GetShopByIdAsync(shop.Id, trackChanges));
                }

                return shopsList;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetAllShopsAsync)} service method {ex}");
                throw;
            }
        }

        public async Task<Shop> GetShopAsync(Guid id, bool trackChanges)
        {
            try
            {
                var shop = await GetShopByIdAsync(id, trackChanges);
                if (shop == null)
                    throw new ShopNotFoundException(id);

                return shop;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetShopAsync)} service method {ex}");
                throw;
            }
        }

        public async Task<Shop> GetShopByIdAsync(Guid id, bool trackChanges)
        {
            var shop = await _repository.Shop.GetShopAsync(id, trackChanges);
            if(shop is null)
                throw new ShopNotFoundException(id);

            var shopAvatar = await _repository.ShopAvatar.GetShopAvatarAsync(shop.ShopAvatarId, trackChanges);
            if (shopAvatar is null)
                throw new ShopNotFoundException(shop.ShopAvatarId);

            shop.Shop_avatar = shopAvatar;

            return shop;
        }

        public async Task<ShopDto> CreateShopAsync(ShopForCreationDto shop)
        {
            var shopEntity = _mapper.Map<Shop>(shop);
            if(shopEntity.Id.Equals(Guid.Empty))
                shopEntity.Id = Guid.NewGuid();

            var shopAvatarEntity = _mapper.Map<ShopAvatar>(shop.Shop_avatar);
            if(shopAvatarEntity.Id.Equals(Guid.Empty))
                shopAvatarEntity.Id = Guid.NewGuid();
            
            shopEntity.ShopAvatarId = shopAvatarEntity.Id;
            shopEntity.Shop_avatar = shopAvatarEntity;

            _repository.ShopAvatar.CreateShopAvatar(shopAvatarEntity);
            _repository.Shop.CreateShop(shopEntity);

            await _repository.SaveAsync();

            var shopReturn = _mapper.Map<ShopDto>(shopEntity);

            return shopReturn;
        }

        public async Task UpdateShopAsync(Guid id, ShopForUpdateDto model, bool trackChanges)
        {
            var shopEntitie = await _repository.Shop.GetShopAsync(id, trackChanges);
            if (shopEntitie is null)
                throw new ShopNotFoundException(id);


            _mapper.Map(model, shopEntitie);
            await _repository.SaveAsync();
        }

        public async Task DeleteShopAsync(Guid id, bool trackChanges)
        {
            var shop = await _repository.Shop.GetShopAsync(id, trackChanges: trackChanges);
            if (shop is null)
                throw new Exception();

            _repository.Shop.DeleteShop(shop);
            await _repository.SaveAsync();
        }

        public async Task DeleteShopByProductIdAsync(Guid productId, bool trackChanges)
        {
            var shops = await _repository.Shop.GetShopByProductIdAsync(productId, trackChanges);
            if (shops is null)
                throw new ShopsNotFoundException();


            _repository.Shop.DeleteShopsByProductIdAsync(shops);
            await _repository.SaveAsync();
        }

        #endregion
    }
}
