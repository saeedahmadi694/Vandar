using Vandar.AspNetCore.Config;

namespace Vandar.AspNetCore.Services;


public interface IVandarSettingService
{
    void SetSetting(VandarSetting setting);
    void SetIPGSetting(string baseUrl, string token);
    void SetVandarSetting(string baseUrl, string token, string refreshToken, string business);
}