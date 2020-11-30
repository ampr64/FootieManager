using Core.Entities;
using System;

namespace Core.Common
{
    public abstract class Person : Entity
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public int? CountryId { get; set; }

        public Country Country { get; set; }

        public DateTime BirthDate { get; set; }

        public string PictureUrl { get; set; }

        protected Person()
        {
        }

        protected Person(string firstName, string lastName, int? countryId, DateTime birthDate, string pictureUrl)
        {
            FirstName = firstName;
            LastName = lastName;
            CountryId = countryId;
            BirthDate = birthDate;
            PictureUrl = pictureUrl;
        }
    }
}
