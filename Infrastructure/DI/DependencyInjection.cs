using Application.Services;
using Microsoft.Extensions.DependencyInjection;
using Persistence.DAO;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<DapperDbContext>(); //..... Registers the Db Context

            services.AddTransient<UserRepository>(); //Register User Service
            services.AddTransient<UserService>(); //Register User Service

            services.AddTransient<LicenseRepository>();
            services.AddTransient<LicenseService>();
            //services.AddTransient<VisitRepository>();
            return services;

        }
    }
}
