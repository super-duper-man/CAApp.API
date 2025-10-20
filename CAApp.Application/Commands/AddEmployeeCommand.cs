using CAApp.Core.Entities;
using CAApp.Core.Interfaces;
using MediatR;

namespace CAApp.Application.Commands
{
    public record AddEmployeeCommand(EmployeeEntity employee): IRequest<EmployeeEntity>;

    public class AddEmployeeCommandHandler(IEmployeeRepository employeeRepository) : IRequestHandler<AddEmployeeCommand, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            var addedEmployee = await employeeRepository.AddEmployee(request.employee);
            return addedEmployee;
        }
    }
}
