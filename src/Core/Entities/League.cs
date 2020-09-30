using Domain.Common;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class League : Entity<int>
    {
        public string Name { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }

        public IList<Club> Clubs { get; set; }
    }
}
