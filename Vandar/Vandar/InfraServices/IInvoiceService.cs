using Vandar.Dtos;

namespace Vandar.InfraServices;

public interface IInvoiceService 
{
    Task<BaseResponse<BalanceResponse>> GetBalance(string business);
    Task<BaseResponse<TransactionsQueryResponse>> GetTransactionsQuery(string business, TransactionsQueryRequest request);
}

public class BalanceResponse
{
    // Define properties based on the actual response
}

public class TransactionsQueryRequest
{
    public string FromDate { get; set; }
    public string ToDate { get; set; }
    public string StatusKind { get; set; }
    public string Status { get; set; }
    public string Channel { get; set; }
    public string RefId { get; set; }
    public string TrackingCode { get; set; }
    public int PerPage { get; set; }
}

public class TransactionsQueryResponse
{
    // Define properties based on the actual response
}