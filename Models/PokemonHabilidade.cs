using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Pokedex.Api.Models.Enuns;

namespace Pokedex.Api.Models
{  
    [Table("PokemonHabilidade")]
    public class PokemonHabilidade
    {   
        [Required]
        [NotNull]
        [ForeignKey("Id_Habilidade")]
        public int IdHabilidade {get; set; }
        [NotMapped]
        public virtual Habilidade? Habilidade {get; set; }

        [Required]
        [NotNull]
        [ForeignKey("Id_Pokemon")]
        public int IdPokemon {get; set; }
        [NotMapped]
        public virtual Pokemon? Pokemon {get; set; }
    }
}