using CAApp.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CAApp.Infrastructure.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<EmployeeEntity> Employees
        {
            get; set;
        }

    }
}
