using Microsoft.AspNetCore.Mvc;
using Pokedex.Api.Exceptions;
using Pokedex.Api.Http;
using Pokedex.Api.Models;
using Pokedex.Api.Repositories.Interfaces;
using Pokedex.Api.Services.Interfaces;

namespace Pokedex.Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class EvolucaoHabilidadesController : ControllerBase
    {
        private readonly IEvolucaoHabilidadeService _evolucaoHabilidadeService;

        public EvolucaoHabilidadesController(IEvolucaoHabilidadeService evolucaoHabilidadeService)
        {
            _evolucaoHabilidadeService = evolucaoHabilidadeService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                IEnumerable<EvolucaoHabilidade> evolucaoHabilidades = await _evolucaoHabilidadeService.GetAllEHAsync();
                return Ok(evolucaoHabilidades); 
            }
            catch (BaseException ex)
            {
                
                return ex.GetResponse();
            }
        }

        [HttpGet("GetById/{idevolucao}/{idhabilidade}")]
        public async Task<IActionResult> GetByIdAsync(int idevolucao, int idhabilidade)
        {
            try
            {
                EvolucaoHabilidade evolucaoHabilidade = await _evolucaoHabilidadeService.GetByIdEHAsync(idevolucao, idhabilidade);
                return Ok(evolucaoHabilidade);
            }
            catch (BaseException ex)
            {
                
                return ex.GetResponse();
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody]EvolucaoHabilidade novaEvolucaoHabilidade)
        {
            try
            {
                EvolucaoHabilidade evolucaoHabilidade = await _evolucaoHabilidadeService.PostEHAsync(novaEvolucaoHabilidade);
                return HttpResponseApi<EvolucaoHabilidade>.Created(novaEvolucaoHabilidade);
            }
            catch (BaseException ex)
            {
                
                return ex.GetResponse();
            }
        }

        [HttpDelete("{idevolucao}/{idhabilidade}")]
        public async Task<IActionResult> DeleteAsync(int idevolucao, int idHabilidade)
        {
            try
            {
                await _evolucaoHabilidadeService.DeteleEHAsync(idevolucao, idHabilidade);
                return NoContent();
            }
            catch (BaseException ex)
            {
                
                return ex.GetResponse();
            }
        }
    }
}