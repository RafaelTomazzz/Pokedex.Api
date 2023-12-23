using Pokedex.Api.Exceptions;
using Pokedex.Api.Models;
using Pokedex.Api.Repositories.Interfaces;
using Pokedex.Api.Repositories.UnitOfWork;
using Pokedex.Api.Services.Interfaces;

namespace Pokedex.Api.Services
{
    public class EvolucaoHabilidadeService : IEvolucaoHabilidadeService
    {
        private readonly IEvolucaoHabilidadeRepository _evolucaoHabilidadeRepository;
        private readonly IUnitOfWork _unitOfWork;

        public EvolucaoHabilidadeService(IEvolucaoHabilidadeRepository evolucaoHabilidadeRepository, IUnitOfWork unitOfWork)
        {
            _evolucaoHabilidadeRepository = evolucaoHabilidadeRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<EvolucaoHabilidade>> GetAllEHAsync()
        {
            IEnumerable<EvolucaoHabilidade> evolucaoHabilidades = await _evolucaoHabilidadeRepository.GetAllEHAsync();
            return evolucaoHabilidades;
        }

        public async Task<EvolucaoHabilidade> GetByIdEHAsync(int idevolucao, int idhabilidade)
        {
            EvolucaoHabilidade evolucaoHabilidade = await _evolucaoHabilidadeRepository.GetByIdEHAsync(idevolucao, idhabilidade);
            
            if(evolucaoHabilidade is null)
            {
                throw new NotFoundException("Objeto não encontrado");
            }

            return evolucaoHabilidade;
        }

        public async Task<EvolucaoHabilidade> PostEHAsync(EvolucaoHabilidade novaEvolucaoHabilidade)
        {
            EvolucaoHabilidade evolucaoHabilidade = await _evolucaoHabilidadeRepository.GetByIdEHAsync(novaEvolucaoHabilidade.IdEvolucao, novaEvolucaoHabilidade.IdHabilidade);

            if (evolucaoHabilidade != null)
            {
                throw new Exception("Este objeto ja existe");
            }

            _evolucaoHabilidadeRepository.PostEHAsync(novaEvolucaoHabilidade);
            _unitOfWork.SaveChangesAsync();

            return novaEvolucaoHabilidade;
        }
        
        public async Task DeteleEHAsync(int idevolucao, int idhabilidade)
        {
            EvolucaoHabilidade evolucaoHabilidade = await _evolucaoHabilidadeRepository.GetByIdEHAsync(idevolucao, idhabilidade);
            
            if(evolucaoHabilidade is null)
            {
                throw new NotFoundException("Este objeto não existe");
            }

            _evolucaoHabilidadeRepository.DeleteEHAsync(evolucaoHabilidade);
            _unitOfWork.SaveChangesAsync();
        }

    }
}