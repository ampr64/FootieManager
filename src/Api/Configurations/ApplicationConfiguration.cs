using Api.Common.Behaviors;
using Api.Common.Core;
using Api.Services;
using ApplicationCore.Interfaces;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Api.Configurations
{
    public static class ApplicationConfiguration
    {
        public static IServiceCollection ConfigureApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(CommandValidationBehavior<,>));

            services.AddSingleton<ICurrentUserService, CurrentUserService>();

            services.AddTransient<IAgeCalculator, AgeCalculator>();

            return services;
        }
    }
}
