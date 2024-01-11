using Pokedex.Api.Models.Enuns;

namespace Pokedex.Api.DTO
{
    public class PokemonDTO
    {
        public string Nome {get; set;}
        public float Peso {get; set;}
        public float Altura {get; set;}
        public int PtVida { get; set;}
        public int PtAtaque { get; set;}
        public int PtDefesa { get; set;}
        public int PtVelocidade { get; set;}
        public Elemento Elemento { get; set;}
    }
}