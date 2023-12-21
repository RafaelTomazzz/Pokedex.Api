using Pokedex.Api.Models;

namespace Pokedex.Api.Repositories.Interfaces
{
    public interface IHabilidadesRepository
    {
        public Task<IEnumerable<Habilidade>> GetAllHabilidadeAsync();
        public Task<Habilidade> GetByIdHabilidadeAsync(int id);
        public Task PostHabilidadeAsync(Habilidade habilidade);
        public Task<Habilidade> GetByNomeHabilidade(string nome);
        public Task DeleteHabilidadeAsync(Habilidade habilidade);
    }
}