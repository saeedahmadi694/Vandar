namespace Vandar.AspNetCore.Config;

public class VandarSetting
{
    public string BaseUrl { get; set; }
    public string Token { get; set; }
    public string RefreshToken { get; set; }
    public string Business { get; set; }
    public IPGSetting? IPGSetting { get; set; }
}
public class IPGSetting
{
    public string BaseUrl { get; set; }
    public string Token { get; set; }
}