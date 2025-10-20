using CAApp.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CAApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExternalVendorController(ISender sender) : ControllerBase
    {
        [HttpGet]
        public async Task<IResult> GetRandomJoke()
        {
            return Results.Ok(await sender.Send(new GetRandomJokeQuery()));
        }
    }
}
