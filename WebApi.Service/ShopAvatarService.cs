﻿using WebApi.Contracts;
using WebApi.Entities.Exceptions;
using WebApi.Entities.Models;
using WebApi.Service.Contracts;

namespace WebApi.Service
{
    internal sealed class ShopAvatarService : IShopAvatarService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public ShopAvatarService(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public IEnumerable<ShopAvatar> GetAllShopAvatars(bool trackChanges)
        {
            try
            {
                var shopAvatars = _repository.ShopAvatar.GetAllShopAvatars(trackChanges);
                return shopAvatars;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetAllShopAvatars)} service method {ex}");
                throw;
            }
        }

        public ShopAvatar GetShopAvatar(Guid id, bool trackChanges)
        {
            try
            {
                var shopAvatar = _repository.ShopAvatar.GetShopAvatar(id, trackChanges);
                if (shopAvatar == null)
                    throw new ShopAvatarNotFoundException(id);

                return shopAvatar;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetShopAvatar)} service method {ex}");
                throw;
            }
        }
    }
}