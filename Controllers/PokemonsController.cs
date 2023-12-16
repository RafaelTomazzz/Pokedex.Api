using Microsoft.AspNetCore.Mvc;
using Pokedex.Api.Exceptions;
using Pokedex.Api.Http;
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
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                IEnumerable<Pokemon> pokemons = await _pokemonsService.GetAllPokemonAsync();
                return Ok(pokemons);   
            }
            catch (BaseException ex)
            {
                
                return ex.GetResponse();
            }
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            try
            {
                Pokemon pokemon = await _pokemonsService.GetByIdPokemonAsync(id);
                return Ok(pokemon);    
            }
            catch (BaseException ex)
            {
                
                return ex.GetResponse();
            }
            
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(Pokemon novoPokemon)
        {
            try
            {
                Pokemon pokemon= await _pokemonsService.PostPokemonAsync(novoPokemon);

                return HttpResponseApi<Pokemon>.Created(pokemon);
            }
            catch (BaseException ex)
            {
                
                return ex.GetResponse();
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] Pokemon alteracaoPokemon)
        {
            try
            {
                Pokemon pokemon = await _pokemonsService.UpdatePokemonAsync(id, alteracaoPokemon);
                return Ok(alteracaoPokemon);
            }
            catch (BaseException ex)
            {
                
                return ex.GetResponse();
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            try
            {
                await _pokemonsService.DeletePokemonAsync(id);
                
                return NoContent();
            }
            catch (BaseException ex)
            {
                
                return ex.GetResponse();
            }
        }





    }
}