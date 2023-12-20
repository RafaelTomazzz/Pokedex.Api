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
    public class PokemonHabilidadesController : ControllerBase
    {
        private readonly IPokemonHabilidadesService _pokemonHabilidadeService;

        public PokemonHabilidadesController(IPokemonHabilidadesService pokemonHabilidadesService)
        {
            _pokemonHabilidadeService = pokemonHabilidadesService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                IEnumerable<PokemonHabilidade> pokemonHabilidades = await _pokemonHabilidadeService.GetAllPHAsync();
                return Ok(pokemonHabilidades);
            }
            catch (BaseException ex)
            {
                
                return ex.GetResponse();
            }
        }

        [HttpGet("GetById/{idpokemon}/{idhabilidade}")]
        public async Task<IActionResult> GetByIdAsync(int idpokemon, int idhabilidade)
        {
            try
            {
                PokemonHabilidade pokemonHabilidade = await _pokemonHabilidadeService.GetByIdPHAsync(idpokemon, idhabilidade);
                return Ok(pokemonHabilidade);
            }
            catch (BaseException ex)
            {
                
                return ex.GetResponse();
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(PokemonHabilidade novoPokemonHabilidade)
        {
            try
            {
                PokemonHabilidade pokemonHabilidade = await _pokemonHabilidadeService.PostPHAsync(novoPokemonHabilidade);
                return HttpResponseApi<PokemonHabilidade>.Created(pokemonHabilidade);
            }
            catch (BaseException ex)
            {
                
                return ex.GetResponse();
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int idpokemon, int idhabilidade)
        {
            try
            {
                await _pokemonHabilidadeService.DeletePhAsync(idpokemon, idhabilidade);
                return NoContent();
            }
            catch (BaseException ex)
            {
                
                return ex.GetResponse();
            }
        }
    }
}