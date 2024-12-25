using Encryptor.AspNetCore.Config;
using Vandar.Presenter.Models.SettingAggregate;

namespace Vandar.Presenter.Models;
public static class SettingAdapter
{

    public static VandarSetting ToVandarSettingModel(this Setting input)
    {
        return new VandarSetting
        {
            Business = input.Vandar.Business ?? "",
            RefreshToken = input.Vandar?.RefreshToken ?? "",
            Token = input.Vandar?.Token ?? "",
            BaseUrl = input.Vandar?.BaseUrl ?? "",
            IPGSetting = new IPGSetting
            {
                Token = input.IPG?.Token ?? "",
                BaseUrl = input.IPG?.BaseUrl ?? ""
            }
        };
    }
}
