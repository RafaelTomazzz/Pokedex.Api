using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Pokedex.Api.Models.Enuns;
using Pokedex.Api.DTO;
using Pokedex.Api.DTO.Builder;

namespace Pokedex.Api.Models
{
    [PrimaryKey(nameof(Id))]
    [Table("Evolucao")]
    public class Evolucao
    {
        public ICollection<EvolucaoHabilidade>? EvolucaoHabilidades {get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get; set; }

        [Required]
        [NotNull]
        [ForeignKey("Id_Pokemon")]
        public int IdPokemon {get; set;}
        [NotMapped]
        public virtual Pokemon? Pokemon {get; set;}

        [Required]
        [NotNull]
        [Column("Nome_Evolcucao")]
        [StringLength(20)]
        public string Nome {get; set;}

        [Required]
        [NotNull]
        [Column("Peso_Evolucao")]
        [StringLength(3)]
        public float Peso {get; set;}

        [Required]
        [NotNull]
        [Column("Altura_Evolucao")]
        [StringLength(3)]
        public float Altura {get; set;}

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

        public Evolucao()
        {}
        public Evolucao(string nome)
        {
            Nome = nome;
        }
        public Evolucao(string nome, float peso)
        {
            Nome = nome;
            Peso = peso;
        }
        public Evolucao(string nome, float peso, float altura)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
        }
        public Evolucao(string nome, float peso, float altura, int ptVida)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
            PtVida = ptVida;
        }
        public Evolucao(string nome, float peso, float altura, int ptVida, int ptDefesa)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
            PtVida = ptVida;
            PtDefesa = ptDefesa;
        }
        public Evolucao(string nome, float peso, float altura, int ptVida, int ptDefesa, int ptAtaque)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
            PtVida = ptVida;
            PtDefesa = ptDefesa;
            PtAtaque = ptAtaque;
        }
        public Evolucao(string nome, float peso, float altura, int ptVida, int ptDefesa, int ptAtaque, int ptVelocidade)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
            PtVida = ptVida;
            PtDefesa = ptDefesa;
            PtAtaque = ptAtaque;
            PtVelocidade = ptVelocidade;
        }

        public EvolucaoDTO ToEvolucao()
        {
            EvolucaoDTO evolucaoDTO = new EvolucaoDTOBuilder()
                .WithNome(Nome)
                .WithPeso(Peso)
                .WithAltura(Altura)
                .WithPtVida(PtVida)
                .WithPtAtaque(PtDefesa)
                .WithPtAtaque(PtAtaque)
                .WithPtVelocidade(PtVelocidade)
                .Build();

            return evolucaoDTO;
        }


    }
}