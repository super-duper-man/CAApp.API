using CAApp.Core.Models;

namespace CAApp.Core.Interfaces
{
    public interface IExternalVendorRepository
    {
        Task<JokeData?> GetRandomJoke();
    }
}
