
using Newtonsoft.Json;
using System.Text;
using Vandar.Dtos;
using Vandar.ExceptionHandler;

namespace Vandar.HtppHandler;

public static class VandarHtppHandler<T> where T : class
{
    public static async Task<T> SendRequest(HttpClient _httpClient, HttpMethod method, string endpoint, string token = "", object data = null)
    {
        _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

        if (!string.IsNullOrWhiteSpace(token))
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

        try
        {
            var request = new HttpRequestMessage(method, endpoint);

            if (data != null)
            {
                request.Content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
            }

            var response = await _httpClient.SendAsync(request);

            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                throw new VandarApiException($"API request failed: {response.StatusCode}", errorContent);
            }

            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(content);
        }
        catch (HttpRequestException e)
        {
            throw new VandarApiException("Network error occurred", e);
        }
        catch (JsonException e)
        {
            throw new VandarApiException("Error deserializing response", e);
        }

    }

}
