using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Api.Configurations
{
    public static class MappingConfiguration
    {
        public static IServiceCollection ConfigureMappings(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
