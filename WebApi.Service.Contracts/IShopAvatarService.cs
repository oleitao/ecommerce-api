using Model;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Service.Contracts
{
    public interface IShopAvatarService
    {
        public Task<IEnumerable<ShopAvatarDto>> GetAllShopAvatarsAsync(bool trackChanges);
        public Task<ShopAvatarDto> GetShopAvatarAsync(Guid id, bool trackChanges);
        public Task<ShopAvatarDto> CreateShopAvatarAsync(ShopAvatarForCreationDto shopAvatar);
        public Task UpdateShopAvatar(Guid id, ShopAvatarForUpdateDto shopAvatar, bool trackChanges);
        public Task DeleteShopAvatarAsync(Guid id, bool trackChanges);
    }
}
