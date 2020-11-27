using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Infrastructure.Files
{
    public class CsvService
    {
        private static readonly CsvConfiguration _configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            MissingFieldFound = null,
            HeaderValidated = null,
            Delimiter = ","
        };

        public IEnumerable<object> GetData(Type type, string filePath)
        {
            using var reader = new StreamReader(filePath, Encoding.Default);
            using var csv = new CsvReader(reader, _configuration);
            var typeClassMap = FindClassMap(type);

            if (typeClassMap != null)
                csv.Configuration.RegisterClassMap(typeClassMap);

            return csv.GetRecords(type).ToList();
        }

        private Type FindClassMap(Type type) =>
            Assembly.GetExecutingAssembly().DefinedTypes
                .FirstOrDefault(t => t.BaseType == typeof(ClassMap<>).MakeGenericType(type));
    }
}
