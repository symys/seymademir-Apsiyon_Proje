using Apsiyon.Application.Interfaces;
using Apsiyon.Application.Services;
using Apsiyon.Domain.Interfaces;
using Apsiyon.Infrastructure.Data.Context;
using Apsiyon.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Apsiyon.Application
{
    public static class DependencyContainer
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApsiyonDbContext>(options =>
                                                options.UseSqlServer(configuration.GetConnectionString("Default"))
                                                       .UseLazyLoadingProxies());
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IApartmentService, ApartmentService>();
            services.AddScoped<IApartmentRepository, ApartmentRepository>(); 
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
