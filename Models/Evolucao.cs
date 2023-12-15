using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Pokedex.Api.Models.Enuns;

namespace Pokedex.Api.Models
{
    [PrimaryKey(nameof(Id))]
    [Table("Evolucao")]
    public class Evolucao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get; set; }

        [Required]
        [ForeignKey("Id_Pokemon")]
        [NotNull]
        public int IdPokemon {get; set;}
        [NotMapped]
        public virtual Pokemon? Pokemon {get; set;}

        [Required]
        [NotNull]
        [Column("Nome_Pokemon")]
        [StringLength(20)]
        public string Nome {get; set;}

        [Required]
        [NotNull]
        [Column("Peso_Pokemon")]
        [StringLength(3)]
        public string Peso {get; set;}

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
        [Column("Elemento")]
        public Elemento Elemento { get; set;}
    }
}