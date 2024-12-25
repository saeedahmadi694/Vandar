using Encryptor.AspNetCore.Config;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Vandar.AspNetCore.Services;
using Vandar.InfraServices;
using Vandar.Repositories;

namespace Vandar.AspNetCore.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddVandarService(this IServiceCollection services, Action<VandarSetting> configure)
    {
        services.Configure(configure);

        services.AddScoped((Func<IServiceProvider, IVandarBaseService>)(sp =>
        {
            var vandarSetting = sp.GetRequiredService<IOptionsMonitor<VandarSetting>>().CurrentValue;
            return new VandarBaseService(
                vandarSetting.BaseUrl,
                vandarSetting.Token,
                vandarSetting.RefreshToken,
                vandarSetting.Business,
                vandarSetting.IPGSetting?.BaseUrl ?? "",
                vandarSetting.IPGSetting?.Token ?? ""
            );
        }));

        services.AddSingleton<IVandarSettingService, VandarSettingService>();
        return services;
    }
}

