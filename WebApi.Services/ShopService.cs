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

        public async Task<IEnumerable<ShopDto>> GetAllShopsAsync(bool trackChanges)
        {
            try
            {
                var shops = await _repository.Shop.GetAllShopsAsync(trackChanges);
                if (shops is null)
                    throw new ShopsNotFoundException();

                List<ShopDto> shopsList = new List<ShopDto>();
                foreach (var shop in shops)
                {
                    var shopReturn = await GetShopByIdAsync(shop.Id, trackChanges);
                    shopsList.Add(shopReturn);
                }

                return shopsList;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetAllShopsAsync)} service method {ex}");
                throw;
            }
        }

        public async Task<ShopDto> GetShopAsync(Guid id, bool trackChanges)
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

        public async Task<ShopDto> GetShopByIdAsync(Guid id, bool trackChanges)
        {
            var shop = await _repository.Shop.GetShopAsync(id, trackChanges);
            if(shop is null)
                throw new ShopNotFoundException(id);

            var shopAvatar = await _repository.ShopAvatar.GetShopAvatarAsync(shop.ShopAvatarId, trackChanges);
            if (shopAvatar is null)
                throw new ShopNotFoundException(shop.ShopAvatarId);

            var returnShop = _mapper.Map<ShopDto>(shop);

            return returnShop;
        }

        public async Task<ShopDto> CreateShopAsync(ShopForCreationDto shopCreation)
        {
            var shopEntity = _mapper.Map<Shop>(shopCreation);
            if(shopEntity.Id.Equals(Guid.Empty))
                shopEntity.Id = Guid.NewGuid();

            if (shopCreation.ShopAvatarId != Guid.Empty && shopCreation.Shop_avatar is null)
            {
                var shopAvatarEntity = await _repository.ShopAvatar.GetShopAvatarAsync(shopCreation.ShopAvatarId, trackChanges: false);
                if(shopAvatarEntity  is null)
                    throw new ShopAvatarNotFoundException(shopCreation.ShopAvatarId);

                shopEntity.Shop_avatar = shopAvatarEntity;
            }
            else if (shopCreation.ShopAvatarId == Guid.Empty && shopCreation.Shop_avatar is not null)
            {
                shopEntity.Shop_avatar = new ShopAvatar()
                {
                    Id = Guid.NewGuid(),
                    Public_id = shopCreation.Shop_avatar.Public_id,
                    Url = shopCreation.Shop_avatar.Url
                };

                shopEntity.ShopAvatarId = shopEntity.Shop_avatar.Id;

                _repository.ShopAvatar.CreateShopAvatar(shopEntity.Shop_avatar);
            }

            _mapper.Map(shopCreation, shopEntity);

            _repository.Shop.CreateShop(shopEntity);

            var returnShop = _mapper.Map<ShopDto>(shopEntity);

            await _repository.SaveAsync();            

            return returnShop;
        }

        public async Task UpdateShopAsync(Guid id, ShopForUpdateDto shopUpdate, bool trackChanges)
        {
            var shopEntity = await _repository.Shop.GetShopAsync(id, trackChanges);
            if (shopEntity is null)
                throw new ShopNotFoundException(id);

            _mapper.Map(shopUpdate, shopEntity);
            _repository.Shop.UpdateShop(shopEntity);
            await _repository.SaveAsync();
        }

        public async Task DeleteShopAsync(Guid id, bool trackChanges)
        {
            var shopEntity = await _repository.Shop.GetShopAsync(id, trackChanges: trackChanges);
            if (shopEntity is null)
                throw new Exception();

            _repository.Shop.DeleteShop(shopEntity);
            await _repository.SaveAsync();
        }

        public async Task DeleteShopByProductIdAsync(Guid productId, bool trackChanges)
        {
            var shopsEntity = await _repository.Shop.GetShopByProductIdAsync(productId, trackChanges);
            if (shopsEntity is null)
                throw new ShopsNotFoundException();


            _repository.Shop.DeleteShopsByProductIdAsync(shopsEntity);
            await _repository.SaveAsync();
        }

        #endregion
    }
}
