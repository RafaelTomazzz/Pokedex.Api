using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Pokedex.Api.Controllers;
using Pokedex.Api.Data;
using Pokedex.Api.Models;
using Pokedex.Api.Repositories.Interfaces;


namespace Pokedex.Api.Repositories
{
    public class PokemonTreinadoresRepository : IPokemonTreinadoresRepository
    {
        private readonly DataContext _context;

        public PokemonTreinadoresRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PokemonTreinador>> GetAllPTAsync()
        {
            IEnumerable<PokemonTreinador> pokemonTreinadores = await _context.PokemonTreinadores.ToListAsync();
            return pokemonTreinadores;
        }

        public async Task<PokemonTreinador> GetByIdPTAsync(int idpokemon, int idtreinador)
        {
            PokemonTreinador pokemonTreinador= await _context.PokemonTreinadores.FirstOrDefaultAsync(ph => ph.IdPokemon == idpokemon & ph.IdTreinador == idtreinador);
            return pokemonTreinador;
        }

        public async Task PostPTAsync(PokemonTreinador pokemonTreinador)
        {
            _context.AddAsync(pokemonTreinador);
        }

        public async Task DeletePTAsync(PokemonTreinador pokemonTreinador)
        {
            _context.Remove(pokemonTreinador);
        }
    }
}