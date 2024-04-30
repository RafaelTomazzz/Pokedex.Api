using Pokedex.Api.Models;

namespace Pokedex.Api.Repositories.Interfaces
{
    public interface IPokemonTreinadoresRepository
    {
        public Task<IEnumerable<PokemonTreinador>> GetAllPTAsync();
        public Task<PokemonTreinador> GetByIdPTAsync(int idpokemon, int idtreinador);
        public Task PostPTAsync(PokemonTreinador pokemonTreinador);
        public Task DeletePTAsync(PokemonTreinador pokemonTreinador);

    }
}