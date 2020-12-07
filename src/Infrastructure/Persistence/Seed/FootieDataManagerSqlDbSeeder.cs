using Core.Common;
using Core.Entities;
using Core.Enumerations;
using Core.Services;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Seed
{
    public class FootieDataManagerSqlDbSeeder : IDatabaseContextSeeder<FootieDataManagerContext>
    {
        private readonly ICsvDataRetriever _csvDataRetriever;
        private readonly string _filesPath;

        public FootieDataManagerSqlDbSeeder(ICsvDataRetriever csvDataRetriever, string filesPath)
        {
            _csvDataRetriever = csvDataRetriever;
            _filesPath = filesPath;
        }

        public async Task SeedAsync(FootieDataManagerContext context)
        {
            using (context)
            {
                if (!await context.Continents.AnyAsync())
                {
                    await context.Continents.AddRangeAsync(Enumeration.GetAll<Continent>());
                    await context.SaveChangesAsync();
                }

                await AddToContextAsync<Country>(context);
                await AddToContextAsync<League>(context);
                await AddToContextAsync<Stadium>(context);
                await AddToContextAsync<Club>(context);
                await AddToContextAsync<Coach>(context);
                await AddToContextAsync<Player>(context);
            }
        }

        private async Task AddToContextAsync<TEntity>(FootieDataManagerContext context) where TEntity : class
        {
            var dbSet = context.Set<TEntity>();

            if (!await dbSet.AnyAsync())
            {
                var propertyName = context.GetType().GetProperties().FirstOrDefault(p => p.PropertyType.IsGenericType && p.PropertyType.GetGenericArguments()[0] == typeof(TEntity))?.Name;
                var csv = BuildFilePath(propertyName);

                var seedData = _csvDataRetriever.RetrieveData<TEntity>(csv);

                seedData?.ForEach(x =>
                {
                    context.Entry(x).State = EntityState.Added;
                    context.SaveChanges();
                });
            }
        }

        private string BuildFilePath(string propertyName) => $"{_filesPath}{propertyName}.csv";
    }
}
