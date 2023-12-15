using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Pokedex.Api.Models
{
    [PrimaryKey(nameof(Id))]
    [Table("Treinador")]
    public class Treinador
    {
        public ICollection<Pokemon>? Pokemons { get; set; }
        public ICollection<Item>? Itens { get; set; }
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get; set; }

        [Required]
        [NotNull]
        [Column("Primeiro_Nome")]
        [StringLength(20)]
        public string PNome {get; set; }

        [Required]
        [NotNull]
        [Column("Segundo_Nome")]
        [StringLength(20)]
        public string SNome {get; set; }

        [Required]
        [NotNull]
        [Column("Data_Nascimento")]
        public DateTime DtNascimento {get; set;}

        [Required]
        [NotNull]
        [Column("Login")]
        [StringLength(15)]
        public string Login {get; set; }

        [Required]
        [NotNull]
        [Column("Senha")]
        [StringLength(15)]
        public string Senha {get; set; }
    }
}