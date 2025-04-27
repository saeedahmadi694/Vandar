using System.Threading.Tasks;
using VandarSharp.Core.Models;

namespace VandarSharp.Core.InfraServices
{
    public interface ISettlementService
    {
        Task<BaseResponse<SettlementListResponse>> GetList();
        Task<BaseResponse<SettlementStoreResponse>> Store(SettlementStoreRequest request);
        Task<BaseResponse<SettlementShowResponse>> Show(string id);
        Task<BaseResponse<string>> Destroy(string transactionId);
    }




}
