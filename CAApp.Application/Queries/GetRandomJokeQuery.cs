using CAApp.Core.Interfaces;
using CAApp.Core.Models;
using MediatR;

namespace CAApp.Application.Queries
{
    public record GetRandomJokeQuery : IRequest<JokeData?>;
    internal class GetRandomJokeQueryHandler(IExternalVendorRepository externalRepository) : IRequestHandler<GetRandomJokeQuery, JokeData?>
    {
        public async Task<JokeData?> Handle(GetRandomJokeQuery request, CancellationToken cancellationToken)
        {
            return await externalRepository.GetRandomJoke();
        }
    }
}
