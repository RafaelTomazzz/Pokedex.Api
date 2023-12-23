using Pokedex.Api.Models;

namespace Pokedex.Api.Services.Interfaces
{
    public interface IEvolucoesService
    {
        public Task<IEnumerable<Evolucao>> GetAllEvolucaoAsync();
        public Task<Evolucao> GetByIdAsync(int id);
        public Task<Evolucao> PostEvolucaoAsync(Evolucao novaEvolucao);
        public Task<Evolucao> UpdateAsync(int id, Evolucao alteracaoEvolucao);
        public Task DeleteEvolucaoAsync(int id);
    }
}