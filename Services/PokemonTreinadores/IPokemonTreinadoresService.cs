using Pokedex.Api.Models;

namespace Pokedex.Api.Services.Interfaces
{
    public interface IPokemonTreinadoresService
    {
        public Task<IEnumerable<PokemonTreinador>> GetAllPHAsync();
        public Task<PokemonTreinador> GetByIdPTAsync(int idpokemon, int idtreinador);
        public Task<PokemonTreinador> PostPTAsync(PokemonTreinador novoPokemonTreinador);
        public Task DeletePTAsync(int idpokemon, int idtreinador);
    
    }
}