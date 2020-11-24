using System.Collections.Generic;

namespace Api.Features.Clubs.Queries.GetClubs
{
    public class GetClubsVm
    {
        public List<ClubDto> Clubs { get; set; } = new();
    }
}
