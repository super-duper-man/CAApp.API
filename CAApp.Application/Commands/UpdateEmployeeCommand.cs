using CAApp.Core.Entities;
using CAApp.Core.Interfaces;
using MediatR;

namespace CAApp.Application.Commands
{
    public record UpdateEmployeeCommand(int id, EmployeeEntity employee) : IRequest<EmployeeEntity>;

    internal class UpdateEmployeeCommandHandler(IEmployeeRepository employeeRepository) : IRequestHandler<UpdateEmployeeCommand, EmployeeEntity?>
    {
        public async Task<EmployeeEntity?> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var result = await employeeRepository.UpdateEmployee(request.id, request.employee);
            return result;
        }
    }
}
