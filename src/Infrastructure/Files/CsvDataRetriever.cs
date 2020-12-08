using ApplicationCore.Interfaces;
using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Infrastructure.Files
{
    public class CsvDataRetriever : ICsvDataRetriever
    {
        private static readonly CsvConfiguration _configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            MissingFieldFound = null,
            HeaderValidated = null,
            Delimiter = ","
        };

        public List<object> RetrieveData(Type type, string path)
        {
            var retrieveDataMethod = GetType().GetMethods().FirstOrDefault(m => m.IsGenericMethod && m.Name == nameof(RetrieveData));

            return ((IEnumerable<object>)retrieveDataMethod?.MakeGenericMethod(type)
                .Invoke(this, new[] { path }))
                .ToList();
        }

        public List<T> RetrieveData<T>(string path)
        {
            using var reader = new StreamReader(path);
            using var csv = new CsvReader(reader, _configuration);

            var classMapType = FindClassMapType(typeof(T));

            if (classMapType != null)
                Activator.CreateInstance(classMapType, _configuration);

            return csv.GetRecords<T>().ToList();
        }

        private static Type FindClassMapType(Type type) =>
            Assembly.GetExecutingAssembly().DefinedTypes
                .FirstOrDefault(t => t.BaseType == typeof(ClassMap<>).MakeGenericType(type));
    }
}
