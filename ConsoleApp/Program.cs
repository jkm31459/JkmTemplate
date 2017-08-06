using BloggingBL;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<BloggingContext>();
            serviceCollection.AddTransient<IBlogRepository, BlogRepo>();
            serviceCollection.AddTransient<IUnitOfWork, UnitOfWork>();

            serviceCollection.AddTransient<MainBL>();

            var serviceProvider = serviceCollection.BuildServiceProvider();
            serviceProvider.GetService<MainBL>().Run();
        }
    }
}
