using System.ComponentModel.DataAnnotations;
using Pokedex.Api.Models.Enuns;
using Pokedex.Api.DTO.Builder;
using Pokedex.Api.DTO;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Pokedex.Api.Models
{
    [Table("EvolucaoTreinador")]
    [PrimaryKey(nameof(IdEvolucao), nameof(IdTreinador))]
    public class EvolucaoTreinador
    {
        [Required]
        [NotNull]
        [ForeignKey("Id_Evolucao")]
        public int IdEvolucao { get; set; }
        [NotMapped]
        public virtual Evolucao? Evolucao{ get; set; }

        [Required]
        [NotNull]
        [ForeignKey("Id_Treinador")]
        public int IdTreinador { get; set; }
        [NotMapped]
        public virtual Treinador? Treinador{ get; set; }
    }
}