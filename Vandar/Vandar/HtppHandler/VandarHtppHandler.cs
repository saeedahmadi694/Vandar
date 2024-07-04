
using Newtonsoft.Json;
using System.Text;
using Vandar.ExceptionHandler;

namespace Vandar.HtppHandler;

public static class VandarHtppHandler<T> where T : class
{
    public static async Task<T> SendRequest(HttpClient _httpClient, HttpMethod method, string endpoint, string token = "", object data = null)
    {
        if (string.IsNullOrWhiteSpace(token))
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
                throw new VandarHtppHandler($"API request failed: {response.StatusCode}", errorContent);
            }

            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(content);
        }
        catch (HttpRequestException e)
        {
            throw new VandarHtppHandler("Network error occurred", e);
        }
        catch (JsonException e)
        {
            throw new VandarHtppHandler("Error deserializing response", e);
        }


    }

    public static string ToQueryString(object obj)
    {
        var properties = from p in obj.GetType().GetProperties()
                         where p.GetValue(obj, null) != null
                         select p.Name + "=" + Uri.EscapeDataString(p.GetValue(obj, null).ToString());

        return string.Join("&", properties.ToArray());
    }

}
