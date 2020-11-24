using Api.Common.Core;
using Core.Common;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Configurations
{
    public static class ApplicationServicesConfiguration
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection container)
        {
            container.AddTransient<IAgeCalculator, AgeCalculator>();

            return container;
        }
    }
}
