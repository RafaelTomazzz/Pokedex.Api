using Pokedex.Api.Models.Enuns;

namespace Pokedex.Api.DTO.Builder
{
    public class HabilidadeDTOBuilder
    {
        private HabilidadeDTO _habilidadeDTO = new HabilidadeDTO();

        public HabilidadeDTOBuilder WithNome(string nome)
        {
            _habilidadeDTO.Nome = nome;
            return this;
        }

        public HabilidadeDTOBuilder WithDescricao(string descricao)
        {
            _habilidadeDTO.Descricao = descricao;
            return this;
        }

        public HabilidadeDTOBuilder WithElemento(Elemento elemento)
        {
            _habilidadeDTO.Elemento = elemento;
            return this;
        }

        public HabilidadeDTOBuilder WithPower(int power)
        {
            _habilidadeDTO.Power = power;
            return this;
        }

        public HabilidadeDTOBuilder WithPtPrecisao(int ptPrecisao)
        {
            _habilidadeDTO.PtPrecisao = ptPrecisao;
            return this;
        }

        public HabilidadeDTOBuilder WithPtPower(int ptPower)
        {
            _habilidadeDTO.PtPower = ptPower;
            return this;
        }

        public HabilidadeDTO Build()
        {
            return _habilidadeDTO;
        }
    }
}