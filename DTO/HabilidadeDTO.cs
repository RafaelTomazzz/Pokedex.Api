using Pokedex.Api.Models.Enuns;

namespace Pokedex.Api.DTO
{
    public class HabilidadeDTO
    {
        public string Nome {get; set;}
        public string Descricao {get; set;}
        public Elemento Elemento {get; set;}
        public int Power {get; set;}
        public int PtPrecisao {get; set;}
        public int PtPower {get; set;}
    }
}