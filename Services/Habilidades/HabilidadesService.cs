using Pokedex.Api.Exceptions;
using Pokedex.Api.Models;
using Pokedex.Api.Repositories.Interfaces;
using Pokedex.Api.Repositories.UnitOfWork;
using Pokedex.Api.Services.Interfaces;

namespace Pokedex.Api.Services
{
    public class HabilidadesService : IHabilidadesService
    {
        private readonly IHabilidadesRepository _habilidadesRepository;
        private readonly IUnitOfWork _unitOfWork;

        public HabilidadesService(IHabilidadesRepository habilidadesRepository, IUnitOfWork unitOfWork)
        {
            _habilidadesRepository = habilidadesRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Habilidade>> GetAllHabilidadeAsync()
        {
            IEnumerable<Habilidade> habilidades = await _habilidadesRepository.GetAllHabilidadeAsync();

            if(habilidades is null)
            {
                throw new NotFoundException("Nenhuma habilidade foi encontrada");
            }

            return habilidades;
        }

        public async Task<Habilidade> GetByIdHabilidadeAsync(int id)
        {
            Habilidade habilidade = await _habilidadesRepository.GetByIdHabilidadeAsync(id);

            if(habilidade is null)
            {
                throw new NotFoundException("Nenhuma habilidade foi encontrada");
            }

            return habilidade;
        }

        public async Task<Habilidade> PostHabilidadeAsync(Habilidade novaHabilidade)
        {
            Habilidade habilidade = await _habilidadesRepository.GetByNomeHabilidade(novaHabilidade.Nome);

            if(habilidade is null)
            {
                throw new Exception("Já existe uma habilidade com este nome");
            }

            await _habilidadesRepository.PostHabilidadeAsync(habilidade);
            await _unitOfWork.SaveChangesAsync();
            return habilidade;
        }

        public async Task<Habilidade> UpdateHabilidadeAsync(int id, Habilidade alteracaoHabilidade)
        {
            Habilidade habilidade = await _habilidadesRepository.GetByIdHabilidadeAsync(id);

            if(habilidade is null)
            {
                throw new NotFoundException("Nenhuma habilidade foi encontrada");
            }

            habilidade.Nome = alteracaoHabilidade.Nome;
            habilidade.Power = alteracaoHabilidade.Power;
            habilidade.PtPower = alteracaoHabilidade.PtPower;
            habilidade.PtPrecisao = alteracaoHabilidade.PtPrecisao;
            habilidade.Descricao = alteracaoHabilidade.Descricao;
            habilidade.Elemento = alteracaoHabilidade.Elemento;
            await _unitOfWork.SaveChangesAsync();

            return habilidade;
        }

        public async Task DeleteHabilidadeAsync(int id)
        {
            Habilidade habilidade = await _habilidadesRepository.GetByIdHabilidadeAsync(id);

            if(habilidade is null)
            {
                throw new NotFoundException("Nenhuma habilidade foi encontrada");
            }

            await _habilidadesRepository.DeleteHabilidadeAsync(habilidade);
        }
    }
}