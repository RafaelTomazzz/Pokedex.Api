using Pokedex.Api.DTO;
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
        public Task<List<PokemonDTO>> GetAllPokemonEvolucao();
        public Task<List<PokemonDTO>> GetPokemonByName(string nome);
        public Task<PokemonDTO> GetPokemonByNameCard(string nome);
        public Task<List<PokemonDTO>> GetPokemonEvolucaoByNameAsync(string nome);
    }
}