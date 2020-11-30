using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Api.Configurations
{
    public static class ValidationsConfigurations
    {
        public static IServiceCollection ConfigureFluentValidations(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
