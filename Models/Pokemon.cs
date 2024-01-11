using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Pokedex.Api.Models.Enuns;
using Pokedex.Api.DTO.Builder;
using Pokedex.Api.DTO;

namespace Pokedex.Api.Models
{
    [PrimaryKey(nameof(Id))]
    [Table("Pokemon")]
    public class Pokemon
    {
        public ICollection<Evolucao>? Evolucoes {get; set;}
        public ICollection<PokemonHabilidade>? PokemonHabilidades {get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get; set; }

        [Required]
        [NotNull]
        [Column("Nome_Pokemon")]
        [StringLength(20)]
        public string Nome {get; set;}

        [Required]
        [NotNull]
        [Column("Peso_Pokemon")]
        [StringLength(3)]
        public float Peso {get; set;}

        [Required]
        [NotNull]
        [Column("Altura_Pokemon")]
        [StringLength(3)]
        public float Altura {get; set;}

        [Required]
        [NotNull]
        [ForeignKey("Id_Treinador")]
        public int IdTreinador { get; set;}
        [NotMapped]
        public virtual Treinador? Treinador { get; set;}

        [Required]
        [NotNull]
        [Column("Pontos_Vida")]
        public int PtVida { get; set;}

        [Required]
        [NotNull]
        [Column("Pontos_Ataque")]
        public int PtAtaque { get; set;}

        [Required]
        [NotNull]
        [Column("Pontos_Defesa")]
        public int PtDefesa { get; set;}

        [Required]
        [NotNull]
        [Column("Pontos_Velocidade")]
        public int PtVelocidade { get; set;}

        [Required]
        [NotNull]
        [Column("Elemento")]
        public Elemento Elemento { get; set;}

        public Pokemon()
        {}

        public Pokemon(string nome)
        {
            Nome = nome;
        }

        public Pokemon(string nome, float peso)
        {
            Nome = nome;
            Peso = peso;
        }
        
        public Pokemon(string nome, float peso, float altura)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
        }

        public Pokemon(string nome, float peso, float altura, int ptVida)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
            PtVida = ptVida;
        }
        public Pokemon(string nome, float peso, float altura, int ptVida, int ptDefesa)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
            PtVida = ptVida;
            PtDefesa = ptDefesa;
        }
        public Pokemon(string nome, float peso, float altura, int ptVida, int ptDefesa, int ptAtaque)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
            PtVida = ptVida;
            PtDefesa = ptDefesa;
            PtAtaque = ptAtaque;
        }
        public Pokemon(string nome, float peso, float altura, int ptVida, int ptDefesa, int ptAtaque, int ptVelocidade)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
            PtVida = ptVida;
            PtDefesa = ptDefesa;
            PtAtaque = ptAtaque;
            PtVelocidade = ptVelocidade;
        }

        public Pokemon(string nome, float peso, float altura, int ptVida, int ptDefesa, int ptAtaque, int ptVelocidade, Elemento elemento)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
            PtVida = ptVida;
            PtDefesa = ptDefesa;
            PtAtaque = ptAtaque;
            PtVelocidade = ptVelocidade;
            Elemento = elemento;
        }

        public PokemonDTO ToPokemon()
        {
            PokemonDTO pokemonDTO = new PokemonDTOBuilder()
                .WithNome(Nome)
                .WithPeso(Peso)
                .WithAltura(Altura)
                .WithPtVida(PtVida)
                .WithPtDefesa(PtDefesa)
                .WithPtAtaque(PtAtaque)
                .WithPtVelocidade(PtVelocidade)
                .WithElemento(Elemento)
                .Builder();

                return pokemonDTO;

        }
    }
}