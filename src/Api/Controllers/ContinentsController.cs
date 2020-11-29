using Api.Features.Continents;
using Api.Features.Continents.GetContinentDetail;
using Api.Features.Continents.ListContinents;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Controllers
{
    public class ContinentsController : ApiController
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContinentDto>>> List()
        {
            var stadiums = await Mediator.Send(new ListContinentsQuery());

            return Ok(stadiums);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ContinentDto>> GetDetail(int id)
        {
            return await Mediator.Send(new GetContinentDetailQuery(id));
        }
    }
}
