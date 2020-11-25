using System;
using System.IO;
using System.Threading.Tasks;
using Api.Extensions;
using Infrastructure.Data;
using Microsoft.AspNetCore;
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
            var configuration = GetConfiguration();
            var host = BuildWebHost(configuration, args);

            try
            {
                host.MigrateDbContext<FootieDataManagerContext>((context, services) =>
                {
                    var env = services.GetService<IWebHostEnvironment>();

                    new FootieDataManagerContextSeed()
                    .SeedAsync(context, env, configuration)
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

        private static IWebHost BuildWebHost(IConfiguration configuration, string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .CaptureStartupErrors(true)
                .ConfigureAppConfiguration(x => x.AddConfiguration(configuration))
                .UseStartup<Startup>()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .Build();

        private static IConfiguration GetConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            var config = builder.Build();

            return builder.Build();
        }
    }
}
