using Vandar.Dtos;

namespace Vandar.InfraServices;


public interface IAuthService 
{
    Task<RefreshTokenResponse> RefreshToken(RefreshTokenRequest request);
    Task<LogoutResponse> Logout();
}



