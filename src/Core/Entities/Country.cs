using Core.Common;
using Core.Enumerations;
using System.Collections.Generic;

namespace Core.Entities
{
    public class Country : Entity
    {
        public string Name { get; set; }

        public int ContinentId { get; set; }

        public Continent Continent { get; set; }

        public string FlagUrl { get; set; }

        public List<League> Leagues { get; set; } = new();

        public Country() { }

        public Country(string name, int continentId, string flagUrl = null)
        {
            Name = name;
            ContinentId = continentId;
            FlagUrl = flagUrl;
        }
    }
}
