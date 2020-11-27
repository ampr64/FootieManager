using Core.Common;
using Core.Entities;
using Core.Enumerations;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class FootieDataManagerContextSeed
    {
        private readonly ICsvDataRetriever _csvSeeder;
        private readonly string _seedFilesPath;

        private static readonly Dictionary<Type, string> _fileNameByType = new Dictionary<Type, string>
        {
            {typeof(Club), "Clubs.csv"},
            {typeof(Coach), "Coaches.csv"},
            {typeof(Country), "Countries.csv"},
            {typeof(League), "Leagues.csv"},
            {typeof(Player), "Players.csv"},
            {typeof(Stadium), "Stadiums.csv"}
        };

        public FootieDataManagerContextSeed(IWebHostEnvironment env, IConfiguration configuration, ICsvDataRetriever csvSeeder)
        {
            var relativeCsvFilesPath = configuration.GetValue<string>("CsvSeedFilesRelativePath");
            _seedFilesPath = Path.GetFullPath(relativeCsvFilesPath, env.ContentRootPath);
            _csvSeeder = csvSeeder;
        }

        public async Task SeedAsync(FootieDataManagerContext context)
        {
            foreach (var entityType in context.Model.GetEntityTypes())
            {
                var type = entityType.ClrType;
                var setMethod = context.GetType().GetMethod(nameof(context.Set)).MakeGenericMethod(type);

                IQueryable<dynamic> dbSet = setMethod?.Invoke(context, null) as IQueryable<dynamic>;

                if (!await dbSet?.AnyAsync())
                {
                    var csv = GetFilePath(type);

                    var seedData = File.Exists(csv)
                        ? _csvSeeder.RetrieveData(type, csv)
                        : GetPredefinedValues(dbSet);

                    if (seedData != null && seedData.Any())
                        await context.AddRangeAsync(seedData);
                }
            }

            await context.SaveChangesAsync();
        }

        private IEnumerable<object> GetPredefinedValues(IQueryable<object> dbSet) =>
            dbSet switch
            {
                IQueryable<Continent> continents => Enumeration.GetAll<Continent>(),
                IQueryable<Position> positions => Enumeration.GetAll<Position>(),
                _ => Array.Empty<dynamic>()
            };

        private string GetFilePath(Type type)
        {
            if (_fileNameByType.TryGetValue(type, out var filePath))
                return _seedFilesPath + filePath;

            return null;
        }
    }
}
