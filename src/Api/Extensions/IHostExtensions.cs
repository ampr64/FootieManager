﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;

namespace Api.Extensions
{
    public static class IHostExtensions
    {
        public static IHost MigrateDbContext<TContext>(this IHost host, Action<TContext, IServiceProvider> seedAction)
            where TContext : DbContext
        {
            using var scope = host.Services.CreateScope();
            var services = scope.ServiceProvider;

            try
            {
                var context = services.GetRequiredService<TContext>();

                InvokeSeeder(seedAction, context, services);
            }
            catch (Exception ex)
            {
                var logger = services.GetRequiredService<ILogger<Program>>();

                logger.LogError(ex, "An error occurred while migrating or seeding database used on context {DbContextName}", typeof(TContext).Name);

                throw;
            }

            return host;
        }

        private static void InvokeSeeder<TContext>(Action<TContext, IServiceProvider> seedAction, TContext context, IServiceProvider services)
            where TContext : DbContext
        {
            if (context.Database.IsSqlServer())
                context.Database.Migrate();

            seedAction(context, services);
        }
    }
}
