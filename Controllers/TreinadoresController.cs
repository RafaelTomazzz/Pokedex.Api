using Microsoft.AspNetCore.Mvc;
using Pokedex.Api.DTO;
using Pokedex.Api.Exceptions;
using Pokedex.Api.Http;
using Pokedex.Api.Models;
using Pokedex.Api.Services;
using Pokedex.Api.Services.Interfaces;

namespace Pokedex.Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class TreinadoresController : ControllerBase
    {
        private readonly ITreinadoresService _treinadoresService;

        public TreinadoresController(ITreinadoresService treinadoresService)
        {
            _treinadoresService = treinadoresService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                IEnumerable<Treinador> treinadores = await _treinadoresService.GetAllTreinadorAsync();
                IEnumerable<TreinadorDTO> treinadoresDTO = treinadores.Select(t => t.ToTreinador());
                return Ok(treinadoresDTO);
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
                Treinador treinador = await _treinadoresService.GetByIdTreinadorAsync(id);
                TreinadorDTO treinadorDTO = treinador.ToTreinador();
                return Ok(treinadorDTO);
            }
            catch (BaseException ex)
            {
                
                return ex.GetResponse();
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(Treinador novoTreinador)
        {
            try
            {
                Treinador treinador = await _treinadoresService.PostTreinadorAsync(novoTreinador);
                
                return HttpResponseApi<Treinador>.Created(treinador);
            }
            catch (BaseException ex)
            {
                
                return ex.GetResponse();
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id,[FromBody] Treinador alteracaoTreinador)
        {
            try
            {
                await _treinadoresService.UpdateTreinadorAsync(id, alteracaoTreinador);
                return Ok(alteracaoTreinador);
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
                await _treinadoresService.DeleteTreinadorAsync(id);
                
                return NoContent();
            }
            catch (BaseException ex)
            {
                
                return ex.GetResponse();
            }
        }



    }
}