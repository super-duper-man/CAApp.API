using CAApp.Core.Models;
using System.Net.Http.Json;

namespace CAApp.Infrastructure.Services
{
    public class JokeHttpClientService(HttpClient http) : IJokeHttpClientService
    {
        private const string BaseUrl = "/jokes/random";
        public async Task<JokeData?> GetRandomJoke()
        {
            var response = await http.GetFromJsonAsync<JokeData>(BaseUrl);
            return response;
        }
    }
}
