using Vandar.Dtos;

namespace Vandar.InfraServices;

public interface IVandarService
{
    Task<SettlementResponse> RegisterSettlementAsync(int amount, string iban, string trackId, int? paymentNumber = null, string notifyUrl = null, string description = null, bool isInstant = false);
    Task<AuthenticationResponse> RefreshTokenAsync(string refreshToken);
}
