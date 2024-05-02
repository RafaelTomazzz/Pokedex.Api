using Microsoft.AspNetCore.Mvc;
using Pokedex.Api.Exceptions;
using Pokedex.Api.Http;
using Pokedex.Api.Models;
using Pokedex.Api.Repositories.Interfaces;
using Pokedex.Api.Services;
using Pokedex.Api.Services.Interfaces;

namespace Pokedex.Api.Controllers
{
    [ApiController]
    [Route("Controller")]
    public class ItemTreinadoresController : ControllerBase
    {
        private readonly IItemTreinadoresService _itemTreinadoresService;

        public ItemTreinadoresController(IItemTreinadoresService itemTreinadoresService)
        {
            _itemTreinadoresService = itemTreinadoresService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                IEnumerable<ItemTreinador> itemTreinadores = await _itemTreinadoresService.GetAllITAsync();
                return Ok(itemTreinadores);
            }
            catch (BaseException ex)
            {
                
                return ex.GetResponse();
            }
        }

        [HttpGet("GetById/{iditem}/{idtreinador}")]
        public async Task<IActionResult> GetByIdAsync(int iditem, int idtreinador)
        {
            try
            {
                ItemTreinador itemTreinador = await _itemTreinadoresService.GetByIdITAsync(iditem, idtreinador);
                return Ok(itemTreinador);
            }
            catch (BaseException ex)
            {
                
                return ex.GetResponse();
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(ItemTreinador novoItemTreinador)
        {
            try
            {
                ItemTreinador itemTreinador = await _itemTreinadoresService.PostITAsync(novoItemTreinador);
                return HttpResponseApi<ItemTreinador>.Created(itemTreinador);
            }
            catch (BaseException ex)
            {
                
                return ex.GetResponse();
            }
        }

        [HttpDelete("{iditem}/{idtreinador}")]
        public async Task<IActionResult> DeleteAsync(int iditem, int idtreinador)
        {
            try
            {
                await _itemTreinadoresService.DeleteITAsync(iditem, idtreinador);
                return NoContent();
            }
            catch (BaseException ex)
            {
                
                return ex.GetResponse();
            }
        }
    }
}