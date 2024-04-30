using Pokedex.Api.Data;
using Pokedex.Api.Exceptions;
using Pokedex.Api.Models;
using Pokedex.Api.Repositories.Interfaces;
using Pokedex.Api.Repositories.UnitOfWork;
using Pokedex.Api.Services.Interfaces;

namespace Pokedex.Api.Services
{
    public class PokemonTreinadoresService : IPokemonTreinadoresService
    {
        private readonly IPokemonTreinadoresRepository _pokemonTreinadoresRepopsitory ;
        private readonly IUnitOfWork _unitOfWork ;

        public PokemonTreinadoresService(IPokemonTreinadoresRepository pokemonTreinadoresRepository, IUnitOfWork unitOfWork)
        {
            _pokemonTreinadoresRepopsitory = pokemonTreinadoresRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<PokemonTreinador>> GetAllPHAsync()
        {
            IEnumerable<PokemonTreinador> pokemonTreinadores = await _pokemonTreinadoresRepopsitory.GetAllPTAsync();

            if(pokemonTreinadores is null)
            {
                throw new NotFoundException("Nenhum PokemonTreinador foi encontrado");
            }

            return pokemonTreinadores;
        }

        public async Task<PokemonTreinador> GetByIdPTAsync(int idpokemon, int idtreinador)
        {
            PokemonTreinador pokemonTreinadores = await _pokemonTreinadoresRepopsitory.GetByIdPTAsync(idpokemon, idtreinador);

            if(pokemonTreinadores is null)
            {
                throw new NotFoundException("Nenhum PokemonTreinador foi encontrado");
            }

            return pokemonTreinadores;
        }

        public async Task<PokemonTreinador> PostPTAsync(PokemonTreinador novoPokemonTreinador)
        {
            PokemonTreinador pokemonTreinador = await _pokemonTreinadoresRepopsitory.GetByIdPTAsync(novoPokemonTreinador.IdPokemon, novoPokemonTreinador.IdTreinador);

            if(pokemonTreinador != null)
            {
                throw new Exception("Este pokemon já tem esta habilidade");
            }

            await _pokemonTreinadoresRepopsitory.PostPTAsync(novoPokemonTreinador);
            await _unitOfWork.SaveChangesAsync();
            return novoPokemonTreinador;
        }

        public async Task DeletePTAsync(int idpokemon, int idtreinador)
        {
            PokemonTreinador pokemonTreinador= await _pokemonTreinadoresRepopsitory.GetByIdPTAsync(idpokemon, idtreinador);

            if(pokemonTreinador is null)
            {
                throw new NotFoundException("Nenhum PokemonTreinador foi encontrado");
            }

            await _pokemonTreinadoresRepopsitory.DeletePTAsync(pokemonTreinador);
            await _unitOfWork.SaveChangesAsync();
        }
    } 
}