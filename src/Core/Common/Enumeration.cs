using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Core.Common
{
    public abstract class Enumeration : IComparable, IEquatable<Enumeration>
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        protected Enumeration(int value, string name)
        {
            Id = value;
            Name = name;
        }

        public override string ToString() => Name;

        public static IReadOnlyList<T> GetAll<T>() where T : Enumeration =>
            typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly)
                .Select(f => f.GetValue(null))
                .Cast<T>()
                .ToList()
                .AsReadOnly();

        public static T FromValue<T>(int value) where T : Enumeration =>
            Parse<T, int>(value, nameof(value), item => item.Id == value);

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
            && Id.Equals(((Enumeration)obj).Id);

        public override int GetHashCode() => Id.GetHashCode();

        public int CompareTo(object obj) => Id.CompareTo(((Enumeration)obj).Id);

        private static T Parse<T, TProperty>(TProperty propertyValue, string propertyName, Func<T, bool> predicate) where T : Enumeration =>
            GetAll<T>().FirstOrDefault(predicate)
            ?? throw new InvalidOperationException($"'{propertyValue}' is not a valid {propertyName} in {typeof(T).Name}");
    }
}
