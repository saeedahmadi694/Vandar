using Vandar.Dtos;

namespace Vandar.InfraServices;


public interface IAuthService 
{
    Task<RefreshTokenResponse> RefreshToken(RefreshTokenRequest request);
    Task<LogoutResponse> Logout();
}

public class RefreshTokenRequest
{
    public string RefreshToken { get; set; }
}

public class RefreshTokenResponse
{
    // Define properties based on the actual response
}

public class LogoutResponse
{
    // Define properties based on the actual response
}

