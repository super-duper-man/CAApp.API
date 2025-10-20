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

        [HttpGet("{id}")]
        public async Task<IResult> GetEmployeeByID(int id)
        {
            var employee = await sender.Send(new GetEmployeeByIdQuery(id));

            if (employee is null)
                return Results.NotFound();

            return Results.Ok(employee);
        }

        [HttpPost]
        public async Task<IResult> AddEmployee([FromBody] EmployeeEntity employee)
        {
            var result = await sender.Send(new AddEmployeeCommand(employee));
            return Results.Ok(result);
        }
    }
}
