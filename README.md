# vandar




    var vandar = new VandarSettings();
    vandar = configuration.GetSection(VandarSettings.Key).Get<VandarSettings>();

    services.AddSingleton<IVandarBaseService>(sp =>
    {
        return new VandarBaseService(vandar.ApiBaseUrl, vandar.Token, vandar.RefreshToken, vandar.Business);
    });
    return services;

