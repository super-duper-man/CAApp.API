using CAApp.Core.Entities;
using CAApp.Core.Interfaces;
using CAApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CAApp.Infrastructure.Repositories
{
    public class EmployeeRepository(AppDbContext dbContext) : IEmployeeRepository
    {
        public async Task<IEnumerable<EmployeeEntity>> GetEmployees()
        {
            return await dbContext.Employees.ToListAsync();
        }

        public async Task<EmployeeEntity?> GetEmployeeByID(int id)
        {
            return await dbContext.Employees.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<EmployeeEntity> AddEmployee(EmployeeEntity employee)
        {
            dbContext.Employees.Add(employee);
            await dbContext.SaveChangesAsync();
            return employee;
        }

        public async Task<EmployeeEntity?> UpdateEmployee(int id, EmployeeEntity employee)
        {
            var _employee = await dbContext.Employees.FirstOrDefaultAsync(x => x.Id == id);
            if (_employee == null) {
                return null;
            }

            _employee.Email = employee.Email;
            _employee.FullName = employee.FullName;
            _employee.Phone = employee.Phone;

            await dbContext.SaveChangesAsync();
            return _employee;
        }

        public async Task<bool> DeleteEmployee(int id)
        {
            var employee = await dbContext.Employees.FirstOrDefaultAsync(x => x.Id == id);
            if (employee is not null)
            {
                dbContext.Employees.Remove(employee);
                return await dbContext.SaveChangesAsync() > 0;
            }
             
            return false;
        }
    }
}
