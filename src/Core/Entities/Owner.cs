﻿using Domain.Common;
using System;

namespace Domain.Entities
{
    public class Owner : Person
    {
        public Club OwnedClub { get; }

        public Owner(string firstName, string lastName, int countryId, DateTime birthDate, string pictureUrl)
            : base(firstName, lastName, countryId, birthDate, pictureUrl)
        {
        }
    }
}
