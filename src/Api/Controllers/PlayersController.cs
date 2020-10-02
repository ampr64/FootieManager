﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IPlayerService _service;

        public PlayersController(IPlayerService playerService)
        {
            _service = playerService;
        }

        [HttpGet]
        public async Task<IEnumerable<Player>> Get()
        {
            return await _service.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<Player> Get(int id)
        {
            return await _service.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> New([FromBody] Player player)
        {
            await _service.NewAsync(player);
            return CreatedAtAction(nameof(Get), new { id = player.Id }, player);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Player player)
        {
            if (id != player.Id)
                return BadRequest();

            await _service.UpdateAsync(player);
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
