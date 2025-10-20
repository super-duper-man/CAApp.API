using CAApp.Core.Interfaces;
using CAApp.Core.Models;
using CAApp.Infrastructure.Services;

namespace CAApp.Infrastructure.Repositories
{
    public class ExternalVendorRepository(JokeHttpClientService jokeHttpClientService) : IExternalVendorRepository
    {
        public async Task<JokeData?> GetRandomJoke()
        {
            return await jokeHttpClientService.GetRandomJoke();
        }
    }
}
