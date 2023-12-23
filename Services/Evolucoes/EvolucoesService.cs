using Microsoft.AspNetCore.Http.HttpResults;
using Pokedex.Api.Exceptions;
using Pokedex.Api.Models;
using Pokedex.Api.Repositories.Interfaces;
using Pokedex.Api.Repositories.UnitOfWork;
using Pokedex.Api.Services.Interfaces;

namespace Pokedex.Api.Services
{
    public class EvolucoesService : IEvolucoesService
    {
        private readonly IEvolucoesRepository _evolucaoRepository;
        private readonly IUnitOfWork _unitOfWork;

        public EvolucoesService(IEvolucoesRepository evolucoesRepository, IUnitOfWork unitOfWork)
        {
            _evolucaoRepository = evolucoesRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Evolucao>> GetAllEvolucaoAsync()
        {
            IEnumerable<Evolucao> evolucoes = await _evolucaoRepository.GetAllEvolucaoAsync();

            if(evolucoes is null)
            {
                throw new NotFoundException("Nenhum objeto encontrado");
            }

            return evolucoes;
        }

        public async Task<Evolucao> GetByIdAsync(int id)
        {
            Evolucao evolucao = await _evolucaoRepository.GetByIdEvolucaoAsync(id);

            if(evolucao is null)
            {
                throw new NotFoundException("Este objeto não existe");
            }

            return evolucao;
        }

        public async Task<Evolucao> PostEvolucaoAsync(Evolucao novaEvolucao)
        {
            Evolucao evolucao = await _evolucaoRepository.GetByNomeEvolucaoAsync(novaEvolucao.Nome);

            if(novaEvolucao.PtVida > 250)
            {
                throw new Exception("O HP do pokemon não pode ser maior que 250");
            }
            else if(novaEvolucao.PtDefesa > 230)
            {
                throw new Exception("A defesa do pokemon não pode ser maior que 230");
            }
            else if(novaEvolucao.PtAtaque > 170)
            {
                throw new Exception("O ataque do pokemon não pode ser maior que 170");
            }

            await _evolucaoRepository.PostEvolucaoAsync(novaEvolucao);
            await _unitOfWork.SaveChangesAsync();
            return evolucao;
        }

        public async Task<Evolucao> UpdateAsync(int id, Evolucao alteracaoEvolucao)
        {
            Evolucao evolucao = await _evolucaoRepository.GetByIdEvolucaoAsync(id);

            if(evolucao is null)
            {
                throw new NotFoundException("Nenhum objeto encontrado");
            }

            evolucao.Nome = alteracaoEvolucao.Nome;
            evolucao.Elemento = alteracaoEvolucao.Elemento;
            evolucao.Peso = alteracaoEvolucao.Peso;
            evolucao.Altura = alteracaoEvolucao.Altura;
            evolucao.PtVida = alteracaoEvolucao.PtVida;
            evolucao.PtDefesa = alteracaoEvolucao.PtDefesa;
            evolucao.PtAtaque = alteracaoEvolucao.PtAtaque;
            await _unitOfWork.SaveChangesAsync();

            return evolucao;
        }

        public async Task DeleteEvolucaoAsync(int id)
        {
            Evolucao evolucao = await _evolucaoRepository.GetByIdEvolucaoAsync(id);

            if(evolucao is null)
            {
                throw new NotFoundException("Nenhum objeto foi encontrado");
            }

            await _evolucaoRepository.DeleteEvolucaoAsync(evolucao);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}