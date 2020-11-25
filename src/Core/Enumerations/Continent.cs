using Core.Common;

namespace Core.Enumerations
{
    public class Continent : Enumeration
    {
        public static readonly Continent Africa = new Continent(1, nameof(Africa));
        public static readonly Continent Asia = new Continent(2, nameof(Asia));
        public static readonly Continent CentralAmerica = new Continent(3, "Central America");
        public static readonly Continent SouthAmerica = new Continent(4, "South America");
        public static readonly Continent NorthAmerica = new Continent(5, "North America");
        public static readonly Continent Europe = new Continent(6, nameof(Europe));
        public static readonly Continent Oceania = new Continent(7, nameof(Oceania));

        private Continent(int value, string name) : base(value, name)
        {
        }
    }
}
