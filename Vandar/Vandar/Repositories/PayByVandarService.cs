namespace Vandar.Repositories;

using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Vandar.Dtos;
using Vandar.InfraServices;

public class PayByVandarService : IPayByVandarService
{
    private readonly HttpClient _httpClient;
    private readonly string _apiBaseUrl;
    private readonly string _token;
    private readonly string _business;

    public PayByVandarService(string apiBaseUrl, string token, string business)
    {
        _apiBaseUrl = apiBaseUrl;
        _token = token;
        _business = business;
        _httpClient = new HttpClient();
    }

    public Task<BaseResponse<PayByVandarInquiryResponse>> Inquiry(string checkoutId)
    {
        throw new NotImplementedException();
    }

    public Task<BaseResponse<PayByVandarSendResponse>> Send(PayByVandarSendRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<BaseResponse<PayByVandarVerifyResponse>> Verify(PayByVandarVerifyRequest request)
    {
        throw new NotImplementedException();
    }
}