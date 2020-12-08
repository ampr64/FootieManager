using ApplicationCore.Interfaces;
using Infrastructure.Persistence;
using Infrastructure.Files;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Infrastructure.Identity;

namespace Infrastructure.DependencyInjection
{
    public static class InfrastructureExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection container, IConfiguration configuration)
        {
            if (configuration.GetValue<bool>(nameof(InMemoryDbContextOptionsExtensions.UseInMemoryDatabase)))
            {
                container.AddDbContext<FootieDataManagerContext>(options =>
                    options.UseInMemoryDatabase("FootieDataManagerDb"));
            }
            else
            {
                container.AddDbContext<FootieDataManagerContext>(options =>
                    options.UseSqlServer(
                        configuration.GetConnectionString("FootieDataManagerDb"),
                        b => b.MigrationsAssembly(typeof(FootieDataManagerContext).Assembly.FullName)));
            }

            container.AddDefaultIdentity<ApplicationUser>()
                .AddEntityFrameworkStores<FootieDataManagerContext>();

            container.AddIdentityServer()
                .AddApiAuthorization<ApplicationUser, FootieDataManagerContext>();
                        
            container.AddScoped<IApplicationDbContext,FootieDataManagerContext>();
            container.AddTransient<ICsvDataRetriever, CsvDataRetriever>();

            return container;
        }
    }
}
