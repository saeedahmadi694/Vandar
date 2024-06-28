namespace Vandar.Repositories;

using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Vandar.Dtos;
using Vandar.InfraServices;

public class VandarService : IVandarService
{
    private readonly HttpClient _httpClient;
    private readonly string _apiBaseUrl;
    private readonly string _token;
    private readonly string _business;

    public VandarService(string apiBaseUrl, string token, string business)
    {
        _apiBaseUrl = apiBaseUrl;
        _token = token;
        _business = business;
        _httpClient = new HttpClient();
        _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
    }

    public async Task<SettlementResponse> RegisterSettlementAsync(int amount, string iban, string trackId, int? paymentNumber = null, string notifyUrl = null, string description = null, bool isInstant = false)
    {
        var requestBody = new
        {
            amount = amount.ToString(),
            iban,
            track_id = trackId,
            type = "A2A",
            is_instant = isInstant ? 1 : 0,
            notify_url = notifyUrl,
            payment_number = paymentNumber,
            description
        };

        var requestContent = new StringContent(JsonSerializer.Serialize(requestBody), Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync($"{_apiBaseUrl}/v3/business/{_business}/settlement/store", requestContent);

        response.EnsureSuccessStatusCode();

        var responseContent = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<SettlementResponse>(responseContent);
    }

    public async Task<AuthenticationResponse> RefreshTokenAsync(string refreshToken)
    {
        var requestBody = new
        {
            refreshtoken = refreshToken
        };

        var requestContent = new StringContent(JsonSerializer.Serialize(requestBody), Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync($"{_apiBaseUrl}/v3/refreshtoken", requestContent);

        response.EnsureSuccessStatusCode();

        var responseContent = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<AuthenticationResponse>(responseContent);
    }
}