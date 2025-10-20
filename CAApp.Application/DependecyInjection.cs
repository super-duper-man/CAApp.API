using MediatR.NotificationPublishers;
using Microsoft.Extensions.DependencyInjection;

namespace CAApp.Application
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddApplicationDI(this IServiceCollection service)
        {
            service.AddMediatR(cfg => { 
                cfg.RegisterServicesFromAssembly(typeof(DependecyInjection).Assembly);
                cfg.NotificationPublisher = new TaskWhenAllPublisher();
            });
            return service;
        }
    }
}
