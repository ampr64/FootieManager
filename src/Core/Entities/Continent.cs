using Core.Common;
using System.Collections.Generic;

namespace Core.Entities
{
    public class Continent : Entity<int>
    {
        public string Name { get; set; }

        public IList<Country> Countries { get; set; }
    }
}
