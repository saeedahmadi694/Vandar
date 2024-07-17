using Newtonsoft.Json;

namespace Vandar.Dtos;


public class RefreshTokenRequest
{
    [JsonProperty("refreshtoken")]
    public string RefreshToken { get; set; }
}

public class RefreshTokenResponse
{
    [JsonProperty("token_type")]
    public string TokenType { get; set; }
    [JsonProperty("expires_in")]
    public int ExpiresIn { get; set; }
    [JsonProperty("access_token")]
    public string AccessToken { get; set; }
    [JsonProperty("refresh_token")]
    public string RefreshToken { get; set; }
}


public class LogoutResponse
{
    // Define properties based on the actual response
}
