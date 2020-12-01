using Api.Features.Countries.Commands.DeleteCountry;
using Api.Features.Countries.Commands.NewCountry;
using Api.Features.Countries.Commands.UpdateCountry;
using Api.Features.Countries.Queries;
using Api.Features.Countries.Queries.GetCountries;
using Api.Features.Countries.Queries.GetCountryDetail;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Controllers
{
    public class CountriesController : ApiController
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CountryDto>>> List()
        {
            var countries = await Mediator.Send(new GetCountriesQuery());

            return Ok(countries);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CountryDto>> GetDetail(int id)
        {
            return await Mediator.Send(new GetCountryDetailQuery(id));
        }

        [HttpPost]
        public async Task<IActionResult> New(NewCountryCommand command)
        {
            var id = await Mediator.Send(command);

            return new CreatedResult(nameof(GetDetail), id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateCountryCommand command)
        {
            if (id != command.Id)
                return BadRequest();

            await Mediator.Send(command);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await Mediator.Send(new DeleteCountryCommand(id));

            return NoContent();
        }
    }
}
