using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Pokedex.Api.Models.Enuns;

namespace Pokedex.Api.Models
{
    [PrimaryKey(nameof(Id))]
    [Table("Habilidade")]
    public class Habilidade
    {
        public ICollection<PokemonHabilidade>? PokemonHabilidades {get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get; set;}

        [Required]
        [NotNull]
        [Column("Descricao")]
        [StringLength(40)]
        public string Descricao {get; set;}

        [Required]
        [NotNull]
        [Column("Pontos_Vida")]
        public int PtVida {get; set;}

        [Required]
        [NotNull]
        [Column("Pontos_Defesa")]
        public int PtDefesa {get; set;}
        
        [Required]
        [NotNull]
        [Column("Pontos_Ataque")]
        public int PtAtaque {get; set;}
    }
}