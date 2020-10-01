using Core.Common;
using System.Collections.Generic;

namespace Core.Entities
{
    public class Country : Entity<int>
    {
        public string Name { get; set; }

        public int ContinentId { get; set; }

        public Continent Continent { get; set; }

        public string FlagUrl { get; set; }

        public IList<League> Leagues { get; set; }
    }
}
