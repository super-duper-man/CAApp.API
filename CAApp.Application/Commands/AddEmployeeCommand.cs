using CAApp.Application.Events;
using CAApp.Core.Entities;
using CAApp.Core.Interfaces;
using MediatR;

namespace CAApp.Application.Commands
{
    public record AddEmployeeCommand(EmployeeEntity employee): IRequest<EmployeeEntity>;

    public class AddEmployeeCommandHandler(IEmployeeRepository employeeRepository, IPublisher publisher) : IRequestHandler<AddEmployeeCommand, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            var user = await employeeRepository.AddEmployee(request.employee);
            await publisher.Publish(new UserCreatedEvent());
            return user;
        }
    }
}
