﻿using Model;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Service.Contracts
{
    public interface IShopAvatarService
    {
        #region Sync
        public IEnumerable<ShopAvatar> GetAllShopAvatars(bool trackChanges);
        public ShopAvatar GetShopAvatar(Guid id, bool trackChanges);
        public ShopAvatarDto CreateShopAvatar(ShopAvatarForCreationDto shopAvatar);
        #endregion

        #region Async
        public Task<IEnumerable<ShopAvatar>> GetAllShopAvatarsAsync(bool trackChanges);
        public Task<ShopAvatar> GetShopAvatarAsync(Guid id, bool trackChanges);
        public Task<ShopAvatarDto> CreateShopAvatarAsync(ShopAvatarForCreationDto shopAvatar);
        Task UpdateShopAvatar(Guid id, ShopAvatarForUpdateDto shopAvatar, bool trackChanges);
        Task DeleteShopAvatar(Guid id, bool trackChanges);
        #endregion
    }
}
