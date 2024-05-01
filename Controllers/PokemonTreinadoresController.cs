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

    public class PokemonTreinadoresController : ControllerBase
    {
        private readonly IPokemonTreinadoresService _pokemonTreinadoresService;
        
        public PokemonTreinadoresController(IPokemonTreinadoresService pokemonTreinadoresService)
        {
            _pokemonTreinadoresService = pokemonTreinadoresService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                IEnumerable<PokemonTreinador> pokemonTreinadores = await _pokemonTreinadoresService.GetAllPHAsync();
                return Ok(pokemonTreinadores);
            }
            catch (BaseException ex)
            {
                
                return ex.GetResponse();
            }
        }

        [HttpGet("GetById/{idpokemon}/{idtreinador}")]
        public async Task<IActionResult> GetByIdAsync(int idpokemon, int idtreinador)
        {
            try
            {
                PokemonTreinador pokemonTreinador = await _pokemonTreinadoresService.GetByIdPTAsync(idpokemon, idtreinador);
                return Ok(pokemonTreinador);
            }
            catch (BaseException ex)
            {
                
                return ex.GetResponse();
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(PokemonTreinador novoPokemonTreinador)
        {
            try
            {
                PokemonTreinador pokemonTreinador = await _pokemonTreinadoresService.PostPTAsync(novoPokemonTreinador);
                return HttpResponseApi<PokemonTreinador>.Created(pokemonTreinador);
            }
            catch (BaseException ex)
            {
                
                return ex.GetResponse();
            }
        }
        
        [HttpDelete("{idpokemon}/{idtreinador}")]
        public async Task<IActionResult> DeleteAsync(int idpokemon, int idtreinador)
        {
            try
            {
                await _pokemonTreinadoresService.DeletePTAsync(idpokemon, idtreinador);
                return NoContent();
            }
            catch (BaseException ex)
            {
                
                return ex.GetResponse();
            }
        }
    }
}