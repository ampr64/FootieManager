using Core.Entities;
using System.Collections.Generic;

namespace Infrastructure.Data.Seed
{
    public static class StadiumSeedData
    {
        public static IEnumerable<Stadium> Stadiums
        {
            get => new List<Stadium>
            {
                new Stadium("Le Parc des Princes", 47929, 1967),
                new Stadium("Santiago Bernabéu", 81044, 1944),
                new Stadium("Anfield", 54074, 1884),
                new Stadium("Old Trafford", 74140, 1910),
                new Stadium("Emirates Stadium", 60704, 2006),
                new Stadium("Bet365", 30089, 1997),
                new Stadium("Camp Nou", 99354, 1957),
                new Stadium("Estadio Antonio Vespucio Liberti", 70074, 1938),
                new Stadium("Estadio Presidente Perón", 30000, 1950),
                new Stadium("Estádio Urbano Caldeira", 16068, 1916),
                new Stadium("Neo Química Arena", 49205, 2011)
            };
        }
    }
}
