namespace Vandar.Repositories;
using Encryptor.AspNetCore.Config;

using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Vandar.AspNetCore.Services;
using Vandar.Dtos;
using Vandar.HtppHandler;
using Vandar.InfraServices;

public class VandarSettingService : IVandarSettingService
{
    private readonly IOptionsMonitorCache<VandarSetting> _cache;
    private readonly VandarSetting _vandarSetting;
    public VandarSettingService(IOptionsMonitorCache<VandarSetting> cache, IOptionsMonitor<VandarSetting> vandarSetting)
    {
        _cache = cache;
        _vandarSetting = vandarSetting.CurrentValue;
    }

    public void SetIPGSetting(string baseUrl, string token)
    {
        var item = _vandarSetting;
        item.IPGSetting = new IPGSetting
        {
            Token = token,
            BaseUrl = baseUrl
        };
        _cache.TryRemove(string.Empty);
        _cache.TryAdd(string.Empty, item);
    }

    public void SetSetting(VandarSetting setting)
    {
        _cache.TryRemove(string.Empty);
        _cache.TryAdd(string.Empty, setting);
    }

    public void SetVandarSetting(string baseUrl, string token, string refreshToken, string business)
    {
        var item = _vandarSetting;
        item.BaseUrl = baseUrl;
        item.Token = token;
        item.RefreshToken = refreshToken;
        item.Business = business;

        _cache.TryRemove(string.Empty);
        _cache.TryAdd(string.Empty, item);
    }

}