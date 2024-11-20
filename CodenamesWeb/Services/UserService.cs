using System.Net.Http.Json;

namespace CodenamesWeb.Services
{
    public class UserService
    {
        private readonly HttpClient _httpClient;

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> InitializeUserAsync(string fingerprint)
        {
            var response = await _httpClient.PostAsJsonAsync("api/users/initialize", new { fingerprint });

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadFromJsonAsync<AnonymousUserResponse>();
                return data.AnonymousId;
            }

            throw new Exception("Не вдалося ініціалізувати користувача");
        }

        public record AnonymousUserResponse(string AnonymousId);
    }
}
