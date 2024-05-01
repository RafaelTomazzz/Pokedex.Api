using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Pokedex.Api.DTO;
using Pokedex.Api.DTO.Builder;

namespace Pokedex.Api.Models
{
    [PrimaryKey(nameof(Id))]
    [Table("Treinador")]
    public class Treinador
    {
        public ICollection<PokemonTreinador>? PokemonTreinadores { get; set; }
        public ICollection<EvolucaoTreinador>? EvolucaoTreinadores { get; set; }
        public ICollection<ItemTreinador>? ItemTreinadores { get; set; }
        
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

        public Treinador()
        {}

        public Treinador(string pnome)
        {
            PNome = pnome;
        }

        public Treinador(string pnome, string snome)
        {
            PNome = pnome;
            SNome = snome;
        }
        public Treinador(string pnome, string snome, string login)
        {
            PNome = pnome;
            SNome = snome;
            Login = login;
        }

        public TreinadorDTO ToTreinador()
        {
            TreinadorDTO treinadorDTO = new TreinadorDTOBuilder()
                .WithPNome(PNome)
                .WithSNome(SNome)
                .WithLogin(Login)
                .Build();

            return treinadorDTO;
        }




    }
}