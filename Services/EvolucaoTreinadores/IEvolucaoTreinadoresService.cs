using Pokedex.Api.Models;

namespace Pokedex.Api.Services.Interfaces
{
    public interface IEvolucaoTreinadoresService
    {
        public Task<IEnumerable<EvolucaoTreinador>> GetAllETAsync();
        public Task<EvolucaoTreinador> GetByIdETAsync(int idevolcao, int idtreinador);
        public Task<EvolucaoTreinador> PostETAsync(EvolucaoTreinador novoEvolucaoTreinador);
        public Task DeleteETAsync(int idevolcao, int idtreinador);

    }
}