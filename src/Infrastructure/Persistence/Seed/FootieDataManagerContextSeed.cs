using ApplicationCore.Interfaces;
using Infrastructure.Identity;
using Infrastructure.Persistence.Seed;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class FootieDataManagerContextSeed : IContextSeeder<FootieDataManagerContext>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ICsvDataRetriever _csvDataRetriever;
        private readonly IDatabaseContextSeeder<FootieDataManagerContext> _databaseSeeder;
        private readonly IMemoryContextSeeder<FootieDataManagerContext> _memorySeeder;
        private readonly string _seedFilesPath;

        public FootieDataManagerContextSeed(IWebHostEnvironment env,
            IConfiguration configuration,
            UserManager<ApplicationUser> userManager,
            ICsvDataRetriever csvDataRetriever)
        {
            env = env ?? throw new ArgumentNullException(nameof(env));
            configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));

            _seedFilesPath = Path.GetFullPath(configuration.GetValue<string>("CsvSeedFilesRelativePath"), env.ContentRootPath);
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
            _csvDataRetriever = csvDataRetriever ?? throw new ArgumentNullException(nameof(csvDataRetriever));
            _databaseSeeder = new FootieDataManagerSqlDbSeeder(csvDataRetriever, _seedFilesPath);
            _memorySeeder = new FootieDataManagerMemoryContextSeeder(csvDataRetriever, _seedFilesPath);
        }

        public async Task SeedAsync(FootieDataManagerContext context)
        {
            await SeedDefaultUserAsync(context);

            var task = context.Database.IsSqlServer() ? _databaseSeeder.SeedAsync(context) : _memorySeeder.SeedAsync(context);

            await task;
        }

        private async Task SeedDefaultUserAsync(FootieDataManagerContext context)
        {
            var defaultUser = new ApplicationUser("admin@footiedatamanager.com");

            if (!await context.Users.AnyAsync(u => u.Email == defaultUser.Email))
            {
                await _userManager.CreateAsync(defaultUser, "123");
            }
        }
    }
}
