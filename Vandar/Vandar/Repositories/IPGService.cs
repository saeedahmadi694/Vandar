namespace Vandar.Repositories;

using System.Net.Http;
using System.Threading.Tasks;
using Vandar.Dtos;
using Vandar.InfraServices;

public class IPGService : IIPGService
{
    private readonly HttpClient _httpClient;
    private readonly string _apiBaseUrl;
    private readonly string _token;
    private readonly string _business;

    public IPGService(string apiBaseUrl, string token, string business)
    {
        _apiBaseUrl = apiBaseUrl;
        _token = token;
        _business = business;
        _httpClient = new HttpClient();
    }

    public Task<BaseResponse<TransactionInfoResponse>> GetTransactionInfo(TransactionInfoRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<BaseResponse<SendResponse>> Send(SendRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<BaseResponse<VerifyResponse>> Verify(VerifyRequest request)
    {
        throw new NotImplementedException();
    }
}