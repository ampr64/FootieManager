using System;
using System.IO;
using System.Threading.Tasks;
using ApplicationCore.Interfaces;
using Infrastructure.Identity;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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
            var host = CreateHostBuilder(args).Build();

            using var scope = host.Services.CreateScope();

            var services = scope.ServiceProvider;

            try
            {
                var context = services.GetRequiredService<FootieDataManagerContext>();

                if (context.Database.IsSqlServer())
                    await context.Database.MigrateAsync();

                var env = services.GetService<IWebHostEnvironment>();
                var configuration = services.GetService<IConfiguration>();
                var userManager = services.GetService<UserManager<ApplicationUser>>();
                var csvDataRetriever = services.GetRequiredService<ICsvDataRetriever>();

                new FootieDataManagerContextSeed(env, configuration, userManager, csvDataRetriever)
                    .SeedAsync(context)
                    .Wait();
            }
            catch (Exception ex)
            {
                var logger = services.GetRequiredService<ILogger<Program>>();

                logger.LogError(ex, "An error occurred while migrating or seeding the database.");

                throw;
            }

            await host.RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    webBuilder.UseContentRoot(Directory.GetCurrentDirectory());
                });
    }
}
