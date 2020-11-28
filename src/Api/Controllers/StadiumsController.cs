using Api.Features.Stadiums.Commands.DeleteStadium;
using Api.Features.Stadiums.Commands.NewStadium;
using Api.Features.Stadiums.Commands.UpdateStadium;
using Api.Features.Stadiums.Queries;
using Api.Features.Stadiums.Queries.GetStadiumDetail;
using Api.Features.Stadiums.Queries.GetStadiums;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Controllers
{
    public class StadiumsController : ApiController
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StadiumDto>>> List()
        {
            var stadiums = await Mediator.Send(new GetStadiumsQuery());

            return Ok(stadiums);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<StadiumDto>> GetDetail(int id)
        {
            return await Mediator.Send(new GetStadiumDetailQuery(id));
        }

        [HttpPost]
        public async Task<IActionResult> New(NewStadiumCommand command)
        {
            var id = await Mediator.Send(command);

            return CreatedAtAction(nameof(GetDetail), id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateStadiumCommand command)
        {
            if (id != command.Id)
                return BadRequest();

            await Mediator.Send(command);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await Mediator.Send(new DeleteStadiumCommand(id));

            return NoContent();
        }
    }
}
