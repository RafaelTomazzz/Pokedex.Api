using Microsoft.AspNetCore.Mvc;
using Pokedex.Api.Exceptions;
using Pokedex.Api.Http;
using Pokedex.Api.Models;
using Pokedex.Api.Repositories.Interfaces;
using Pokedex.Api.Services.Interfaces;

namespace Pokedex.Api.Controllers
{
    [ApiController]
    [Route("Controller")]
    public class EvolucaoTreinadoresController : ControllerBase
    {
        private readonly IEvolucaoTreinadoresService _evolucaoTreinadoresService;
        public EvolucaoTreinadoresController (IEvolucaoTreinadoresService evolucaoTreinadoresService)
        {
            _evolucaoTreinadoresService = evolucaoTreinadoresService;
        } 

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                IEnumerable<EvolucaoTreinador> evolucaoTreinadores = await _evolucaoTreinadoresService.GetAllETAsync();
                return Ok(evolucaoTreinadores);
            }
            catch (BaseException ex)
            {
                
                return ex.GetResponse();
            }
        }

        [HttpGet("GetById/{idevolucao}/{idtreinador}")]
        public async Task<IActionResult> GetByIdAsync(int idevolucao, int idtreinador)
        {
            try
            {
                EvolucaoTreinador evolucaoTreinador = await _evolucaoTreinadoresService.GetByIdETAsync(idevolucao, idtreinador);
                return Ok(evolucaoTreinador);
            }
            catch (BaseException ex)
            {
                
                return ex.GetResponse();
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(EvolucaoTreinador novoEvolucaoTreinador)
        {
            try
            {
                EvolucaoTreinador evolucaoTreinador = await _evolucaoTreinadoresService.PostETAsync(novoEvolucaoTreinador);
                return HttpResponseApi<EvolucaoTreinador>.Created(evolucaoTreinador);
            }
            catch (BaseException ex)
            {
                
                return ex.GetResponse();
            }
        }

        [HttpDelete("{idevolucao}/{idtreinador}")]
        public async Task<IActionResult> DeleteAsync(int idevolucao, int idtreinador)
        {
            try
            {
                await _evolucaoTreinadoresService.DeleteETAsync(idevolucao, idtreinador);
                return NoContent();
            }
            catch (BaseException ex)
            {
                
                return ex.GetResponse();
            }
        }
    }
}