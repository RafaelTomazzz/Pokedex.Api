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
    [Table("Item")]
    public class Item
    {
        public ICollection<ItemTreinador>? ItemTreinadores { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set;}

        [Required]
        [NotNull]
        [Column("Nome")]
        [StringLength(20)]
        public string Nome { get; set;}

        [Required]
        [NotNull]
        [Column("Pontos_Vida")]
        public int PtVida { get; set;}

        [Required]
        [NotNull]
        [Column("Pontos_Defesa")]
        public int PtDefesa { get; set;}
        
        [Required]
        [NotNull]
        [Column("Pontos_Ataque")]
        public int PtAtaque { get; set;}

        [Required]
        [NotNull]
        [Column("Descricao")]
        public string Descricao { get; set;}

        [Column("Elemento")]
        public Elemento? Elemento { get; set;}

        public Item()
        {}

        public Item(string nome)
        {
            Nome = nome;
        }
        public Item(string nome, int ptVida)
        {
            Nome = nome;
            PtVida = ptVida;
        }
        public Item(string nome, int ptVida, int ptDefesa)
        {
            Nome = nome;
            PtVida = ptVida;
            PtDefesa = ptDefesa;
        }
        public Item(string nome, int ptVida, int ptDefesa, int ptAtaque)
        {
            Nome = nome;
            PtVida = ptVida;
            PtDefesa = ptDefesa;
            PtAtaque = ptAtaque;
        }
        public Item(string nome, int ptVida, int ptDefesa, int ptAtaque, string descricao)
        {
            Nome = nome;
            PtVida = ptVida;
            PtDefesa = ptDefesa;
            PtAtaque = ptAtaque;
            Descricao = descricao;
        }

        public ItemDTO ToItem()
        {
            ItemDTO itemDTO = new ItemDTOBuilder()
                .WithNome(Nome)
                .WithPtVida(PtVida)
                .WithPtDefesa(PtDefesa)
                .WithPtAtaque(PtAtaque)
                .WithDescricao(Descricao)
                .Build();
            
            return itemDTO;
        }
    }

}