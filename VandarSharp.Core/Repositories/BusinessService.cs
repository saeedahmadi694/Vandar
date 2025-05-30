﻿using System.Net.Http;
using System.Threading.Tasks;
using VandarSharp.Core.HtppHandler;
using VandarSharp.Core.InfraServices;
using VandarSharp.Core.Models;

namespace VandarSharp.Core.Repositories
{
    public class BusinessService : IBusinessService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiBaseUrl;
        private readonly string _token;
        private readonly string _business;

        public BusinessService(string apiBaseUrl, string token, string business)
        {
            _apiBaseUrl = apiBaseUrl;
            _token = token;
            _business = business;
            _httpClient = new HttpClient();
        }

        public async Task<BaseResponse<BusinessInfoResponse>> GetInfo()
        {
            return await VandarHttpHandler<BaseResponse<BusinessInfoResponse>>
                .SendRequest(_httpClient, HttpMethod.Get, _apiBaseUrl + $"v2/business/{_business}", _token);
        }

        public async Task<BaseResponse<BusinessUsersResponse>> GetUsers()
        {
            return await VandarHttpHandler<BaseResponse<BusinessUsersResponse>>
                .SendRequest(_httpClient, HttpMethod.Get, _apiBaseUrl + $"v2/business/{_business}/iam", _token);
        }
    }
}