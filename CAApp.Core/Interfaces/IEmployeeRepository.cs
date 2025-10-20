using CAApp.Core.Entities;

namespace CAApp.Core.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<EmployeeEntity>> GetEmployees();
        Task<EmployeeEntity?> GetEmployeeByID(int id);
        Task<EmployeeEntity> AddEmployee(EmployeeEntity employee);
        Task<EmployeeEntity?> UpdateEmployee(int id, EmployeeEntity employee);
        Task<bool> DeleteEmployee(int id);
    }
}
