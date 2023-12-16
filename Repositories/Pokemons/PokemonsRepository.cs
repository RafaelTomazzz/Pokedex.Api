using System.Collections;
using Microsoft.EntityFrameworkCore;
using Pokedex.Api.Data;
using Pokedex.Api.Models;
using Pokedex.Api.Repositories.Interfaces;

namespace Pokedex.Api.Repositories
{
    public class PokemonsRepository : IPokemonsRepository
    {
        private readonly DataContext _context;

        public PokemonsRepository(DataContext context)
        {
            _context = context;
        } 

        public async Task<IEnumerable<Pokemon>> GetAllPokemonAsync()
        {
            IEnumerable<Pokemon> pokemons = await _context.Pokemons.ToListAsync();
            return pokemons;
        }

        public async Task<Pokemon> GetByIdPokemonAsync(int id)
        {
            Pokemon pokemon = await _context.Pokemons.FirstOrDefaultAsync(p => p.Id == id);
            return pokemon;
        }

        public async Task PostPokemonAsync(Pokemon pokemon)
        {
            await _context.AddAsync(pokemon);
        }

        public async Task DeletePokemonAsync(int id)
        {
            Pokemon pokemon = await _context.Pokemons.FirstOrDefaultAsync(p => p.Id == id);
            _context.Pokemons.Remove(pokemon);
        }
    }
}