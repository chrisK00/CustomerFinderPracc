using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace CustomerManager.API.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection ConfigureIdentityServices(this IServiceCollection services)
        {
            //config jwt token 
            return services;
        }
    }
}
