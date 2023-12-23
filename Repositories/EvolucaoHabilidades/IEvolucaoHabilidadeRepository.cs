using Pokedex.Api.Models;

namespace Pokedex.Api.Repositories.Interfaces
{
    public interface IEvolucaoHabilidadeRepository
    {
        public Task<IEnumerable<EvolucaoHabilidade>> GetAllEHAsync();
        public Task<EvolucaoHabilidade> GetByIdEHAsync(int idevolucao, int idhabilidade);
        public Task PostEHAsync(EvolucaoHabilidade novaEvolucaoHabilidade);
        public Task DeleteEHAsync(EvolucaoHabilidade evolucaoHabilidade);
    }
}