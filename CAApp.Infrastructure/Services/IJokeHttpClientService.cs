using CAApp.Core.Models;

namespace CAApp.Infrastructure.Services
{
    public interface IJokeHttpClientService
    {
        Task<JokeData?> GetRandomJoke();
    }
}