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
         public EvolucaoDTOBuilder WithMinVida(int minVida)
        {
            _evolucaoDTO.MinVida = minVida;
            return this;
        }

        public EvolucaoDTOBuilder WithMaxVida(int maxVida)
        {
            _evolucaoDTO.MaxVida = maxVida;
            return this;
        }

        public EvolucaoDTOBuilder WithMinDefesa(int minDefesa)
        {
            _evolucaoDTO.MinDefesa = minDefesa;
            return this;
        }
        public EvolucaoDTOBuilder WithMaxDefesa(int maxDefesa)
        {
            _evolucaoDTO.MaxDefesa = maxDefesa;
            return this;
        }

        public EvolucaoDTOBuilder WithMinAtaque(int minAtaque)
        {
            _evolucaoDTO.MinAtaque = minAtaque;
            return this;
        }

        public EvolucaoDTOBuilder WithMaxAtaque(int maxAtaque)
        {
            _evolucaoDTO.MaxAtaque = maxAtaque;
            return this;
        }

        public EvolucaoDTOBuilder WithMinVelocidade(int minVelocidade)
        {
            _evolucaoDTO.MinVelocidade = minVelocidade;
            return this;
        }

        public EvolucaoDTOBuilder WithMaxVelocidade(int maxVelocidade)
        {
            _evolucaoDTO.MaxVelocidade = maxVelocidade;
            return this;
        }

        public EvolucaoDTOBuilder WithElemento(Elemento elemento)
        {
            _evolucaoDTO.Elemento = elemento;
            return this;
        }

        public EvolucaoDTOBuilder WithSegundoElemento(SegundoElemento segundoElemento)
        {
            _evolucaoDTO.SegundoElemento = segundoElemento;
            return this;
        }

        public EvolucaoDTOBuilder WithCogido(string codigo)
        {
            _evolucaoDTO.Codigo = codigo;
            return this;
        }

        public EvolucaoDTOBuilder WithDescricao(string descricao)
        {
            _evolucaoDTO.Descricao = descricao;
            return this;
        }

        public EvolucaoDTOBuilder WithApanhado(bool apanhado)
        {
            _evolucaoDTO.Apanhado = apanhado;
            return this;
        }

        public EvolucaoDTO Build()
        {
            return _evolucaoDTO;
        }
    }
}