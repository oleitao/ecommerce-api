using Microsoft.AspNetCore.Identity;
using Model;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Service.Contracts
{
    public interface IAuthenticationService
    {
        public Task<IdentityResult> RegisterUser(UserForRegistrationDto userForRegistration);
        public Task<IdentityResult> RegisterSeller(SellerForRegistrationDto userForRegistration);
        public Task<bool> LoginUser(UserForLoginAuthenticationDto userForAuth);
        public Task<TokenDto> GenerateToken(bool populateExp);
        public Task<TokenDto> RefreshToken(TokenDto token);
        public Task<string> GenerateEmailConfirmationTokenAsync(User user);
        public Task<bool> CheckOldPassword(string email, ChangeUserPasswordDto userForAuth);
        public Task<bool> ChangePassword(string email, string password, string passwordConfirmation);
    }
}
