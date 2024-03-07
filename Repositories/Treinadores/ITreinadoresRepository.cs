using Pokedex.Api.Models;

namespace Pokedex.Api.Repositories.Interfaces
{
    public interface ITreinadoresRepository
    {
        public Task<IEnumerable<Treinador>> GetAllTreinadoresAsync();
        public Task<Treinador> GetByIdTreinadorAsync(int id);
        public Task PostTreinadorAsync(Treinador treinador);
        public Task<Treinador> GetByLoginTreinadorAsnc(string login);
        public Task DeleteTreinadorAsync(int id);
        public Task<Treinador> GetByLoginAsync(string login);

    }
}