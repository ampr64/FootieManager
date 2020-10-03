using Core.Common;
using Core.Entities;
using Core.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public static class FootieDataManagerContextSeed
    {
        public static async Task SeedAsync(FootieDataManagerContext context)
        {
            if (!await context.Continents.AnyAsync())
            {
                await context.Continents.AddRangeAsync(
                    GetDefaultContinents()
                    );
            }

            if (!await context.Countries.AnyAsync())
            {
                await context.Countries.AddRangeAsync(
                    GetDefaultCountries()
                    );
            }

            if (!await context.Stadiums.AnyAsync())
            {
                await context.Stadiums.AddRangeAsync(
                    GetDefaultStadiums()
                    );
            }

            if (!await context.Leagues.AnyAsync())
            {
                await context.Leagues.AddRangeAsync(
                    GetDefaultLeagues()
                    );
            }

            if (!await context.Clubs.AnyAsync())
            {
                await context.Clubs.AddRangeAsync(
                    GetDefaultClubs()
                    );
            }

            if (!await context.Players.AnyAsync())
            {
                await context.Players.AddRangeAsync(
                    GetDefaultPlayers()
                    );
            }

            await context.SaveChangesAsync();
        }

        private static IEnumerable<Continent> GetDefaultContinents()
        {
            return new List<Continent>
            {
                new Continent("South America"),
                new Continent("Europe"),
                new Continent("Asia")
            };
        }

        private static IEnumerable<Country> GetDefaultCountries()
        {
            return new List<Country>
            {
                new Country("Argentina", 1),
                new Country("Brazil", 1),
                new Country("France", 2),
                new Country("Spain", 2),
                new Country("Germany", 2),
                new Country("Japan", 3)
            };
        }

        private static IEnumerable<Stadium> GetDefaultStadiums()
        {
            return new List<Stadium>
            {
                new Stadium("El Monumental", 70000, 1938, null),
                new Stadium("La Bombonera", 45000, 1935, null),
                new Stadium("Le Parc Des Princes", 48000, 1967, null),
                new Stadium("Camp Nou", 99000, 1954, null),
                new Stadium("Santiago Bernabeu", 81000, 1947, null),
                new Stadium("Allianz Arena", 75000, 2005, null),
            };
        }

        private static IEnumerable<League> GetDefaultLeagues()
        {
            return new List<League>
            {
                new League("Primera División", 1),
                new League("Campeonato Brasileiro Série A", 2),
                new League("Ligue 1", 3),
                new League("La Liga", 4),
                new League("Bundesliga", 5),
                new League("J1 League", 6)
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

        private static IEnumerable<Player> GetDefaultPlayers()
        {
            return new List<Player>
            {
                new Player("Lionel", "Messi", 1, new DateTime(1987, 6, 24))
                {
                    CountryId = 1,
                    Position = Position.Forward,
                    Foot = Foot.Left,
                    GoalCount = 25,
                    AssistCount = 20,
                    Appearances = 38,
                    ClubId = 4,
                    MarketValue = 112000000,
                    YearlySalary = 80000000
                },
                new Player("Matías", "Suárez", 1, new DateTime(1990, 2, 21))
                {
                    CountryId = 1,
                    Position = Position.Forward,
                    Foot = Foot.Right,
                    GoalCount = 10,
                    AssistCount = 4,
                    Appearances = 33,
                    ClubId = 1,
                    MarketValue = 10000000,
                    YearlySalary = 20000
                },
                new Player("Neymar", "Jr", 2, new DateTime(1992, 2, 2))
                {
                    CountryId = 2,
                    Position = Position.Forward,
                    Foot = Foot.Right,
                    GoalCount = 20,
                    AssistCount = 15,
                    Appearances = 36,
                    ClubId = 3,
                    MarketValue = 130000000,
                    YearlySalary = 40000000
                },
            };
        }
    }
}
