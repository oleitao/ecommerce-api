using Model;
using WebApi.Entities.RequestFeatures;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Service.Contracts
{
    public interface IUserService
    {
        #region Users

        public Task<IEnumerable<UserDto>> GetAllUsersAsync(UserParameters userParameters, bool trackChanges);
        public Task<IEnumerable<UserDto>> GetAllUsersAsync(bool trackChanges);
        public Task<UserDto> GetUserAsync(Guid id, bool trackChanges);
        public Task<User> GetUserDetailsAsync(Guid id, bool trackChanges);
        public Task<UserDto> CreateUserAsync(UserForCreationDto user);
        public Task UpdateUserAsync(Guid id, UserForUpdateDto userForUpdate, bool trackChanges);
        public Task UpdateUserAddressAsync(Guid id, UserForAddressUpdateDto userAddressForUpdate, bool trackChanges);
        public Task DeleteUserAsync(Guid id, bool trackChanges);

        #endregion


        #region Sellers

        public Task UpdateSellerAsync(Guid id, SellerForUpdateDto sellerForUpdate, bool trackChanges);

        #endregion


        #region Admins

        public Task UpdateAdminAsync(Guid id, AdminForUpdateDto adminForUpdate, bool trackChanges);
        public Task UpdateAdminAddressAsync(Guid id, AdminForAddressUpdateDto adminAddressForUpdate, bool trackChanges);

        #endregion


        public Task<UserDto> FindByEmailAsync(string email, bool trackChanges);
        public Task<User> FindUserByEmailAsync(string email, bool trackChanges);
        public Task<bool> ConfirmEmailAsync(UserDto user);
        public Task<Model.User> MapToUser(UserDto userEntity);
        public Task<string> GetUserRolesById(Guid id);
    }
}
