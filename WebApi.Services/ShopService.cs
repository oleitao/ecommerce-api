﻿using AutoMapper;
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
                return shops;
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
                var shop = await _repository.Shop.GetShopAsync(id, trackChanges);
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

        public async Task<ShopDto> CreateShopAsync(ShopForCreationDto shop)
        {
            var shopEntity = _mapper.Map<Shop>(shop);

            _repository.Shop.CreateShop(shopEntity);
            await _repository.SaveAsync();

            var shopReturn = _mapper.Map<ShopDto>(shopEntity);

            return shopReturn;
        }

        public Task UpdateShopAsync(Guid id, ShopForUpdateDto model, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteShopAsync(Guid id, bool trackChanges)
        {
            var shop = await _repository.Shop.GetShopAsync(id, trackChanges: trackChanges);
            if (shop is null)
                throw new Exception();

            _repository.Shop.DeleteShop(shop);
            await _repository.SaveAsync();
        }

        #endregion
    }
}
