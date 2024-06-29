using AutoMapper;
using Model;
using WebApi.Contracts;
using WebApi.Entities.Exceptions;
using WebApi.Service.Contracts;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Services
{
    internal sealed class ShopAvatarService : IShopAvatarService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public ShopAvatarService(IRepositoryManager repository, AutoMapper.IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region Sync

        public IEnumerable<ShopAvatar> GetAllShopAvatars(bool trackChanges)
        {
            try
            {
                var shopAvatars = _repository.ShopAvatar.GetAllShopAvatars(trackChanges);
                return shopAvatars;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(GetAllShopAvatars)} : {ex}");
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
                throw new Exception($"{nameof(GetShopAvatar)} : {ex}");
            }
        }

        public ShopAvatarDto CreateShopAvatar(ShopAvatarForCreationDto shopAvatar)
        {
            var shopAvatarEntity = _mapper.Map<ShopAvatar>(shopAvatar);

            _repository.ShopAvatar.CreateShopAvatar(shopAvatarEntity);
            _repository.Save();

            var shopAvatarReturn = _mapper.Map<ShopAvatarDto>(shopAvatarEntity);

            return shopAvatarReturn;
        }

        #endregion

        #region Async

        public async Task<IEnumerable<ShopAvatarDto>> GetAllShopAvatarsAsync(bool trackChanges)
        {
            try
            {
                var shopAvatarsEntity = await _repository.ShopAvatar.GetAllShopAvatarsAsync(trackChanges);
                if (shopAvatarsEntity is null)
                    throw new ShopAvatarsNotFoundException();

                List<ShopAvatarDto> returnList = new List<ShopAvatarDto>();
                foreach (var shopAvatar in shopAvatarsEntity)
                {
                    var shopAvatarReturn = _mapper.Map<ShopAvatarDto>(shopAvatar);
                    returnList.Add(shopAvatarReturn);
                }

                return returnList;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(GetAllShopAvatarsAsync)} : {ex}");
            }
        }

        public async Task<ShopAvatarDto> GetShopAvatarAsync(Guid id, bool trackChanges)
        {
            try
            {
                var shopAvatarEntity = await _repository.ShopAvatar.GetShopAvatarAsync(id, trackChanges);
                if (shopAvatarEntity == null)
                    throw new ShopAvatarNotFoundException(id);

                var shopAvatarReturn = _mapper.Map<ShopAvatarDto>(shopAvatarEntity);

                return shopAvatarReturn;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(GetShopAvatarAsync)} : {ex}");
            }
        }

        public async Task<ShopAvatarDto> CreateShopAvatarAsync(ShopAvatarForCreationDto shopAvatar)
        {
            var shopAvatarEntity = _mapper.Map<ShopAvatar>(shopAvatar);

            if(shopAvatarEntity.Id == Guid.Empty)
                shopAvatarEntity.Id = Guid.NewGuid();

            _repository.ShopAvatar.CreateShopAvatar(shopAvatarEntity);
            await _repository.SaveAsync();

            var shopAvatarReturn = _mapper.Map<ShopAvatarDto>(shopAvatarEntity);

            return shopAvatarReturn;
        }

        public async Task UpdateShopAvatar(Guid id, ShopAvatarForUpdateDto shopAvatar, bool trackChanges)
        {
            var shopAvatarEntitie = await _repository.ShopAvatar.GetShopAvatarAsync(id, trackChanges);
            if (shopAvatarEntitie is null)
                throw new ShopAvatarNotFoundException(id);


            _mapper.Map(shopAvatar, shopAvatarEntitie);
            await _repository.SaveAsync();
        }

        public async Task DeleteShopAvatarAsync(Guid id, bool trackChanges)
        {
            var shopAvatar = await _repository.ShopAvatar.GetShopAvatarAsync(id, trackChanges: trackChanges);
            if (shopAvatar is null)
                throw new Exception();

            _repository.ShopAvatar.DeleteShopAvatarAsync(shopAvatar);
            await _repository.SaveAsync();
        }

        #endregion
    }
}
