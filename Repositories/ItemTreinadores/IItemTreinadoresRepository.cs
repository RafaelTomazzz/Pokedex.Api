using Pokedex.Api.Models;

namespace Pokedex.Api.Repositories.Interfaces
{
    public interface IItemTreinadoresRepository
    {
        public Task<IEnumerable<ItemTreinador>> GetAllITAsync();
        public Task<ItemTreinador> GetByIdITAsync(int iditem, int idtreinador);
        public Task PostITAsync(ItemTreinador itemTreinador);
        public Task DeleteITAsync(ItemTreinador itemTreinador);

    }
}