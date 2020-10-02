using Core.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Reflection;

namespace Application.DependencyInjection
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection container)
        {
            var interfaceImplementationPairs = Container.Services.ToDictionary(service => service,
                service => Assembly.GetExecutingAssembly().DefinedTypes.FirstOrDefault(t => t.IsClass && service.IsAssignableFrom(t)));


            foreach (var pair in interfaceImplementationPairs)
            {
                if (pair.Value != null)
                    container.AddScoped(pair.Key, pair.Value);
            }

            return container;
        }
    }
}
