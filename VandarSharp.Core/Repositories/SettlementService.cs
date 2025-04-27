using System.Net.Http;
using System.Threading.Tasks;
using VandarSharp.Core.HtppHandler;
using VandarSharp.Core.InfraServices;
using VandarSharp.Core.Models;

namespace VandarSharp.Core.Repositories
{
    public class SettlementService : ISettlementService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiBaseUrl;
        private readonly string _token;
        private readonly string _business;

        public SettlementService(string apiBaseUrl, string token, string business)
        {
            _apiBaseUrl = apiBaseUrl;
            _token = token;
            _business = business;
            _httpClient = new HttpClient();
        }


        public async Task<BaseResponse<string>> Destroy(string transactionId)
        {
            return await VandarHttpHandler<BaseResponse<string>>
                .SendRequest(_httpClient, HttpMethod.Delete, _apiBaseUrl + $"v2.1/business/{_business}/settlement/{transactionId}", _token);
        }

        public async Task<BaseResponse<SettlementListResponse>> GetList()
        {
            return await VandarHttpHandler<BaseResponse<SettlementListResponse>>
                .SendRequest(_httpClient, HttpMethod.Get, _apiBaseUrl + $"v3/business/{_business}/settlement", _token);
        }

        public async Task<BaseResponse<SettlementShowResponse>> Show(string id)
        {
            return await VandarHttpHandler<BaseResponse<SettlementShowResponse>>
                .SendRequest(_httpClient, HttpMethod.Get, _apiBaseUrl + $"v2.1/business/{_business}/settlement/{id}", _token);
        }

        public async Task<BaseResponse<SettlementStoreResponse>> Store(SettlementStoreRequest request)
        {
            return await VandarHttpHandler<BaseResponse<SettlementStoreResponse>>
                .SendRequest(_httpClient, HttpMethod.Post, _apiBaseUrl + $"v3/business/{_business}/settlement/store", _token, request);
        }
    }
}