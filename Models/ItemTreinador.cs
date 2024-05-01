using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Pokedex.Api.Models.Enuns;
using Pokedex.Api.DTO;
using Pokedex.Api.DTO.Builder;

namespace Pokedex.Api.Models
{
    [Table("ItemTreinador")]
    [PrimaryKey(nameof(IdItem), nameof(IdTreinador))]
    public class ItemTreinador
    {
        [Required]
        [NotNull]
        [ForeignKey("Id_Item")]
        public int IdItem { get; set; }
        [NotMapped]
        public virtual Item? Item { get; set; }

        [Required]
        [NotNull]
        [ForeignKey("Id_Treinador")]
        public int IdTreinador { get; set; }
        [NotMapped]
        public virtual Treinador? Treinador { get; set; }
    }
}