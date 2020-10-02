using Core.Entities;
using System;

namespace Core.Common
{
    public abstract class Person : Entity<int>
    {
        public string FirstName { get; protected set; }
        
        public string LastName { get; protected set; }

        public int CountryId { get; protected set; }

        public Country Country { get; protected set; }

        public DateTime BirthDate { get; protected set; }

        public string PictureUrl { get; private set; }

        protected Person()
        {
        }

        protected Person(string firstName, string lastName, int countryId, DateTime birthDate, string pictureUrl)
        {
            FirstName = firstName;
            LastName = lastName;
            CountryId = countryId;
            BirthDate = birthDate;
            PictureUrl = pictureUrl;
        }
    }
}
