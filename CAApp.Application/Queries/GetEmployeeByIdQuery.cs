using CAApp.Core.Entities;
using CAApp.Core.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAApp.Application.Queries
{
    public record GetEmployeeByIdQuery(int id) : IRequest<EmployeeEntity>;
    public class GetEmployeeByIdQueryHandler(IEmployeeRepository employeeRepository) : IRequestHandler<GetEmployeeByIdQuery, EmployeeEntity?>
    {
        public async Task<EmployeeEntity?> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            return await employeeRepository.GetEmployeeByID(request.id);
        }
    }
}
