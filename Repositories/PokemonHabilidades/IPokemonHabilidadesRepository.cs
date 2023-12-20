using Pokedex.Api.Models;

namespace Pokedex.Api.Repositories.Interfaces
{
    public interface IPokemonHabilidadesRepository
    {
        public Task<IEnumerable<PokemonHabilidade>> GetAllPHAsync();
        public Task<PokemonHabilidade> GetByIdPHAsync(int idpokemon, int idhabilidade);
        public Task PostPHAsync(PokemonHabilidade pokemonHabilidade);
        public Task DeletePhAsync(PokemonHabilidade pokemonhabilidade);
    }
}