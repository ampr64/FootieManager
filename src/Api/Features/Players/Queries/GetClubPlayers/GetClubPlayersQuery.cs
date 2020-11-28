using Api.Common.Queries;
using System.Collections.Generic;

namespace Api.Features.Players.Queries.GetClubPlayers
{
    public class GetClubPlayersQuery : IQuery<IEnumerable<PlayerDto>>
    {
        public int ClubId { get; set; }

        public GetClubPlayersQuery(int clubId) => ClubId = clubId;
    }
}
