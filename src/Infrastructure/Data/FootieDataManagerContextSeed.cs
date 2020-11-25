using Core.Common;
using Core.Entities;
using Core.Enumerations;
using Core.Enums;
using CsvHelper;
using Infrastructure.Data.Seed;
using Infrastructure.Files.Maps;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class FootieDataManagerContextSeed
    {
        public async Task SeedAsync(FootieDataManagerContext context, IWebHostEnvironment env, IConfiguration configuration)
        {
            var relativeCsvFilesPath = configuration.GetValue<string>("CsvSeedFilesRelativePath");
            var absoluteCsvFilesPath = Path.GetFullPath(relativeCsvFilesPath, env.ContentRootPath);

            //foreach (var entityType in context.Model.GetEntityTypes())
            //{
            //    var setMethod = context.GetType().GetMethod(nameof(context.Set)).MakeGenericMethod(entityType.ClrType);
            //    var dbSet = (DbSet<object>)setMethod?.Invoke(context, null);

            //    if (!await dbSet.AnyAsync())
            //    {

            //    }
            //}

            var countriesCsv = Path.Combine(absoluteCsvFilesPath, "countries.csv");
            List<Country> countries = new List<Country>();

            if (File.Exists(countriesCsv))
            {
                using var reader = new StreamReader(countriesCsv, Encoding.UTF8);
                using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
                csv.Configuration.MissingFieldFound = null;
                csv.Configuration.HeaderValidated = null;
                csv.Configuration.Delimiter = ",";
                csv.Configuration.RegisterClassMap<CountryMap>();
                var records = csv.GetRecords<Country>().ToList();
                countries.AddRange(records);
            }

            await context.SaveChangesAsync();
        }

        private static IEnumerable<Continent> GetDefaultContinents()
        {
            return Enumeration.GetAll<Continent>();
        }

        private static IEnumerable<Stadium> GetDefaultStadiums()
        {
            return new List<Stadium>
            {
                new Stadium("El Monumental", 70000, 1938),
                new Stadium("La Bombonera", 45000, 1935),
                new Stadium("Le Parc Des Princes", 48000, 1967),
                new Stadium("Camp Nou", 99000, 1954),
                new Stadium("Santiago Bernabeu", 81000, 1947),
                new Stadium("Allianz Arena", 75000, 2005),
            };
        }

        private static IEnumerable<Club> GetDefaultClubs()
        {
            return new List<Club>
            {
                new Club("River Plate", 1, "Rodolfo D'Onofrio", 1901, 48, 1, null),
                new Club("Boca Juniors", 1, "Jorge Ameal", 1905, 50, 2, null),
                new Club("Paris Saint Germain", 3, "Nasser Al-Khelaifi", 1950, 50, 3, null),
                new Club("FC Barcelona", 4, "Josep Bartomeu", 1899, 70, 4, null),
                new Club("Real Madrid CF", 4, "Florentino Pérez", 1902, 80, 5, null),
                new Club("FC Bayern Munich", 5, "Herbert Hainer", 1900, 74, 6, null),
            };
        }

        //private static IEnumerable<Player> GetDefaultPlayers()
        //{
        //    return new List<Player>
        //    {
        //        new Player("Lionel", "Messi", 1, new DateTime(1987, 6, 24))
        //        {
        //            CountryId = 1,
        //            Position = Position.Forward,
        //            Foot = Foot.Left,
        //            GoalCount = 25,
        //            AssistCount = 20,
        //            Appearances = 38,
        //            ClubId = 4,
        //            MarketValue = 112000000,
        //            Salary = 80000000
        //        },
        //        new Player("Matías", "Suárez", 1, new DateTime(1990, 2, 21))
        //        {
        //            CountryId = 1,
        //            Position = Position.Forward,
        //            Foot = Foot.Right,
        //            GoalCount = 10,
        //            AssistCount = 4,
        //            Appearances = 33,
        //            ClubId = 1,
        //            MarketValue = 10000000,
        //            Salary = 20000
        //        },
        //        new Player("Neymar", "Jr", 2, new DateTime(1992, 2, 2))
        //        {
        //            CountryId = 2,
        //            Position = Position.Forward,
        //            Foot = Foot.Right,
        //            GoalCount = 20,
        //            AssistCount = 15,
        //            Appearances = 36,
        //            ClubId = 3,
        //            MarketValue = 130000000,
        //            Salary = 40000000
        //        },
        //    };
        //}
    }
}
