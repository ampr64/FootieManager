using Core.Common;
using Core.DependencyInjection;
using Infrastructure.Core;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Reflection;

namespace Infrastructure.DependencyInjection
{
    public static class InfrastructureExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection container, IConfiguration configuration)
        {
            if (configuration.GetValue<bool>(nameof(InMemoryDbContextOptionsExtensions.UseInMemoryDatabase)))
            {
                container.AddDbContext<FootieDataManagerContext>(options =>
                    options.UseInMemoryDatabase(nameof(FootieDataManagerContext)));
            }
            else
            {
                container.AddDbContext<FootieDataManagerContext>(options =>
                    options.UseSqlServer(
                        configuration.GetConnectionString("FootieManagerDb"),
                        b => b.MigrationsAssembly(typeof(FootieDataManagerContext).Assembly.FullName)));
            }

            container.AddScoped<IUnitOfWork, UnitOfWork>();

            container.AddRepositories();

            return container;
        }

        private static IServiceCollection AddRepositories(this IServiceCollection container)
        {
            var interfaceImplementationPairs = Container.Repositories.ToDictionary(repository => repository,
                repository => Assembly.GetExecutingAssembly().DefinedTypes.FirstOrDefault(t => t.IsClass && repository.IsAssignableFrom(t)));

            foreach (var pair in interfaceImplementationPairs)
            {
                if (pair.Value != null)
                    container.AddScoped(pair.Key, pair.Value);
            }

            return container;
        }
    }
}
