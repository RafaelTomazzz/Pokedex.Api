using Pokedex.Api.Exceptions;
using Pokedex.Api.Models;
using Pokedex.Api.Repositories.Interfaces;
using Pokedex.Api.Repositories.UnitOfWork;
using Pokedex.Api.Services.Interfaces;

namespace Pokedex.Api.Services
{
    public class EvolucaoTreinadoresService : IEvolucaoTreinadoresService
    {
        private readonly IEvolucaoTreinadoresRepository _evolucaoTreinadoresRepository;
        private readonly IUnitOfWork _unitOfWork;

        public EvolucaoTreinadoresService(IEvolucaoTreinadoresRepository evolucaoTreinadoresRepository, IUnitOfWork unitOfWork)
        {
            _evolucaoTreinadoresRepository = evolucaoTreinadoresRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<EvolucaoTreinador>> GetAllETAsync()
        {
            IEnumerable<EvolucaoTreinador> evolucaoTreinadores = await _evolucaoTreinadoresRepository.GetAllETAsync();

            if(evolucaoTreinadores is null)
            {
                throw new NotFoundException("Nenhum PokemonTreinador foi encontrado");
            }

            return evolucaoTreinadores;
        }

        public async Task<EvolucaoTreinador> GetByIdETAsync(int idevolcao, int idtreinador)
        {
            EvolucaoTreinador evolucarTreinadores = await _evolucaoTreinadoresRepository.GetByIdETAsync(idevolcao, idtreinador);

            if(evolucarTreinadores is null)
            {
                throw new NotFoundException("Nenhum PokemonTreinador foi encontrado");
            }

            return evolucarTreinadores;
        }

        public async Task<EvolucaoTreinador> PostETAsync(EvolucaoTreinador novoEvolucaoTreinador)
        {
            EvolucaoTreinador evolucaoTreinador = await _evolucaoTreinadoresRepository.GetByIdETAsync(novoEvolucaoTreinador.IdEvolucao, novoEvolucaoTreinador.IdTreinador);

            if(evolucaoTreinador != null)
            {
                throw new Exception("Este pokemon já tem esta habilidade");
            }

            await _evolucaoTreinadoresRepository.PostETAsync(novoEvolucaoTreinador);
            await _unitOfWork.SaveChangesAsync();
            return novoEvolucaoTreinador;
        }

        public async Task DeleteETAsync(int idevolcao, int idtreinador)
        {
            EvolucaoTreinador evolucaoTreinador = await _evolucaoTreinadoresRepository.GetByIdETAsync(idevolcao, idtreinador);

            if(evolucaoTreinador is null)
            {
                throw new NotFoundException("Nenhum PokemonTreinador foi encontrado");
            }

            await _evolucaoTreinadoresRepository.DeleteETAsync(evolucaoTreinador);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}