using Vandar.Dtos;

namespace Vandar.InfraServices;


public interface IIPGService 
{
    Task<BaseResponse<SendResponse>> Send(SendRequest request);
    Task<BaseResponse<TransactionInfoResponse>> GetTransactionInfo(TransactionInfoRequest request);
    Task<BaseResponse<VerifyResponse>> Verify(VerifyRequest request);
}

public class SendRequest
{
    public string ApiKey { get; set; }
    public int Amount { get; set; }
    public string CallbackUrl { get; set; }
    public string MobileNumber { get; set; }
    public string FactorNumber { get; set; }
    public string Description { get; set; }
}

public class SendResponse
{
    public int Status { get; set; }
    public string Token { get; set; }
}

public class TransactionInfoRequest
{
    public string ApiKey { get; set; }
    public string Token { get; set; }
}

public class TransactionInfoResponse
{
    // Define properties based on the actual response
}

public class VerifyRequest
{
    public string ApiKey { get; set; }
    public string Token { get; set; }
}

public class VerifyResponse
{
    // Define properties based on the actual response
}
