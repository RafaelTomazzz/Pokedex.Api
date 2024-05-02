using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Pokedex.Api.Controllers;
using Pokedex.Api.Data;
using Pokedex.Api.Models;
using Pokedex.Api.Repositories.Interfaces;

namespace Pokedex.Api.Repositories
{
    public class EvolucaoTreinadoresRepository : IEvolucaoTreinadoresRepository
    {
        private readonly DataContext _context;

        public EvolucaoTreinadoresRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<EvolucaoTreinador>> GetAllETAsync()
        {
            IEnumerable<EvolucaoTreinador> evolucaoTreinadores = await _context.EvolucaoTreinadores.ToListAsync();
            return evolucaoTreinadores;
        }

        public async Task<EvolucaoTreinador> GetByIdETAsync(int idevolucao, int idtreinador)
        {
            EvolucaoTreinador evolucaoTreinador = await _context.EvolucaoTreinadores.FirstOrDefaultAsync(ph => ph.IdEvolucao == idevolucao & ph.IdTreinador == idtreinador);
            return evolucaoTreinador;
        }

        public async Task PostETAsync(EvolucaoTreinador evolucaoTreinador)
        {
            _context.AddAsync(evolucaoTreinador);
        }

        public async Task DeleteETAsync(EvolucaoTreinador evolucaoTreinador)
        {
            _context.Remove(evolucaoTreinador);
        }
    }
}
