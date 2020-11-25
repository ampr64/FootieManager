using Core.Entities;
using System.Collections.Generic;

namespace Infrastructure.Data.Seed
{
    public static class CountrySeedData
    {
        public static IEnumerable<Country> Countries
        {
            get => new List<Country>
            {
                new Country("Japan", 2, @"https://cdn.countryflags.com/thumbs/japan/flag-800.png"),
                new Country("Argentina", 4, @"https://cdn.countryflags.com/thumbs/argentina/flag-800.png"),
                new Country("Brazil", 4, @"https://cdn.countryflags.com/thumbs/brazil/flag-800.png"),
                new Country("France", 6, @"https://cdn.countryflags.com/thumbs/france/flag-800.png"),
                new Country("Spain", 6, @"https://cdn.countryflags.com/thumbs/spain/flag-800.png"),
                new Country("England", 6, @"https://cdn.countryflags.com/thumbs/england/flag-800.png"),
                new Country("Germany", 6, @"https://cdn.countryflags.com/thumbs/germany/flag-800.png")
            };
        }
    }
}
