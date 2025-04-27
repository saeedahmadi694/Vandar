using System;
using System.Net.Http;
using System.Threading.Tasks;
using VandarSharp.Core.InfraServices;
using VandarSharp.Core.Models;

namespace VandarSharp.Core.Repositories
{
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
}