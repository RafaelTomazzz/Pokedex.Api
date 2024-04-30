using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Pokedex.Api.Models.Enuns;

namespace Pokedex.Api.Models
{   
    [Table("EvolucaoHabilidade")]
    [PrimaryKey(nameof(IdHabilidade), nameof(IdEvolucao))]
    public class EvolucaoHabilidade
    {
        [Required]
        [NotNull]
        [ForeignKey("Id_Habilidade")]
        public int IdHabilidade {get; set; }
        [NotMapped]
        public virtual Habilidade? Habilidade {get; set; }

        [Required]
        [NotNull]
        [ForeignKey("Id_Evolucao")]
        public int IdEvolucao {get; set; }
        [NotMapped]
        public virtual Evolucao? Evolucao {get; set; }
    }
}