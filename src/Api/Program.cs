using System;
using System.IO;
using System.Threading.Tasks;
using Api.Extensions;
using Core.Common;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Api
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = BuildHost(args);

            try
            {
                host.MigrateDbContext<FootieDataManagerContext>((context, services) =>
                {
                    var env = services.GetService<IWebHostEnvironment>();
                    var configuration = services.GetService<IConfiguration>();
                    var csvSeeder = services.GetRequiredService<ICsvDataRetriever>(); 

                    new FootieDataManagerContextSeed(env, configuration, csvSeeder)
                    .SeedAsync(context)
                    .Wait();
                });

                await host.RunAsync();
            }
            catch (Exception ex)
            {
                using var scope = host.Services.CreateScope();
                var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();

                logger.LogError(ex, "Program terminated unexpectedly.");
            }
        }

        public static IHost BuildHost(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    webBuilder.UseContentRoot(Directory.GetCurrentDirectory());
                })
                .Build();
    }
}
