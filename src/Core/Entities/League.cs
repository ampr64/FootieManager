using Core.Common;
using System.Collections.Generic;

namespace Core.Entities
{
    public class League : Entity
    {
        public string Name { get; set; }

        public int CountryId { get; set; }

        public int Division { get; set; }

        public Country Country { get; set; } = null;

        public string LogoImageUrl { get; set; }

        public List<Club> Clubs { get; set; } = new();

        public League() { }

        public League(string name, int countryId, int division, string logoImageUrl = null)
        {
            Name = name;
            CountryId = countryId;
            Division = division;
            LogoImageUrl = logoImageUrl;
        }
    }
}
