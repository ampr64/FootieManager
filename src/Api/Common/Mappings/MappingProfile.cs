using AutoMapper;
using System;
using System.Linq;
using System.Reflection;

namespace Api.Common.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            ApplyMappingsFromAssembly(GetType().Assembly);
        }

        private void ApplyMappingsFromAssembly(Assembly assembly)
        {
            ApplyMappings(assembly, typeof(IDto<>).Name, nameof(IDto<object>.Map));
            ApplyMappings(assembly, typeof(ICommandMap<>).Name, nameof(ICommandMap<object>.Map));
        }

        private void ApplyMappings(Assembly assembly, string interfaceName, string methodName)
        {
            var implementationTypes = assembly.GetExportedTypes()
                .Where(t => t.GetInterface(interfaceName) != null)
                .ToList();

            foreach (var implementationType in implementationTypes)
            {
                var instance = Activator.CreateInstance(implementationType);

                var mapMethod = implementationType.GetMethod(methodName) ??
                    implementationType.GetInterface(interfaceName)?.GetMethod(methodName);

                mapMethod?.Invoke(instance, new object[] { this });
            }
        }
    }
}
