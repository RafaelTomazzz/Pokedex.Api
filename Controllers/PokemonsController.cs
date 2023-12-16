using Microsoft.AspNetCore.Mvc;
using Pokedex.Api.Models;
using Pokedex.Api.Services;
using Pokedex.Api.Services.Interfaces;

namespace Pokedex.Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class PokemonsController : ControllerBase
    {
        private readonly IPokemonsService _pokemonsService;

        public PokemonsController(IPokemonsService pokemonsService)
        {
            _pokemonsService = pokemonsService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            IEnumerable<Pokemon> pokemons = await _pokemonsService.GetAllPokemonAsync();
            return Ok(pokemons);
        }
    }
}