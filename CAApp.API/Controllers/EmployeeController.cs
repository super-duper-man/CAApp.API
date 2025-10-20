using CAApp.Application.Commands;
using CAApp.Application.Queries;
using CAApp.Core.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CAApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(ISender sender) : ControllerBase
    {
        [HttpGet]
        public async Task<IResult> GetAllEmployees()
        {
            var result = await sender.Send(new GetAllEmployeesQuery());
            return Results.Ok(result);
        }

        [HttpPost]
        public async Task<IResult> AddEmployee([FromBody] EmployeeEntity employee)
        {
            var result = await sender.Send(new AddEmployeeCommand(employee));
            return Results.Ok(result);
        }
    }
}
