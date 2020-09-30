﻿using Domain.Common;
using System;

namespace Domain.Entities
{
    public class Coach : Person
    {
        public int ClubId { get; set; }

        public Club Club { get; set; }

        public Coach(string firstName, string lastName, int countryId, DateTime birthDate, string pictureUrl, int clubId)
            : base(firstName, lastName, countryId, birthDate, pictureUrl)
        {
            ClubId = clubId;
        }
    }
}
