using Domain.Common;
using System;

namespace Domain.Entities
{
    public class Stadium : Entity<int>
    {
        public string Name { get; private set; }

        public int ClubId { get; private set; }

        public Club Club { get; private set; }

        public int Capacity { get; private set; }

        public int BuiltIn { get; private set; }

        public Stadium(string name, int clubId, int capacity, int builtIn)
        {
            Name = name;
            ClubId = clubId;
            Capacity = capacity;
            BuiltIn = builtIn;
        }

        public void UpdateDetails(string name, int capacity)
        {
            Name = name;
            SetCapacity(capacity);
        }

        public void SetCapacity(int capacity)
        {
            if (capacity <= 0)
                throw new ArgumentException($"{nameof(capacity)} must be greater than zero.");

            Capacity = capacity;
        }

        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException($"{nameof(name)} cannot be null or empty.");

            Name = name;
        }
    }
}
