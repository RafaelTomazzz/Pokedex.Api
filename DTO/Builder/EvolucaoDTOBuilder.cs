using Pokedex.Api.Models.Enuns;

namespace Pokedex.Api.DTO.Builder
{
    public class EvolucaoDTOBuilder
    {
        private EvolucaoDTO _evolucaoDTO = new EvolucaoDTO();

        public EvolucaoDTOBuilder WithNome(string nome)
        {
            _evolucaoDTO.Nome = nome;
            return this;
        }
        public EvolucaoDTOBuilder WithPeso(float peso)
        {
            _evolucaoDTO.Peso = peso;
            return this;
        }
        public EvolucaoDTOBuilder WithAltura(float altura)
        {
            _evolucaoDTO.Altura = altura;
            return this;
        }
        public EvolucaoDTOBuilder WithPtVida(int ptVida)
        {
            _evolucaoDTO.PtVida = ptVida;
            return this;
        }
        public EvolucaoDTOBuilder WithPtDefesa(int ptDefesa)
        {
            _evolucaoDTO.PtDefesa = ptDefesa;
            return this;
        }
        public EvolucaoDTOBuilder WithPtAtaque(int ptAtaque)
        {
            _evolucaoDTO.PtAtaque = ptAtaque;
            return this;
        }
        public EvolucaoDTOBuilder WithPtVelocidade(int ptVelocidade)
        {
            _evolucaoDTO.PtVelocidade = ptVelocidade;
            return this;
        }

        public EvolucaoDTOBuilder WithElemento(Elemento elemento)
        {
            _evolucaoDTO.Elemento = elemento;
            return this;
        }

        public EvolucaoDTO Build()
        {
            return _evolucaoDTO;
        }
    }
}