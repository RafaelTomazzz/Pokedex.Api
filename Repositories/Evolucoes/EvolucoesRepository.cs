using System.Reflection.Metadata;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pokedex.Api.Data;
using Pokedex.Api.Models;
using Pokedex.Api.Repositories.Interfaces;

namespace Pokedex.Api.Repositories
{
    public class EvolucoesRepository : IEvolucoesRepository
    {
        private readonly DataContext _context;

        public EvolucoesRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Evolucao>> GetAllEvolucaoAsync()
        {
            IEnumerable<Evolucao> evolucoes = await _context.Evolucoes.ToListAsync();
            return evolucoes;
        }

        public async Task<Evolucao> GetByIdEvolucaoAsync(int id)
        {
            Evolucao evolucao = await _context.Evolucoes.FirstOrDefaultAsync(ev => ev.Id == id);
            return evolucao;
        }

        public async Task<Evolucao> GetByNomeEvolucaoAsync(string nome)
        {
            Evolucao evolucao = await _context.Evolucoes.FirstOrDefaultAsync(ev => ev.Nome == nome);
            return evolucao;
        }
        public async Task PostEvolucaoAsync(Evolucao evolucao)
        {
            await _context.Evolucoes.AddAsync(evolucao);
        }

        public async Task DeleteEvolucaoAsync(Evolucao evolucao)
        {
            _context.Remove(evolucao);
        }

        public async Task<List<Evolucao>> GetByIdPokemonEvolucao(int idpokemon)
        {
            List<Evolucao> evolucoes = await _context.Evolucoes.Where(ev => ev.IdPokemon == idpokemon).ToListAsync();
            return evolucoes;
        }
    }
}