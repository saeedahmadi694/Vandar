namespace Vandar.Repositories;

using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Vandar.Dtos;
using Vandar.InfraServices;

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