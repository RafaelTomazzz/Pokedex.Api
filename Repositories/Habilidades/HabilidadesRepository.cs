using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pokedex.Api.Data;
using Pokedex.Api.Models;
using Pokedex.Api.Repositories.Interfaces;

namespace Pokedex.Api.Repositories
{
    public class HabilidadesRepository : IHabilidadesRepository
    {
        private readonly DataContext _context;
        
        public HabilidadesRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Habilidade>> GetAllHabilidadeAsync()
        {
            IEnumerable<Habilidade> habilidades = await _context.Habilidades.ToListAsync();
            return habilidades;
        }

        public async Task<Habilidade> GetByIdHabilidadeAsync(int id)
        {
            Habilidade habilidade = await _context.Habilidades.FirstOrDefaultAsync(h => h.Id == id);
            return habilidade;
        }

        public async Task<Habilidade> GetByNomeHabilidade(string nome)
        {
            Habilidade habilidade = await _context.Habilidades.FirstOrDefaultAsync(h => h.Nome == nome);
            return habilidade;
        }

        public async Task PostHabilidadeAsync(Habilidade habilidade)
        {
            _context.AddAsync(habilidade);
        }

        public async Task DeleteHabilidadeAsync(Habilidade habilidade)
        {
            _context.Habilidades.Remove(habilidade);
        }
    } 
}