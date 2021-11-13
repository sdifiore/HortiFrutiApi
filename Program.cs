using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using HortiFrutiApi.Model;

using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace HortiFrutiApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

            static IHostBuilder CreateHostBuilder(string[] args)
                => Host.CreateDefaultBuilder(args)
                    .ConfigureWebHostDefaults(webBuilder =>
                       webBuilder.UseStartup<Startup>());
        }

        public class Startup
        {
            public void ConfigureServices(IServiceCollection services)
            {
                services.AddDbContext<DataContext>
                    (options => options.UseSqlServer("db_a41fba_dfc"));

                services.AddControllersWithViews();
            }
        }
    }
}
