﻿using ApplicationCore.Common;
using System.Collections.Generic;

namespace ApplicationCore.Entities
{
    public class Club : Entity
    {
        public string Name { get; set; }

        public int LeagueId { get; set; }

        public League League { get; }

        public string President { get; set; }

        public int? CoachId { get; set; }

        public Coach Coach { get; }

        public int? StadiumId { get; set; }

        public Stadium Stadium { get; }

        public int YearFounded { get; set; }

        public int TrophyCount { get; set; }

        public string BadgeImageUrl { get; set; }

        public List<Player> Squad { get; } = new();

        public Club() { }

        public Club(
            string name,
            int leagueId,
            string president,
            int yearFounded,
            int trophyCount,
            int stadiumId,
            int? coachId = null,
            string badgeImageUrl = null)
        {
            Name = name;
            LeagueId = leagueId;
            President = president;
            CoachId = coachId;
            YearFounded = yearFounded;
            TrophyCount = trophyCount;
            StadiumId = stadiumId;
            CoachId = coachId;
            BadgeImageUrl = badgeImageUrl;
        }
    }
}
