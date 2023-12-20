using Pokedex.Api.Data;
using Pokedex.Api.Exceptions;
using Pokedex.Api.Models;
using Pokedex.Api.Repositories.Interfaces;
using Pokedex.Api.Repositories.UnitOfWork;
using Pokedex.Api.Services.Interfaces;

namespace Pokedex.Api.Services
{
    public class PokemonHabilidadesService : IPokemonHabilidadesService
    {
        private readonly IPokemonHabilidadesRepository _pokemonHabilidadeRepository;
        private readonly IUnitOfWork _unitOfWork;

        public PokemonHabilidadesService(IPokemonHabilidadesRepository pokemonHabilidadesRepository, IUnitOfWork unitOfWork)
        {
            _pokemonHabilidadeRepository = pokemonHabilidadesRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<PokemonHabilidade>> GetAllPHAsync()
        {
            IEnumerable<PokemonHabilidade> pokemonHabilidades = await _pokemonHabilidadeRepository.GetAllPHAsync();

            if(pokemonHabilidades is null)
            {
                throw new NotFoundException("Nenhum PokemonHabilidade foi encontrado");
            }

            return pokemonHabilidades;
        }

        public async Task<PokemonHabilidade> GetByIdPHAsync(int idpokemon, int idhabilidade)
        {
            PokemonHabilidade pokemonHabilidade = await _pokemonHabilidadeRepository.GetByIdPHAsync(idpokemon, idhabilidade);

            if(pokemonHabilidade is null)
            {
                throw new NotFoundException("Nenhum PokemonHabilidade foi encontrado");
            }

            return pokemonHabilidade;
        }

        public async Task<PokemonHabilidade> PostPHAsync(PokemonHabilidade novoPokemonHabilidade)
        {
            PokemonHabilidade pokemonHabilidade = await _pokemonHabilidadeRepository.GetByIdPHAsync(novoPokemonHabilidade.IdPokemon, novoPokemonHabilidade.IdHabilidade);

            if(pokemonHabilidade != null)
            {
                throw new Exception("Este pokemon já tem esta habilidade");
            }

            await _pokemonHabilidadeRepository.PostPHAsync(novoPokemonHabilidade);
            await _unitOfWork.SaveChangesAsync();
            return novoPokemonHabilidade;
        }

        public async Task DeletePhAsync(int idpokemon, int idhabilidade)
        {
            PokemonHabilidade pokemonHabilidade = await _pokemonHabilidadeRepository.GetByIdPHAsync(idpokemon, idhabilidade);

            if(pokemonHabilidade is null)
            {
                throw new NotFoundException("Nenhum pokemon foi encontrado");
            }

            await _pokemonHabilidadeRepository.DeletePhAsync(pokemonHabilidade);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}