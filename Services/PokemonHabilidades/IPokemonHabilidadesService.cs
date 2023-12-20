using Pokedex.Api.Models;

namespace Pokedex.Api.Services.Interfaces
{
    public interface IPokemonHabilidadesService
    {
        public Task<IEnumerable<PokemonHabilidade>> GetAllPHAsync();
        public Task<PokemonHabilidade> GetByIdPHAsync(int idpokemon, int idhabilidade);
        public Task<PokemonHabilidade> PostPHAsync(PokemonHabilidade novoPokemonHabilidade);
        public Task DeletePhAsync(int idpokemon, int idhabilidade);
    }
}