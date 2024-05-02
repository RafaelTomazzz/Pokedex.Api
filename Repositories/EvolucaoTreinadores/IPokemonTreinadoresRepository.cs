using Pokedex.Api.Models;

namespace Pokedex.Api.Repositories.Interfaces
{
    public interface IEvolucaoTreinadoresRepository
    {
        public Task<IEnumerable<EvolucaoTreinador>> GetAllETAsync();
        public Task<EvolucaoTreinador> GetByIdETAsync(int idevolucao, int idtreinador);
        public Task PostETAsync(EvolucaoTreinador evolucaoTreinador);
        public Task DeleteETAsync(EvolucaoTreinador evolucaoTreinador);
    } 
}