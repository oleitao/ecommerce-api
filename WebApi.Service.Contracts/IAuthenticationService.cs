using Microsoft.AspNetCore.Identity;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Service.Contracts
{
    public interface IAuthenticationService
    {
        Task<IdentityResult> RegisterUser(UserForRegistrationDto userForRegistration);
        Task<bool> LoginUser(UserForAuthenticationDto userForAuth); 
        Task<TokenDto> GenerateToken(bool populateExp);
        Task<TokenDto> RefreshToken(TokenDto token);
    }
}
