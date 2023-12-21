using Pokedex.Api.Models;

namespace Pokedex.Api.Services.Interfaces
{
    public interface IHabilidadesService
    {
        public Task<IEnumerable<Habilidade>> GetAllHabilidadeAsync();
        public Task<Habilidade> GetByIdHabilidadeAsync(int id);
        public Task<Habilidade> PostHabilidadeAsync(Habilidade novaHabilidade);
        public Task<Habilidade> UpdateHabilidadeAsync(int id, Habilidade alteracaoHabilidade);
        public Task DeleteHabilidadeAsync(int id);
    }
}