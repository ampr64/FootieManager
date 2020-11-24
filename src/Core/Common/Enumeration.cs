using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Core.Common
{
    public abstract class Enumeration : IComparable, IEquatable<Enumeration>
    {
        public int Value { get; private set; }

        public string Name { get; private set; }

        protected Enumeration(int value, string name)
        {
            Value = value;
            Name = name;
        }

        public override string ToString() => Name;

        public static IEnumerable<T> GetAll<T>() where T : Enumeration =>
            typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly)
                .Select(f => f.GetValue(null))
                .Cast<T>();

        public static T FromValue<T>(int value) where T : Enumeration =>
            Parse<T, int>(value, nameof(value), item => item.Value == value);

        public static T FromName<T>(string name) where T : Enumeration =>
            Parse<T, string>(name, nameof(name), item => item.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase));

        public static bool operator ==(Enumeration left, Enumeration right)
        {
            if (left is null ^ right is null)
                return false;

            return left?.Equals(right) != false;
        }

        public static bool operator !=(Enumeration left, Enumeration right) =>
            !(left == right);

        public bool Equals(Enumeration other) => Equals(other as object);

        public override bool Equals(object obj) =>
            obj != null
            && obj.GetType() == GetType()
            && Value.Equals(((Enumeration)obj).Value);

        public override int GetHashCode() => Value.GetHashCode();

        public int CompareTo(object obj) => Value.CompareTo(((Enumeration)obj).Value);

        private static T Parse<T, TProperty>(TProperty propertyValue, string propertyName, Func<T, bool> predicate) where T : Enumeration =>
            GetAll<T>().FirstOrDefault(predicate)
            ?? throw new InvalidOperationException($"'{propertyValue}' is not a valid {propertyName} in {typeof(T).Name}");
    }
}
