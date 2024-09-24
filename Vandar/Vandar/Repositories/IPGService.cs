namespace Vandar.Repositories;
using System.Net.Http;
using System.Threading.Tasks;
using Vandar.Dtos;
using Vandar.HtppHandler;
using Vandar.InfraServices;

public class IPGService : IIPGService
{
    private readonly HttpClient _httpClient;
    private readonly string _ipgApiBaseUrl;

    public IPGService(string ipgApiBaseUrl)
    {
        _ipgApiBaseUrl = ipgApiBaseUrl;
        _httpClient = new HttpClient();
    }

    public async Task<SendTransactionResponseDto> SendTransactionDetailsAsync(SendTransactionRequestDto request)
    {
        return await VandarHttpHandler<SendTransactionResponseDto>
         .SendRequest(_httpClient, HttpMethod.Post, _ipgApiBaseUrl + $"api/v4/send", "", request);
    }

    public string RedirectToPaymentPage(string token)
    {
        var paymentUrl = $"{_ipgApiBaseUrl}v4/{token}";
        return paymentUrl;
    }

    public async Task<TransactionInfoResponseDto> GetTransactionInfoAsync(TransactionInfoRequestDto request)
    {
        return await VandarHttpHandler<TransactionInfoResponseDto>
            .SendRequest(_httpClient, HttpMethod.Post, _ipgApiBaseUrl + $"api/v4/transaction", "", request);
    }

    public async Task<VerifyTransactionResponseDto> VerifyTransactionAsync(VerifyTransactionRequestDto request)
    {
        return await VandarHttpHandler<VerifyTransactionResponseDto>
              .SendRequest(_httpClient, HttpMethod.Post, _ipgApiBaseUrl + $"api/v4/verify", "", request);
    }
}