using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Pokedex.Api.Data;
using Pokedex.Api.Models;
using Pokedex.Api.Repositories.Interfaces;

namespace Pokedex.Api.Repositories
{
    public class EvolucaoHabilidadeRepository : IEvolucaoHabilidadeRepository
    {
        private readonly DataContext _context;

        public EvolucaoHabilidadeRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<EvolucaoHabilidade>> GetAllEHAsync()
        {
            IEnumerable<EvolucaoHabilidade> evolucaoHabilidades = await _context.EvolucaoHabilidades.ToListAsync();
            return evolucaoHabilidades;
        }

        public async Task<EvolucaoHabilidade> GetByIdEHAsync(int idevolucao, int idhabilidade)
        {
            EvolucaoHabilidade evolucaoHabilidade = await _context.EvolucaoHabilidades.FirstOrDefaultAsync(eh => eh.IdEvolucao == idevolucao & eh.IdHabilidade == idhabilidade);
            return evolucaoHabilidade;
        }

        public async Task PostEHAsync(EvolucaoHabilidade novaEvolucaoHabilidade)
        {
            await _context.AddAsync(novaEvolucaoHabilidade);
        }

        public async Task DeleteEHAsync(EvolucaoHabilidade evolucaoHabilidade)
        {
            _context.EvolucaoHabilidades.Remove(evolucaoHabilidade);
        }
    }  
}