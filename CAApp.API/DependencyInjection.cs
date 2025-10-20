using CAApp.Application;
using CAApp.Infrastructure;

namespace CAApp.API
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddAppDI(this IServiceCollection service)
        {
            service.AddApplicationDI()
                   .AddInfrastructureDI();

            return service;
        }
    }
}
