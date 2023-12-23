using Pokedex.Api.Models;

namespace Pokedex.Api.Services.Interfaces
{
    public interface IEvolucaoHabilidadeService
    {
        public Task<IEnumerable<EvolucaoHabilidade>> GetAllEHAsync();
        public Task<EvolucaoHabilidade> GetByIdEHAsync(int idevolucao, int idhabilidade);
        public Task<EvolucaoHabilidade> PostEHAsync(EvolucaoHabilidade novaEvolucaoHabilidade);
        public Task DeteleEHAsync(int idevolucao, int idhabilidade);
    }
}