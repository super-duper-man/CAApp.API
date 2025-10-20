using CAApp.Core.Models;
using System.Net.Http.Json;

namespace CAApp.Infrastructure.Services
{
    public class JokeHttpClientService(HttpClient http)
    {
        private const string BaseUrl = "https://official-joke-api.appspot.com/jokes/random";
        public async Task<JokeData?> GetRandomJoke(CancellationToken cancellationToken = default)
        {
            var response = await http.GetFromJsonAsync<JokeData>(BaseUrl);
            return response;
        }
    }
}
