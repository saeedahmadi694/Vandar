using System.Threading.Tasks;
using VandarSharp.Core.Models;

namespace VandarSharp.Core.InfraServices
{


    public interface IBusinessService
    {
        Task<BaseResponse<BusinessInfoResponse>> GetInfo();
        Task<BaseResponse<BusinessUsersResponse>> GetUsers();
    }


    public class BusinessUsersResponse
    {
        // Define properties based on the actual response
    }
}
