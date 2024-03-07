using Microsoft.EntityFrameworkCore;
using Pokedex.Api.Data;
using Pokedex.Api.Models;
using Pokedex.Api.Repositories.Interfaces;

namespace Pokedex.Api.Repositories
{
    public class TreinadoresRepository : ITreinadoresRepository
    {
        private readonly DataContext _context;

        public TreinadoresRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Treinador>> GetAllTreinadoresAsync()
        {
            IEnumerable<Treinador> treinadores = await _context.Treinadores.ToListAsync();
            return treinadores;
        }

        public async Task<Treinador> GetByIdTreinadorAsync(int id)
        {
            Treinador treinador = await _context.Treinadores.FirstOrDefaultAsync(t => t.Id == id);
            return treinador;
        }

        public async Task<Treinador> GetByLoginAsync(string login)
        {
            Treinador treinador = await _context.Treinadores.FirstOrDefaultAsync(t => t.Login == login);
            return treinador;
        }

        public async Task<Treinador> GetByLoginTreinadorAsnc(string login)
        {
            Treinador treinador = await _context.Treinadores.FirstOrDefaultAsync(t => t.Login == login);
            return treinador;
        }

        public async Task PostTreinadorAsync(Treinador treinador)
        {
            _context.AddAsync(treinador);
        }

        public async Task DeleteTreinadorAsync(int id)
        {
            Treinador treinador = _context.Treinadores.FirstOrDefault(t => t.Id == id);
            _context.Treinadores.Remove(treinador);
        }
    }
}