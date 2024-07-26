namespace Vandar.Repositories;

using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Vandar.Dtos;
using Vandar.HtppHandler;
using Vandar.InfraServices;

public class AuthService : IAuthService
{
    private readonly HttpClient _httpClient;
    private readonly string _apiBaseUrl;
    private readonly string _token;
    private readonly string _reFereshToken;

    public AuthService(string apiBaseUrl, string token, string reFereshToken)
    {
        _apiBaseUrl = apiBaseUrl;
        _token = token;
        _reFereshToken = reFereshToken;
        _httpClient = new HttpClient();
    }



    public async Task<LogoutResponse> Logout()
    {
        return await VandarHtppHandler<LogoutResponse>
            .SendRequest(_httpClient, HttpMethod.Get, _apiBaseUrl + "v3/logout", _token);
    }

    public async Task<RefreshTokenResponse> RefreshToken()
    {
        if (string.IsNullOrEmpty(_reFereshToken)) throw new ArgumentNullException(nameof(_reFereshToken));

        var request = new RefreshTokenRequest { RefreshToken = _reFereshToken };

        return await VandarHtppHandler<RefreshTokenResponse>
               .SendRequest(_httpClient, HttpMethod.Post, _apiBaseUrl + "v3/refreshtoken", "", request);
    }
}