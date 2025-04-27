using System.Threading.Tasks;
using VandarSharp.Core.Models;

namespace VandarSharp.Core.InfraServices
{

    public interface IAuthService
    {
        Task<RefreshTokenResponse> RefreshToken();
        Task<LogoutResponse> Logout();
    }



}
