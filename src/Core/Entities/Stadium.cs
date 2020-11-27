using Core.Common;
using System.Collections.Generic;

namespace Core.Entities
{
    public class Stadium : Entity
    {
        public string Name { get; set; }

        public List<Club> Clubs { get; } = new();

        public int Capacity { get; set; }

        public int YearBuilt { get; set; }

        public Stadium() { }

        public Stadium(string name, int capacity, int yearbuilt)
        {
            Name = name;
            Capacity = capacity;
            YearBuilt = yearbuilt;
        }
    }
}
