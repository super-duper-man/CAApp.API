using CAApp.Core.Entities;
using CAApp.Core.Interfaces;
using MediatR;

namespace CAApp.Application.Queries
{
    public record GetAllEmployeesQuery: IRequest<IEnumerable<EmployeeEntity>>;

    public class GetAllEmployeeQueryHandler(IEmployeeRepository employeeRepository) : IRequestHandler<GetAllEmployeesQuery, IEnumerable<EmployeeEntity>>
    {
        public async Task<IEnumerable<EmployeeEntity>> Handle(GetAllEmployeesQuery request, CancellationToken cancellationToken)
        {
           return await employeeRepository.GetEmployees();
        }
    }
}
