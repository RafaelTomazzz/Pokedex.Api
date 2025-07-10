using Pokedex.Api.Models;

namespace Pokedex.Api.Repositories.Interfaces
{
    public interface IPokemonsRepository
    {
        public Task<IEnumerable<Pokemon>> GetAllPokemonAsync();
        public Task<Pokemon> GetByIdPokemonAsync(int id);
        public Task PostPokemonAsync(Pokemon pokemon);
        public Task DeletePokemonAsync(int id);
        public Task<Pokemon> GetPokemonByNameAsync(string nome);
    }
}