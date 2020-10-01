using System;
using System.Linq;
using System.Reflection;

namespace Core.Extensions
{
    public static class AssemblyExtensions
    {
        public static Type FindType(this Assembly source, Func<Type, bool> predicate) =>
            source?.GetTypes().Where(predicate).FirstOrDefault();
    }
}
