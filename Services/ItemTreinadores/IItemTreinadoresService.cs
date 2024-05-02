using Pokedex.Api.Models;

namespace Pokedex.Api.Services.Interfaces
{
    public interface IItemTreinadoresService
    {
        public Task<IEnumerable<ItemTreinador>> GetAllITAsync();
        public Task<ItemTreinador> GetByIdITAsync(int iditem, int idtreinador);
        public Task<ItemTreinador> PostITAsync(ItemTreinador novoItemTreinador);
        public Task DeleteITAsync(int iditem, int idtreinador);
    }
}