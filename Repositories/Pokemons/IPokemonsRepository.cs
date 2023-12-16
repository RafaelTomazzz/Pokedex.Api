using Pokedex.Api.Models;

namespace Pokedex.Api.Repositories.Interfaces
{
    public interface IPokemonsRepository
    {
        public Task<IEnumerable<Pokemon>> GetAllPokemonAsync();
    }
}