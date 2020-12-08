using ApplicationCore.Common;
using System.Collections.Generic;

namespace ApplicationCore.Entities
{
    public class Country : Entity
    {
        public string Name { get; set; }

        public int ContinentId { get; set; }

        public string IsoCode { get; set; }

        public string FlagImageUrl { get; set; }

        public List<League> Leagues { get; } = new();

        public Country() { }

        public Country(string name, int continentId, string isoCode = null, string flagImageUrl = null)
        {
            Name = name;
            ContinentId = continentId;
            IsoCode = isoCode;
            FlagImageUrl = flagImageUrl;
        }
    }
}
