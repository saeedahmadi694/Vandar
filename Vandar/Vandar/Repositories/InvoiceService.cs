using System;
using System.Net.Http;
using System.Threading.Tasks;
using Vandar.Dtos;
using Vandar.InfraServices;

namespace Vandar.Repositories
{
    public class InvoiceService : IInvoiceService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiBaseUrl;
        private readonly string _token;
        private readonly string _business;

        public InvoiceService(string apiBaseUrl, string token, string business)
        {
            _apiBaseUrl = apiBaseUrl;
            _token = token;
            _business = business;
            _httpClient = new HttpClient();
        }

        public Task<BaseResponse<BalanceResponse>> GetBalance(string business)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<TransactionsQueryResponse>> GetTransactionsQuery(string business, TransactionsQueryRequest request)
        {
            throw new NotImplementedException();
        }
    }
}