using Pokedex.Api.Models;   

namespace Pokedex.Api.Services.Interfaces
{
    public interface ITreinadoresService
    {
        public Task<IEnumerable<Treinador>> GetAllTreinadorAsync();
        public Task<Treinador> GetByIdTreinadorAsync(int id);
        public Task<Treinador> PostTreinadorAsync(Treinador treinador);
        public Task<Treinador> UpdateTreinadorAsync(int id, Treinador alteracaoTreinador);
        public Task DeleteTreinadorAsync(int id);
    }
}