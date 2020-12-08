using ApplicationCore.Common;
using ApplicationCore.Enumerations;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Seed
{
    public class FootieDataManagerMemoryContextSeeder : IMemoryContextSeeder<FootieDataManagerContext>
    {
        private readonly ICsvDataRetriever _csvDataRetriever;
        private readonly string _filesPath;

        public FootieDataManagerMemoryContextSeeder(ICsvDataRetriever csvDataRetriever, string filesPath)
        {
            _csvDataRetriever = csvDataRetriever;
            _filesPath = filesPath;
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
                    var propertyName = context.GetType().GetProperties().FirstOrDefault(p => p.PropertyType.IsGenericType && p.PropertyType.GetGenericArguments()[0] == type)?.Name;
                    var csv = BuildFilePath(propertyName);

                    var seedData = File.Exists(csv)
                        ? _csvDataRetriever.RetrieveData(type, csv)
                        : GetPredefinedValues(dbSet);

                    seedData?.ForEach(x => context.Entry(x).State = EntityState.Added);
                }
            }

            await context.SaveChangesAsync();
        }

        private List<object> GetPredefinedValues(IQueryable<object> dbSet) =>
            dbSet switch
            {
                IQueryable<Continent> continents => Enumeration.GetAll<Continent>().ToList<object>(),
                _ => new()
            };

        private string BuildFilePath(string propertyName) => $"{_filesPath}{propertyName}.csv";
    }
}