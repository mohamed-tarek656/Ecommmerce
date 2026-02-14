using ecom.core.interfaces;
using ecom.infrastructure.data;
using ecom.infrastructure.repositiries;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecom.infrastructure
{
    public static class infrastructuregistration
    {
        public static IServiceCollection infrastructureconfiguration(this IServiceCollection services,IConfiguration configuration)
        {
            //here we add iconfiguration to reach toappsetting json
            services.AddScoped(typeof(igenericrepository<>), typeof(genericrepository<>));
            //services.AddScoped<icategoryrepository, categoryrepository>();
            //services.AddScoped<iproductrepository,productrepository>();
            //services.AddScoped<iphotorepository,photorepository>();
            //to solve this shape bec do spaghetti code do unitodwork
            services.AddScoped<iunitofwork, unitwork>();
            services.AddDbContext<appdbcontext>(op =>
            {
                op.UseSqlServer(configuration.GetConnectionString("ecomdatabase"));
            });
            return services;
        }
    }
}
