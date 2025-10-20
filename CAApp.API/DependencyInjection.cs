using CAApp.Application;
using CAApp.Core;
using CAApp.Infrastructure;

namespace CAApp.API
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddAppDI(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddApplicationDI()
                   .AddInfrastructureDI()
                   .AddCoreDI(configuration);

            return service;
        }
    }
}
