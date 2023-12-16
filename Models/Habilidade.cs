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

        public ICollection<EvolucaoHabilidade>? EvolucaoHabilidades {get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get; set;}

        [Required]
        [NotNull]
        [Column("Nome_Habilidade")]
        [StringLength(40)]
        public string Nome {get; set;}

        [Required]
        [NotNull]
        [Column("Descricao")]
        [StringLength(40)]
        public string Descricao {get; set;}

        [Required]
        [NotNull]
        [Column("Elemento")]
        public Elemento Elemento {get; set;}

        [Column("Power")]
        public int Power {get; set;}

        [Column("Pontos_Precisao")]
        public int PtPrecisao {get; set;}

        [Required]
        [NotNull]
        [Column("Pontos_Power")]
        public int PtPower {get; set;}
        
    }
}