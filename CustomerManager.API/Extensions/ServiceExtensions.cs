using System.Text;
using CustomerManager.API.Data;
using CustomerManager.API.Profiles;
using CustomerManager.API.Repositories;
using CustomerManager.API.Repositories.Interfaces;
using CustomerManager.API.Services;
using CustomerManager.API.Services.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace CustomerManager.API.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection ConfigureAppServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddAutoMapper(typeof(CustomerProfiles).Assembly);
            /*  services.AddDbContext<CustomerContext>(opt =>
             opt.UseInMemoryDatabase("CustomerList"));
            */

            services.AddDbContext<CustomerContext>(opt =>
           opt.UseSqlite(config.GetConnectionString("Default")));

            services.AddScoped<ITokenService, TokenService>();          
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            
            return services;
        }

        public static IServiceCollection ConfigureIdentityServices(this IServiceCollection services)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                 .AddJwtBearer(opt =>
                 {
                     opt.TokenValidationParameters = new TokenValidationParameters
                     {
                         ValidateIssuerSigningKey = true,
                         IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("SUPER SECRET KEY")),
                         ValidateAudience = false,
                         ValidateIssuer = false
                     };
                 });

            //Todo
            //make a collection in postman for easier testing
            //move key to appsettings secret/dev
            return services;
        }
    }
}
