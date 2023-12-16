using Pokedex.Api.Models;

namespace Pokedex.Api.Services.Interfaces
{
    public interface IPokemonsService
    {
        public Task<IEnumerable<Pokemon>> GetAllPokemonAsync();
        public Task<Pokemon> GetByIdPokemonAsync(int id);
        public Task<Pokemon> PostPokemonAsync(Pokemon pokemon);
        public Task<Pokemon> UpdatePokemonAsync(int id, Pokemon alteracaoPokemon);
        public Task DeletePokemonAsync(int id);
    }
}