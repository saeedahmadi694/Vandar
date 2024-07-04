using Vandar.Dtos;

namespace Vandar.InfraServices;

public interface ISettlementService
{
    Task<SettlementListResponse> GetList();
    Task<SettlementStoreResponse> Store(SettlementStoreRequest request);
    Task<SettlementShowResponse> Show(string id);
    Task<SettlementDestroyResponse> Destroy(string transactionId);
}

public class SettlementStoreRequest
{
    public int Amount { get; set; }
    public string Iban { get; set; }
    public string TrackId { get; set; }
    public string PaymentNumber { get; set; }
    public string NotifyUrl { get; set; }
    public bool IsInstant { get; set; }
}

public class SettlementListResponse
{
    // Define properties based on the actual response
}

public class SettlementStoreResponse
{
    // Define properties based on the actual response
}

public class SettlementShowResponse
{
    // Define properties based on the actual response
}

public class SettlementDestroyResponse
{
    // Define properties based on the actual response
}
