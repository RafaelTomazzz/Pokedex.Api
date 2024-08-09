using Pokedex.Api.Models.Enuns;

namespace Pokedex.Api.DTO.Builder
{
    public class PokemonDTOBuilder
    {
        private PokemonDTO _pokemonDTO = new PokemonDTO();

        public PokemonDTOBuilder WithNome(string nome)
        {
            _pokemonDTO.Nome = nome;
            return this;
        } 

        public PokemonDTOBuilder WithPeso(float peso)
        {
            _pokemonDTO.Peso = peso;
            return this;
        }

        public PokemonDTOBuilder WithAltura(float altura)
        {
            _pokemonDTO.Altura = altura;
            return this;
        }

        public PokemonDTOBuilder WithMinVida(int minVida)
        {
            _pokemonDTO.MinVida = minVida;
            return this;
        }

        public PokemonDTOBuilder WithMaxVida(int maxVida)
        {
            _pokemonDTO.MaxVida = maxVida;
            return this;
        }

        public PokemonDTOBuilder WithMinDefesa(int minDefesa)
        {
            _pokemonDTO.MinDefesa = minDefesa;
            return this;
        }
        public PokemonDTOBuilder WithMaxDefesa(int maxDefesa)
        {
            _pokemonDTO.MaxDefesa = maxDefesa;
            return this;
        }

        public PokemonDTOBuilder WithMinAtaque(int minAtaque)
        {
            _pokemonDTO.MinAtaque = minAtaque;
            return this;
        }

        public PokemonDTOBuilder WithMaxAtaque(int maxAtaque)
        {
            _pokemonDTO.MaxAtaque = maxAtaque;
            return this;
        }

        public PokemonDTOBuilder WithMinVelocidade(int minVelocidade)
        {
            _pokemonDTO.MinVelocidade = minVelocidade;
            return this;
        }

        public PokemonDTOBuilder WithMaxVelocidade(int maxVelocidade)
        {
            _pokemonDTO.MaxVelocidade = maxVelocidade;
            return this;
        }

        public PokemonDTOBuilder WithElemento(Elemento elemento)
        {
            _pokemonDTO.Elemento = elemento;
            return this;
        }

        public PokemonDTOBuilder WithSegundoElemento(SegundoElemento segundoElemento)
        {
            _pokemonDTO.SegundoElemento = segundoElemento;
            return this;
        }

        public PokemonDTOBuilder WithCogido(int codigo)
        {
            _pokemonDTO.Codigo = codigo;
            return this;
        }

        public PokemonDTOBuilder WithImagem(string imagem)
        {
            _pokemonDTO.Imagem = imagem;
            return this;
        }
        public PokemonDTOBuilder WithDescricao(string descricao)
        {
            _pokemonDTO.Descricao = descricao;
            return this;
        }
        
        public PokemonDTO Builder()
        {
            return _pokemonDTO;
        }
    }
}