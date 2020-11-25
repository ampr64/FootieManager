using Core.Entities;
using System;
using System.Collections.Generic;

namespace Infrastructure.Data.Seed
{
    public static class CoachSeedData
    {
        public static IEnumerable<Coach> Coaches
        { 
            get => new List<Coach>
            {
                new Coach("Jürgen", "Klopp", 7, new DateTime(1967, 6, 16), @"https://static.wikia.nocookie.net/the-football-database/images/8/8f/J%C3%BCrgen_Klopp.png/revision/latest/smart/width/200/height/200?cb=20200704055936", 2, 12550000),
                new Coach("Marcelo", "Gallardo", 2, new DateTime(1976, 1, 18), @"https://tntsports.com.ar/__export/1603925227616/sites/tntsports/img/2020/10/28/marcelo_gallardo_dt_de_river.jpg_251583698.jpg", null, 420000),
                new Coach()
            };
        }
    }
}
