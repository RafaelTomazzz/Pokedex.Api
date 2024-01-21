using Pokedex.Api.Models.Enuns;

namespace Pokedex.Api.DTO
{
    public class EvolucaoDTO
    {
        public string Nome {get; set;}
        public float Peso {get; set;}
        public float Altura {get; set;}
        public int MinVida { get; set;}
        public int MaxVida { get; set;}
        public int MinAtaque { get; set;}
        public int MaxAtaque { get; set;}
        public int MinDefesa { get; set;}
        public int MaxDefesa { get; set;}
        public int MinVelocidade { get; set;}
        public int MaxVelocidade { get; set;}
        public Elemento Elemento { get; set;}
        public SegundoElemento? SegundoElemento { get; set;}
        public int Codigo { get; set;}
        public bool Apanhado { get; set;}
        public string Descricao { get; set;}
        public string Imagem { get; set;}

    }
}