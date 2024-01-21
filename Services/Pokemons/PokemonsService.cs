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
            if(pokemon.MinVida <= 10 | pokemon.MinVida <= 0)
            {
                throw new Exception("O HP do pokemon não pode ser menor ou igual que 10");
            }
            else if(pokemon.MinDefesa <= 10 | pokemon.MinDefesa <= 10)
            {
                throw new Exception("A defesa do pokemon não pode ser menor ou igual que 10");
            }
            else if(pokemon.MinAtaque <= 10 | pokemon.MinAtaque <= 10)
            {
                throw new Exception("O ataque do pokemon não pode ser menor ou igual que 10");
            }
            else if(pokemon.MinVelocidade <= 10 | pokemon.MinVelocidade <= 10)
            {
                throw new Exception("A velocidade do pokemon não pode ser menor ou igual que 10");
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
            pokemon.MinVida = alteracaoPokemon.MinVida;
            pokemon.MaxVida= alteracaoPokemon.MaxVida;
            pokemon.MinAtaque = alteracaoPokemon.MinAtaque;
            pokemon.MaxAtaque = alteracaoPokemon.MaxAtaque;
            pokemon.MinDefesa = alteracaoPokemon.MinDefesa;
            pokemon.MaxDefesa = alteracaoPokemon.MaxDefesa;
            pokemon.MinVelocidade = alteracaoPokemon.MinVelocidade;
            pokemon.MaxVelocidade = alteracaoPokemon.MaxVelocidade;
            pokemon.Elemento = alteracaoPokemon.Elemento;
            pokemon.SegundoElemento = alteracaoPokemon.SegundoElemento;
            pokemon.Descricao = alteracaoPokemon.Descricao;
            pokemon.Codigo = alteracaoPokemon.Codigo;
            pokemon.Apanhado = alteracaoPokemon.Apanhado;
            pokemon.Imagem = alteracaoPokemon.Imagem;
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