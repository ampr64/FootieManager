using ApplicationCore.Common;
using System;

namespace ApplicationCore.Entities
{
    public class Coach : Person
    {
        public int? ClubId { get; set; }

        public Club Club { get; }

        public decimal? Salary { get; set; }

        public Coach()
        {
        }

        public Coach(
            string firstName,
            string lastName,
            DateTime birthDate,
            int? countryId = null,
            string pictureUrl= null,
            int? clubId = null,
            decimal? salary = null)
            : base(firstName, lastName, countryId, birthDate, pictureUrl)
        {
            ClubId = clubId;
            Salary = salary;
        }
    }
}
