using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace CAApp.Core
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddCoreDI(this IServiceCollection service)
        {
            return service;
        }
    }
}
