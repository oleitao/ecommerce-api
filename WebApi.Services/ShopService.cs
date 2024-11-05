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
        private readonly IMapper _mapper;
        public ShopService(IRepositoryManager repository, AutoMapper.IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Shop>> GetAllShopsAsync(bool trackChanges)
        {
            try
            {
                var shops = await _repository.Shop.GetAllShopsAsync(trackChanges);
                if (shops is null)
                    throw new ShopsNotFoundException();

                return shops;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(GetAllShopsAsync)} : {ex}");
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
                throw new Exception($"{nameof(GetShopAsync)} : {ex}");
            }
        }


        public async Task<List<ShopDto>> GetShopByProductIdAsync(Guid productId, bool trackChanges)
        {
            try
            {
                var shops = await _repository.Shop.GetShopByProductIdAsync(productId, trackChanges);
                if (shops == null)
                    throw new ShopNotFoundException(productId);

                List<ShopDto> shopsList = new List<ShopDto>();
                foreach (var shop in shops)
                {
                    shopsList.Add(new ShopDto(shop.Id, shop.ProductId, shop.Name, shop.Shop_avatar, (int)shop.Ratings, shop.Shop_avatarId));
                }

                return shopsList;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(GetShopByProductIdAsync)} : {ex}");
            }
        }

        public async Task<Shop> GetShopByIdAsync(Guid id, bool trackChanges)
        {
            var shop = await _repository.Shop.GetShopAsync(id, trackChanges);
            if(shop is null)
                throw new ShopNotFoundException(id);

            var shopAvatar = await _repository.ShopAvatar.GetShopAvatarAsync(shop.Shop_avatarId, trackChanges);
            if (shopAvatar is null)
                throw new ShopNotFoundException(shop.Shop_avatarId);

            if (shop.Shop_avatar is null)
                shop.Shop_avatar = new ShopAvatar();

            shop.Shop_avatar = shopAvatar;

            return shop;
        }

        public async Task<ShopDto> CreateShopAsync(SellerShopCreationDto shopCreation)
        {
            Shop shop = new Shop()
            {
                Id = Guid.NewGuid(),
                Name = shopCreation.Name,
                ProductId = Guid.NewGuid(),
                Ratings = 0,
                UserId = shopCreation.UserId,
                Shop_avatar = new ShopAvatar() {
                    Id = Guid.NewGuid(),
                    Public_id = "test",
                    Url= string.Empty
                },
                IsValid = false
            };

            try
            {
                _repository.Shop.CreateShopAsync(shop);
                await _repository.SaveAsync();

                return new ShopDto(shop.Id, shop.ProductId, shop.Name, shop.Shop_avatar, (int)shop.Ratings, shop.Shop_avatar.Id);
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public async Task UpdateShopAsync(Guid id, ShopForUpdateDto shopUpdate, bool trackChanges)
        {
            var shopEntity = await _repository.Shop.GetShopAsync(id, trackChanges);
            if (shopEntity is null)
                throw new ShopNotFoundException(id);

            _mapper.Map(shopUpdate, shopEntity);
            await _repository.Shop.UpdateShop(shopEntity);
            await _repository.SaveAsync();
        }

        public async Task DeleteShopAsync(Guid id, bool trackChanges)
        {
            var shopEntity = await _repository.Shop.GetShopAsync(id, trackChanges: trackChanges);
            if (shopEntity is null)
                throw new Exception();

            await _repository.Shop.DeleteShop(shopEntity);
            await _repository.SaveAsync();
        }

        public async Task DeleteShopByProductIdAsync(Guid productId, bool trackChanges)
        { 
            var shopsEntity = await _repository.Shop.GetShopByProductIdAsync(productId, trackChanges);
            if (shopsEntity is null)
                throw new ShopsNotFoundException();


            await _repository.Shop.DeleteShopsByProductIdAsync(shopsEntity);
            await _repository.SaveAsync();
        }
    }
}
