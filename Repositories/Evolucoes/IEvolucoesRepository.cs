using Pokedex.Api.Models;

namespace Pokedex.Api.Repositories.Interfaces
{
    public interface IEvolucoesRepository
    {
        public Task<IEnumerable<Evolucao>> GetAllEvolucaoAsync();
        public Task<Evolucao> GetByIdEvolucaoAsync(int id);
        public Task PostEvolucaoAsync(Evolucao evolucao);
        public Task<Evolucao> GetByNomeEvolucaoAsync(string nome);
        public Task DeleteEvolucaoAsync(Evolucao evolucao);
        public Task<List<Evolucao>> GetByIdPokemonEvolucao(int idpokemon);
    }
}