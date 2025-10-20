using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace CAApp.Infrastructure
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection service)
        {
            return service;
        }
    }
}
