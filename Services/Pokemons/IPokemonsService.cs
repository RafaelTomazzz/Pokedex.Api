using Pokedex.Api.Models;

namespace Pokedex.Api.Services.Interfaces
{
    public interface IPokemonsService
    {
        public Task<IEnumerable<Pokemon>> GetAllPokemonAsync();
    }
}