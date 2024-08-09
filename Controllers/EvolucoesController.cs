using Microsoft.AspNetCore.Mvc;
using Pokedex.Api.DTO;
using Pokedex.Api.Exceptions;
using Pokedex.Api.Http;
using Pokedex.Api.Models;
using Pokedex.Api.Services.Interfaces;

namespace Pokedex.Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class EvolucoesController : ControllerBase
    {
        private readonly IEvolucoesService _evolucoesService;

        public EvolucoesController(IEvolucoesService evolucoesService)
        {
            _evolucoesService = evolucoesService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                IEnumerable<Evolucao> evolucoes = await _evolucoesService.GetAllEvolucaoAsync();
                IEnumerable<PokemonDTO> pokemonsDTO = evolucoes.Select(e => e.ToPokemon());
                return Ok(pokemonsDTO);
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
                Evolucao evolucao = await _evolucoesService.GetByIdAsync(id);
                PokemonDTO pokemonDTO = evolucao.ToPokemon();
                return Ok(pokemonDTO);
            }
            catch (BaseException ex)
            {
                
                return ex.GetResponse();
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody]Evolucao novaEvolucao)
        {
            try
            {
                Evolucao evolucao = await _evolucoesService.PostEvolucaoAsync(novaEvolucao);
                return HttpResponseApi<Evolucao>.Created(evolucao);
            }
            catch (BaseException ex)
            {
                
                return ex.GetResponse();
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody]Evolucao alteracaoEvolucao)
        {
            try
            {
                Evolucao evolucao = await _evolucoesService.UpdateAsync(id, alteracaoEvolucao);
                return Ok(alteracaoEvolucao);
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
                await _evolucoesService.DeleteEvolucaoAsync(id);
                return NoContent();
            }
            catch (BaseException ex)
            {
                
                return ex.GetResponse();
            }
        }
    }
}