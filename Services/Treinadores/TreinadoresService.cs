using Pokedex.Api.Models;
using Pokedex.Api.Services.Interfaces;
using Pokedex.Api.Repositories;
using Pokedex.Api.Repositories.Interfaces;
using Pokedex.Api.Exceptions;
using Pokedex.Api.Repositories.UnitOfWork;
using Pokedex.Api.DTO;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Security.Claims;


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

        public async Task<bool> Autenticar(LoginDTO loginDTO)
        {
            Treinador treinador = await _treinadoresRepository.GetByLoginTreinadorAsnc(loginDTO.Login);

            if ( treinador.Senha != loginDTO.Senha)
            {
                return false;
            }

            return true;
        }

        public async Task<bool> Existe(LoginDTO loginDTO)
        {
            Treinador treinador = await _treinadoresRepository.GetByLoginTreinadorAsnc(loginDTO.Login);
            
            if (treinador == null)
            {
                return false;
            }

            return true;
        }

        public async Task<bool> VerificarSenha(LoginDTO loginDTO)
        {
            Treinador treinador = await _treinadoresRepository.GetByLoginTreinadorAsnc(loginDTO.Login);

            if(loginDTO.Senha == treinador.Senha)
            {
                return true;
            }
            
            return false;
        }

        public async Task<string> GenerateToken(LoginDTO loginDTO)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Settings.Secret);
            
            var TokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim []
                {
                    new Claim(ClaimTypes.Name, loginDTO.Login.ToString()),
                }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature
                )

            };

            var token = tokenHandler.CreateToken(TokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}