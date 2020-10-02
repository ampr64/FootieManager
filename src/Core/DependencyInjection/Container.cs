using Core.Common;
using Core.Extensions;
using System;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection;

namespace Core.DependencyInjection
{
    public static class Container
    {
        public static ImmutableArray<Type> Services { get; } = TypesOf(typeof(IService<,>));

        public static ImmutableArray<Type> Repositories { get; } = TypesOf(typeof(IRepository<,>));

        private static ImmutableArray<Type> TypesOf(Type type)
        {
            var genericType = type.GetGenericTypeDefinition();
            return Assembly.Load("Core")
                .GetTypes()
                .Where(t => t.IsInterface && t.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == genericType))
                .ToImmutableArray();
        }
    }
}
