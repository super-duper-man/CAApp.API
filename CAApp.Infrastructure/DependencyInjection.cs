using CAApp.Core.Interfaces;
using CAApp.Infrastructure.Data;
using CAApp.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CAApp.Infrastructure
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection service)
        {
            service.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer("Server=DATX107_SOFT;Database=CAAppDb;Trusted_connection=true;TrustServerCertificate=True;");
            });

            service.AddScoped<IEmployeeRepository, EmployeeRepository>();

            return service;
        }
    }
}
