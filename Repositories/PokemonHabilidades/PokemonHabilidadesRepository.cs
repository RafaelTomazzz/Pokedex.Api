using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Pokedex.Api.Data;
using Pokedex.Api.Models;
using Pokedex.Api.Repositories.Interfaces;

namespace Pokedex.Api.Repositories
{
    public class PokemonHabilidadesRepository : IPokemonHabilidadesRepository
    {
        private readonly DataContext _context;

        public PokemonHabilidadesRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PokemonHabilidade>> GetAllPHAsync()
        {
            IEnumerable<PokemonHabilidade> pokemonHabilidades = await _context.PokemonHabilidades.ToListAsync();
            return pokemonHabilidades;
        }

        public async Task<PokemonHabilidade> GetByIdPHAsync(int idpokemon, int idhabilidade)
        {
            PokemonHabilidade pokemonHabilidade = await _context.PokemonHabilidades.FirstOrDefaultAsync(ph => ph.IdPokemon == idpokemon & ph.IdHabilidade == idhabilidade);
            return pokemonHabilidade;
        }

        public async Task PostPHAsync(PokemonHabilidade pokemonHabilidade)
        {
            _context.AddAsync(pokemonHabilidade);
        }

        public async Task DeletePhAsync(PokemonHabilidade pokemonHabilidade)
        {
            _context.Remove(pokemonHabilidade);
        }

    }
}