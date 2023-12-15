using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Pokedex.Api.Models.Enuns;

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
    }
}