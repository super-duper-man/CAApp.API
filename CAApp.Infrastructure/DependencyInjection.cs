using CAApp.Core.Interfaces;
using CAApp.Core.Options;
using CAApp.Infrastructure.Data;
using CAApp.Infrastructure.Repositories;
using CAApp.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace CAApp.Infrastructure
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection service)
        {
            service.AddDbContext<AppDbContext>((provider, options) =>
            {
                options.UseSqlServer(provider.GetRequiredService<IOptionsSnapshot<ConnectionStringOptions>>().Value.DefaultConnection);
            });

            service.AddScoped<IEmployeeRepository, EmployeeRepository>();
            service.AddScoped<IExternalVendorRepository, ExternalVendorRepository>();
            service.AddHttpClient<JokeHttpClientService>(options =>
            {
                options.BaseAddress = new Uri("https://official-joke-api.appspot.com");
            });

            return service;
        }
    }
}
