using Core.Common;
using System;

namespace Core.Entities
{
    public class Coach : Person
    {
        public int? ClubId { get; set; }

        public Club Club { get; set; }

        public decimal Salary { get; set; }

        public Coach()
        {
        }

        public Coach(string firstName, string lastName, int countryId, DateTime birthDate, string pictureUrl, int clubId)
            : base(firstName, lastName, countryId, birthDate, pictureUrl)
        {
            ClubId = clubId;
        }
    }
}
