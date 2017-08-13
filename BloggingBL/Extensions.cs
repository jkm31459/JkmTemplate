using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggingBL
{
    public static class Extensions
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<BloggingContext>();

            services.AddTransient<IBlogRepository, BlogRepo>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddTransient<MainBL>();

            return services;
        }
    }
}
