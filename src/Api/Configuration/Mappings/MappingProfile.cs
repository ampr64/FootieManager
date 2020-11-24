using AutoMapper;
using System;
using System.Linq;
using System.Reflection;

namespace Api.Configuration.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            ApplyMappingsFromAssembly(GetType().Assembly);
        }

        private void ApplyMappingsFromAssembly(Assembly assembly)
        {
            var dtoInterfaceName = typeof(IDto<>).Name;
            var methodName = nameof(IDto<object>.Map);

            var dtoTypes = assembly.GetExportedTypes()
                .Where(t => t.GetInterface(dtoInterfaceName) is not null)
                .ToList();

            foreach (var dtoType in dtoTypes)
            {
                var dtoInstance = Activator.CreateInstance(dtoType);

                var mapMethod = dtoType.GetMethod(methodName) ??
                    dtoType.GetInterface(typeof(IDto<>).Name)?.GetMethod(methodName);

                mapMethod?.Invoke(dtoInstance, new object[] { this });
            }
        }
    }
}
