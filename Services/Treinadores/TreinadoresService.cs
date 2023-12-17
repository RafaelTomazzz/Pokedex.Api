using Pokedex.Api.Models;
using Pokedex.Api.Services.Interfaces;
using Pokedex.Api.Repositories;
using Pokedex.Api.Repositories.Interfaces;
using Pokedex.Api.Exceptions;
using Pokedex.Api.Repositories.UnitOfWork;


namespace Pokedex.Api.Services
{
    public class TreinadoresService : ITreinadoresService
    {
        private readonly ITreinadoresRepository _treinadoresRepository;
        private readonly IUnitOfWork _unitOfWork;

        public TreinadoresService(ITreinadoresRepository treinadoresRepository, IUnitOfWork unitOfWork)
        {
            _treinadoresRepository = treinadoresRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Treinador>> GetAllTreinadorAsync()
        {
            IEnumerable<Treinador> treinadores = await _treinadoresRepository.GetAllTreinadoresAsync();

            if(treinadores is null)
            {
                throw new NotFoundException("Nenhum treinador foi encontrado");
            }
            return treinadores;
        }

        public async Task<Treinador> GetByIdTreinadorAsync(int id)
        {
            Treinador treinador = await _treinadoresRepository.GetByIdTreinadorAsync(id);

            if(treinador is null)
            {
                throw new NotFoundException("Este treinador não existe");
            }

            return treinador;
        }

        public async Task<Treinador> PostTreinadorAsync(Treinador treinador)
        {
            Treinador _treinador = await _treinadoresRepository.GetByLoginTreinadorAsnc(treinador.Login);

            if(_treinador != null)
            {
                throw new Exception("Este login já existe");
            }

            await _treinadoresRepository.PostTreinadorAsync(treinador);
            await _unitOfWork.SaveChangesAsync();
            return treinador;
        }

        public async Task<Treinador> UpdateTreinadorAsync(int id, Treinador alteracaoTreinador)
        {
            Treinador treinador = await _treinadoresRepository.GetByIdTreinadorAsync(id);

            if(treinador is null)
            {
                throw new NotFoundException("Este treinador não existe");
            }

            treinador.PNome = alteracaoTreinador.PNome;
            treinador.SNome = alteracaoTreinador.SNome;
            treinador.DtNascimento = alteracaoTreinador.DtNascimento;
            treinador.Login = alteracaoTreinador.Login;
            treinador.Senha = alteracaoTreinador.Senha;
            await _unitOfWork.SaveChangesAsync();

            return treinador;
        }

        public async Task DeleteTreinadorAsync(int id)
        {
            Treinador treinador = await _treinadoresRepository.GetByIdTreinadorAsync(id);
            
            if(treinador is null)
            {
                throw new NotFoundException("Este treinador não existe");
            }

            await _treinadoresRepository.DeleteTreinadorAsync(id);
        }
    }
}