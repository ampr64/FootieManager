using Core.Common;
using System.Collections.Generic;

namespace Core.Entities
{
    public class Country : Entity
    {
        public string Name { get; set; }

        public int ContinentId { get; set; }

        public string FlagImageUrl { get; set; }

        public List<League> Leagues { get; } = new();

        public Country() { }

        public Country(string name, int continentId, string flagImageUrl = null)
        {
            Name = name;
            ContinentId = continentId;
            FlagImageUrl = flagImageUrl;
        }
    }
}
