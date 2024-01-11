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

        public PokemonDTOBuilder WithPtVida(int ptVida)
        {
            _pokemonDTO.PtVida = ptVida;
            return this;
        }

        public PokemonDTOBuilder WithPtDefesa(int ptDefesa)
        {
            _pokemonDTO.PtDefesa = ptDefesa;
            return this;
        }

        public PokemonDTOBuilder WithPtAtaque(int ptAtaque)
        {
            _pokemonDTO.PtAtaque = ptAtaque;
            return this;
        }

        public PokemonDTOBuilder WithPtVelocidade(int ptVelocidade)
        {
            _pokemonDTO.PtVelocidade = ptVelocidade;
            return this;
        }

        public PokemonDTOBuilder WithElemento(Elemento elemento)
        {
            _pokemonDTO.Elemento = elemento;
            return this;
        }

        public PokemonDTO Builder()
        {
            return _pokemonDTO;
        }
    }
}