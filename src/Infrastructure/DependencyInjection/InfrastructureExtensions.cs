using Core.Common;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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
                        configuration.GetConnectionString("FootieDataManagerDb"),
                        b => b.MigrationsAssembly(typeof(FootieDataManagerContext).Assembly.FullName)));
            }

            container.AddScoped<IApplicationDbContext, FootieDataManagerContext>();

            return container;
        }
    }
}
