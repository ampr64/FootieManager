using Core.Common;
using System.Collections.Generic;

namespace Core.Entities
{
    public class League : Entity<int>
    {
        public string Name { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }

        public IList<Club> Clubs { get; set; }

        private League() { }

        public League(string name, int countryId)
        {
            Name = name;
            CountryId = countryId;
        }
    }
}
