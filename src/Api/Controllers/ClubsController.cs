using Api.Features.Clubs.Commands.DeleteClub;
using Api.Features.Clubs.Commands.NewClub;
using Api.Features.Clubs.Commands.UpdateClub;
using Api.Features.Clubs.Queries;
using Api.Features.Clubs.Queries.GetClubDetail;
using Api.Features.Clubs.Queries.GetClubs;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Api.Controllers
{
    public class ClubsController : ApiController
    {
        [HttpGet]
        public async Task<ActionResult<GetClubsVm>> List([FromQuery] GetClubsQuery query)
        {
            return await Mediator.Send(query);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ClubDto>> GetDetail([FromQuery] GetClubDetailQuery query)
        {
            return await Mediator.Send(query);
        }

        [HttpPost]
        public async Task<int> New(NewClubCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateClubCommand command)
        {
            if (id != command.Id)
                return BadRequest();

            await Mediator.Send(command);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await Mediator.Send(new DeleteClubCommand { Id = id });

            return NoContent();
        }
    }
}
