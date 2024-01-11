using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Pokedex.Api.Models.Enuns;
using Pokedex.Api.DTO;
using Pokedex.Api.DTO.Builder;

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

        public Habilidade()
        {}

        public Habilidade(string nome)
        {
            Nome = nome;
        }

        public Habilidade(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }

        public Habilidade(string nome, string descricao, Elemento elemento)
        {
            Nome = nome;
            Descricao = descricao;
            Elemento = elemento;
        }

        public Habilidade(string nome, string descricao, Elemento elemento, int power)
        {
            Nome = nome;
            Descricao = descricao;
            Elemento = elemento;
            Power = power;
        }
        public Habilidade(string nome, string descricao, Elemento elemento, int power, int ptPrecisao)
        {
            Nome = nome;
            Descricao = descricao;
            Elemento = elemento;
            Power = power;
            PtPrecisao = ptPrecisao;
        }
        public Habilidade(string nome, string descricao, Elemento elemento, int power, int ptPrecisao, int ptPower)
        {
            Nome = nome;
            Descricao = descricao;
            Elemento = elemento;
            Power = power;
            PtPrecisao = ptPrecisao;
            PtPower = ptPower;
        }

        public HabilidadeDTO ToHabilidade()
        {
            HabilidadeDTO habilidadeDTO = new HabilidadeDTOBuilder()
                .WithNome(Nome)
                .WithDescricao(Descricao)
                .WithElemento(Elemento)
                .WithPower(Power)
                .WithPtPrecisao(PtPrecisao)
                .WithPtPower(PtPower)
                .Build();

            return habilidadeDTO;
        }

    }
}