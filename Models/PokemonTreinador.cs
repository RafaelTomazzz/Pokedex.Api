using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Pokedex.Api.Models.Enuns;
using Pokedex.Api.DTO.Builder;
using Pokedex.Api.DTO;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Pokedex.Api.Models
{
    [Table("PokemonTreinador")]
    [PrimaryKey(nameof(IdTreinador), nameof(IdPokemon))]

    public class PokemonTreinador
    {
        [Required]
        [NotNull]
        [ForeignKey("Id_Pokemon")]
        public int IdPokemon { get; set; }
        [NotMapped]
        public virtual Pokemon? Pokemon{ get; set; }

        [Required]
        [NotNull]
        [ForeignKey("Id_Pokemon")]
        public int IdTreinador { get; set; }
        [NotMapped]
        public virtual Treinador? Treinador{ get; set; }
    }
}