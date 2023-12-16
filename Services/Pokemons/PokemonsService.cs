using Pokedex.Api.Repositories;
using Pokedex.Api.Services.Interfaces;
using Pokedex.Api.Models;

namespace Pokedex.Api.Services
{
    public class PokemonsService : IPokemonsService
    {
        private readonly PokemonsRepository _pokemonsRepository;

        public PokemonsService(PokemonsRepository pokemonsRepository)
        {
            _pokemonsRepository = pokemonsRepository;
        }

        public async Task<IEnumerable<Pokemon>> GetAllPokemonAsync()
        {
            return await _pokemonsRepository.GetAllPokemonAsync();
        }
    }
}