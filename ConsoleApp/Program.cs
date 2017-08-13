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
            var services = new ServiceCollection();
            ConfigureServices(services);

            var serviceProvider = services.BuildServiceProvider();
            serviceProvider.GetService<MainBL>().Run();
        }

        private static void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddBusinessServices();
        }
    }
}
