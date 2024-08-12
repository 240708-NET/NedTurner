using System.Net.Http.Json;
using System.Text.Json;

public class TipService
{

    private readonly string _baseUri;
    private readonly HttpClient _http;

    public TipService(string uri, HttpClient http)
    {
        _baseUri = uri+"/Tip";
        _http = http;
    }

    public async Task<Tip?> GetTipByOrderId(int order_id)
    {
        string response = await _http.GetStringAsync($"{_baseUri}/tip/order{order_id}");
        return JsonSerializer.Deserialize<Tip>(response);
    }

    public async Task<bool> CreateTip(Tip newTip)
    {
        var response = await _http.PostAsJsonAsync<Tip>($"{_baseUri}/tip",newTip);
        Tip? tipResponse = JsonSerializer.Deserialize<Tip>(response.Content.ReadAsStream());
        return newTip.Equals(tipResponse);
    }
}