using Core.Common;
using Core.Services;
using Infrastructure.Persistence.Seed;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class FootieDataManagerContextSeed : IContextSeeder<FootieDataManagerContext>
    {
        private readonly ICsvDataRetriever _csvDataRetriever;
        private readonly IDatabaseContextSeeder<FootieDataManagerContext> _databaseSeeder;
        private readonly IMemoryContextSeeder<FootieDataManagerContext> _memorySeeder;
        private readonly string _seedFilesPath;

        public FootieDataManagerContextSeed(IWebHostEnvironment env, IConfiguration configuration, ICsvDataRetriever csvDataRetriever)
        {
            env = env ?? throw new ArgumentNullException(nameof(env));
            configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));

            var relativeCsvFilesPath = configuration.GetValue<string>("CsvSeedFilesRelativePath");
            _seedFilesPath = Path.GetFullPath(relativeCsvFilesPath, env.ContentRootPath);
            _csvDataRetriever = csvDataRetriever ?? throw new ArgumentNullException(nameof(csvDataRetriever));
            _databaseSeeder = new FootieDataManagerSqlDbSeeder(csvDataRetriever, _seedFilesPath);
            _memorySeeder = new FootieDataManagerMemoryContextSeeder(csvDataRetriever, _seedFilesPath);
        }

        public async Task SeedAsync(FootieDataManagerContext context)
        {
            var task = context.Database.IsSqlServer() ? _databaseSeeder.SeedAsync(context) : _memorySeeder.SeedAsync(context);

            await task;
        }
    }
}
