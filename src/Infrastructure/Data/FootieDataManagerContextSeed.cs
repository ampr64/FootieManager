using Core.Entities;
using Infrastructure.Files;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class FootieDataManagerContextSeed
    {
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

        public FootieDataManagerContextSeed(IWebHostEnvironment env, IConfiguration configuration)
        {
            var relativeCsvFilesPath = configuration.GetValue<string>("CsvSeedFilesRelativePath");
            _seedFilesPath = Path.GetFullPath(relativeCsvFilesPath, env.ContentRootPath);
        }

        public async Task SeedAsync(FootieDataManagerContext context)
        {
            foreach (var entityType in context.Model.GetEntityTypes())
            {
                var type = entityType.ClrType;
                var setMethod = context.GetType().GetMethod(nameof(context.Set)).MakeGenericMethod(type);
                var dbSet = setMethod?.Invoke(context, null) as IQueryable<dynamic>;

                if (!await dbSet?.AnyAsync())
                {
                    var csv = GetFilePath(type);

                    if (File.Exists(csv))
                    {
                        var seedData = new CsvService().GetData(type, csv);
                        if (seedData.Any())
                            await context.AddRangeAsync(seedData);
                    }
                }
            }

            await context.SaveChangesAsync();
        }

        private string GetFilePath(Type type)
        {
            if (_fileNameByType.TryGetValue(type, out var filePath))
                return _seedFilesPath + filePath;

            return null;
        }
    }
}
