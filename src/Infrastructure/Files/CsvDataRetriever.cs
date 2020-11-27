using Core.Common;
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

        public IEnumerable<object> RetrieveData(Type type, string path)
        {
            using var reader = new StreamReader(path);
            using var csv = new CsvReader(reader, _configuration);

            //var typeClassMap = FindClassMap(type);

            ////if (typeClassMap is not null)
            ////    csv.Configuration.RegisterClassMap(typeClassMap);

            return csv.GetRecords(type).ToList();
        }

        private Type FindClassMap(Type type) =>
            Assembly.GetExecutingAssembly().DefinedTypes
                .FirstOrDefault(t => t.BaseType == typeof(ClassMap<>).MakeGenericType(type));
    }
}
