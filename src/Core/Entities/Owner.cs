using Core.Common;
using System;

namespace Core.Entities
{
    public class Owner : Person
    {
        public Club Club { get; }

        public Owner(string firstName, string lastName, int countryId, DateTime birthDate, string pictureUrl)
            : base(firstName, lastName, countryId, birthDate, pictureUrl)
        {
        }
    }
}
