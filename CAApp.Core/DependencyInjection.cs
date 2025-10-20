using CAApp.Core.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CAApp.Core
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddCoreDI(this IServiceCollection service, IConfiguration configuration)
        {
            service.Configure<ConnectionStringOptions>(configuration.GetSection(ConnectionStringOptions.SectionName));
            return service;
        }
    }
}
