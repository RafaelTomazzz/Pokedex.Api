using Microsoft.AspNetCore.Mvc;
using Pokedex.Api.Exceptions;
using Pokedex.Api.Http;
using Pokedex.Api.Models;
using Pokedex.Api.Services.Interfaces;

namespace Pokedex.Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class HabilidadesController : ControllerBase
    {
        private readonly IHabilidadesService _habilidadesService;

        public HabilidadesController(IHabilidadesService habilidadesService)
        {
            _habilidadesService = habilidadesService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                IEnumerable<Habilidade> habilidades = await _habilidadesService.GetAllHabilidadeAsync();
                return Ok(habilidades);                
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
                Habilidade habilidade = await _habilidadesService.GetByIdHabilidadeAsync(id);
                return Ok(habilidade);
            }
            catch (BaseException ex)
            {
                
                return ex.GetResponse();
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] Habilidade habilidade)
        {
            try
            {
                _habilidadesService.PostHabilidadeAsync(habilidade);
                return HttpResponseApi<Habilidade>.Created(habilidade);
            }
            catch (BaseException ex)
            {
                
                return ex.GetResponse();
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody]Habilidade alteracaoHabilidade)
        {
            try
            {
                Habilidade habilidade = await _habilidadesService.UpdateHabilidadeAsync(id, alteracaoHabilidade);

                return Ok(habilidade);
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
                await _habilidadesService.DeleteHabilidadeAsync(id);

                return NoContent();
            }
            catch (BaseException ex)
            {
                
                return ex.GetResponse();
            }
        }
    }
}