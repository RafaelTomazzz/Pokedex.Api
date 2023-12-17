using Pokedex.Api.Repositories;
using Pokedex.Api.Services.Interfaces;
using Pokedex.Api.Models;
using Pokedex.Api.Exceptions;
using Pokedex.Api.Repositories.UnitOfWork;
using Pokedex.Api.Repositories.Interfaces;

namespace Pokedex.Api.Services
{
    public class PokemonsService : IPokemonsService
    {
        private readonly IPokemonsRepository _pokemonsRepository;
        private readonly IUnitOfWork _unitOfWork;

        public PokemonsService(IPokemonsRepository pokemonsRepository, IUnitOfWork unitOfWork)
        {
            _pokemonsRepository = pokemonsRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Pokemon>> GetAllPokemonAsync()
        {
            IEnumerable<Pokemon> pokemons = await _pokemonsRepository.GetAllPokemonAsync();
            
            if(pokemons is null)
            {
                throw new NotFoundException("Não existe nenhum pokemon");
            }

            return pokemons;
        }

        public async Task<Pokemon> GetByIdPokemonAsync(int id)
        {
            Pokemon pokemon = await _pokemonsRepository.GetByIdPokemonAsync(id);

            if(pokemon is null)
            {
                throw new NotFoundException("Não existe nenhum pokemon com este id");
            }

            return pokemon;
        }

        public async Task<Pokemon> PostPokemonAsync(Pokemon pokemon)
        {
            if(pokemon.PtVida > 250)
            {
                throw new Exception("O HP do pokemon não pode ser maior que 250");
            }
            else if(pokemon.PtDefesa > 230)
            {
                throw new Exception("A defesa do pokemon não pode ser maior que 230");
            }
            else if(pokemon.PtAtaque > 170)
            {
                throw new Exception("O ataque do pokemon não pode ser maior que 170");
            }

            await _pokemonsRepository.PostPokemonAsync(pokemon);
            await _unitOfWork.SaveChangesAsync();
            return pokemon;
        }

        public async Task<Pokemon> UpdatePokemonAsync(int id, Pokemon alteracaoPokemon)
        {
            Pokemon pokemon = await _pokemonsRepository.GetByIdPokemonAsync(id);

            if(pokemon is null)
            {
                throw new NotFoundException("Este pokemon não existe");
            }

            pokemon.Nome = alteracaoPokemon.Nome;
            pokemon.Peso = alteracaoPokemon.Peso;
            pokemon.Altura = alteracaoPokemon.Altura;
            pokemon.PtVida = alteracaoPokemon.PtVida;
            pokemon.PtDefesa = alteracaoPokemon.PtDefesa;
            pokemon.PtAtaque = alteracaoPokemon.PtAtaque;
            pokemon.PtVelocidade = alteracaoPokemon.PtVelocidade;
            pokemon.Elemento = alteracaoPokemon.Elemento;
            await _unitOfWork.SaveChangesAsync();

            return alteracaoPokemon;
        }

        public async Task DeletePokemonAsync(int id)
        {
            Pokemon pokemon = await _pokemonsRepository.GetByIdPokemonAsync(id);
            if(pokemon is null)
            {
                throw new NotFoundException("Este pokemon não existe");
            }

            await _pokemonsRepository.DeletePokemonAsync(id);
        }
    }
}