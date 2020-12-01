using Api.Features.Clubs.Commands.DeleteClub;
using Api.Features.Clubs.Commands.NewClub;
using Api.Features.Clubs.Commands.UpdateClub;
using Api.Features.Clubs.Queries;
using Api.Features.Clubs.Queries.GetClubDetail;
using Api.Features.Clubs.Queries.GetClubs;
using Api.Features.Clubs.Queries.GetLeagueClubs;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Controllers
{
    public class ClubsController : ApiController
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClubDto>>> List()
        {
            var clubs = await Mediator.Send(new GetClubsQuery());

            return Ok(clubs);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ClubDetailDto>> GetDetail(int id)
        {
            return await Mediator.Send(new GetClubDetailQuery(id));
        }

        [HttpGet("leagues/{leagueId}")]
        public async Task<ActionResult<IEnumerable<ClubDto>>> GetLeagueClubs(int leagueId)
        {
            var leagues = await Mediator.Send(new GetLeagueClubsQuery(leagueId));

            return Ok(leagues);
        }

        [HttpPost]
        public async Task<IActionResult> New(NewClubCommand command)
        {
            var id = await Mediator.Send(command);

            return new CreatedResult(nameof(GetDetail), id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateClubCommand command)
        {
            if (id != command.Id)
                return BadRequest();

            await Mediator.Send(command);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await Mediator.Send(new DeleteClubCommand(id));

            return NoContent();
        }
    }
}
