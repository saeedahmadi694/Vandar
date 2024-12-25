using System.Threading.Tasks;
using Vandar.Dtos;

namespace Vandar.InfraServices
{

    public interface IAuthService
    {
        Task<RefreshTokenResponse> RefreshToken();
        Task<LogoutResponse> Logout();
    }



}
