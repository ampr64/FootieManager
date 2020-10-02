using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StadiumsController : ControllerBase
    {
        private readonly IStadiumService _service;

        public StadiumsController(IStadiumService stadiumService)
        {
            _service = stadiumService;
        }

        [HttpGet]
        public async Task<IEnumerable<Stadium>> Get()
        {
            return await _service.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<Stadium> Get(int id)
        {
            return await _service.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> New([FromBody] Stadium stadium)
        {
            await _service.NewAsync(stadium);
            return CreatedAtAction(nameof(Get), new { id = stadium.Id }, stadium);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Stadium stadium)
        {
            if (id != stadium.Id)
                return BadRequest();

            await _service.UpdateAsync(stadium);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}
