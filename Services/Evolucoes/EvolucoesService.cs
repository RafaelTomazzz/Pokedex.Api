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

            if(novaEvolucao.MinVida <= 10 | novaEvolucao.MaxVida <= 10)
            {
                throw new Exception("O HP do pokemon não pode ser menor ou igual a 10");
            }
            else if(novaEvolucao.MinAtaque <= 10 | novaEvolucao.MaxAtaque <= 10 )
            {
                throw new Exception("O ataque do pokemon não pode ser menor ou igual a 10");
            }
            else if(novaEvolucao.MinDefesa <= 10 | novaEvolucao.MaxDefesa <= 10)
            {
                throw new Exception("A defesa do pokemon não pode ser menor que 10");
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
            evolucao.MinVida = alteracaoEvolucao.MinVida;
            evolucao.MaxVida = alteracaoEvolucao.MaxVida;
            evolucao.MinAtaque = alteracaoEvolucao.MinAtaque;
            evolucao.MaxAtaque = alteracaoEvolucao.MaxAtaque;
            evolucao.MinDefesa = alteracaoEvolucao.MinDefesa;
            evolucao.MaxDefesa = alteracaoEvolucao.MaxDefesa;
            evolucao.MinVelocidade = alteracaoEvolucao.MinVelocidade;
            evolucao.MaxVelocidade = alteracaoEvolucao.MaxVelocidade;
            evolucao.Codigo = alteracaoEvolucao.Codigo;
            evolucao.Descricao = alteracaoEvolucao.Descricao;
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