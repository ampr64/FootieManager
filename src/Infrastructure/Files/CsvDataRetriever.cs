using Core.Common;
using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

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

            return csv.GetRecords(type).ToList();
        }
    }
}
