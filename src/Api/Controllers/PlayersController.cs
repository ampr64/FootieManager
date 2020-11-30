using Api.Features.Clubs.Commands.DeletePlayer;
using Api.Features.Players.Commands.NewPlayer;
using Api.Features.Players.Commands.UpdatePlayer;
using Api.Features.Players.Queries;
using Api.Features.Players.Queries.GetClubPlayers;
using Api.Features.Players.Queries.GetFreeAgents;
using Api.Features.Players.Queries.GetPlayerDetail;
using Api.Features.Players.Queries.GetPlayers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Controllers
{
    public class PlayersController : ApiController
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlayerDto>>> List()
        {
            var stadiums = await Mediator.Send(new GetPlayersQuery());

            return Ok(stadiums);
        }

        [HttpGet("free-agents")]
        public async Task<ActionResult<IEnumerable<PlayerDto>>> ListFreeAgents()
        {
            var freeAgents = await Mediator.Send(new GetFreeAgentsQuery());

            return Ok(freeAgents);
        }

        [HttpGet("clubs/{clubId}")]
        public async Task<ActionResult<IEnumerable<PlayerDto>>> List(int clubId)
        {
            var stadiums = await Mediator.Send(new GetClubPlayersQuery(clubId));

            return Ok(stadiums);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PlayerDto>> GetDetail(int id)
        {
            return await Mediator.Send(new GetPlayerDetailQuery(id));
        }

        [HttpPost]
        public async Task<IActionResult> New(NewPlayerCommand command)
        {
            var id = await Mediator.Send(command);

            return new CreatedResult(nameof(GetDetail), id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdatePlayerCommand command)
        {
            if (id != command.Id)
                return BadRequest();

            await Mediator.Send(command);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await Mediator.Send(new DeletePlayerCommand(id));

            return NoContent();
        }
    }
}
