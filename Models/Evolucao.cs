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
    [Table("Evolucao")]
    public class Evolucao
    {
        public ICollection<EvolucaoHabilidade>? EvolucaoHabilidades {get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get; set; }

        [Required]
        [NotNull]
        [ForeignKey("Id_Pokemon")]
        public int IdPokemon {get; set;}
        [NotMapped]
        public virtual Pokemon? Pokemon {get; set;}

        [Required]
        [NotNull]
        [Column("Nome_Evolcucao")]
        [StringLength(20)]
        public string Nome {get; set;}

        [Required]
        [NotNull]
        [Column("Peso_Evolucao")]
        [StringLength(3)]
        public float Peso {get; set;}

        [Required]
        [NotNull]
        [Column("Altura_Evolucao")]
        [StringLength(3)]
        public float Altura {get; set;}

        [Required]
        [NotNull]
        [Column("Codigo")]
        public string Codigo { get; set;}

        [Required]
        [NotNull]
        [Column("Min_Vida")]
        [Comment("Status base da vida")]
        public int MinVida { get; set;}

        [Required]
        [NotNull]
        [Column("Max_Vida")]
        [Comment("Status maximo da vida")]
        public int MaxVida { get; set;}

        [Required]
        [NotNull]
        [Column("Min_Ataque")]
        [Comment("Status base do ataque")]
        public int MinAtaque { get; set;}
        
        [Required]
        [NotNull]
        [Column("Max_Ataque")]
        [Comment("Status maximo do ataque")]
        public int MaxAtaque { get; set;}

        [Required]
        [NotNull]
        [Column("Min_Defesa")]
        [Comment("Status base da defesa")]
        public int MinDefesa { get; set;}
        
        [Required]
        [NotNull]
        [Column("Max_Defesa")]
        [Comment("Status maximo da defesa")]
        public int MaxDefesa { get; set;}

        [Required]
        [NotNull]
        [Column("Min_Velocidade")]
        [Comment("status base da velocidade")]
        public int MinVelocidade { get; set;}

        [Required]
        [NotNull]
        [Column("Max_Velocidade")]
        [Comment("status maximo da velocidade")]
        public int MaxVelocidade { get; set;}

        [Required]
        [NotNull]
        [Column("Elemento")]
        public Elemento Elemento { get; set;}

        [Column("SegundoElemento")]
        public SegundoElemento SegundoElemento { get; set;} = SegundoElemento.Nenhum;

        [Required]
        [NotNull]
        [Column("Apanhado")]
        public bool Apanhado { get; set;} = false;

        [Required]
        [NotNull]
        [Column("Descricao")]
        [StringLength(250)]
        public string Descricao { get; set;}
        
        
        
        public Evolucao()
        {}

        public Evolucao(string nome)
        {
            Nome = nome;
        }

        public Evolucao(string nome, float peso)
        {
            Nome = nome;
            Peso = peso;
        }
        
        public Evolucao(string nome, float peso, float altura)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
        }

        public Evolucao(string nome, float peso, float altura, int minVida)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
            MinVida = minVida;
        }

        public Evolucao(string nome, float peso, float altura, int minVida, int maxVida)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
            MinVida = minVida;
            MaxVida = maxVida;
        }

        public Evolucao(string nome, float peso, float altura, int minVida, int maxVida, int minAtaque)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
            MinVida = minVida;
            MaxVida = maxVida;
            MinAtaque = minAtaque;
        }

        public Evolucao(string nome, float peso, float altura, int minVida, int maxVida, int minAtaque, int maxAtaque)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
            MinVida = minVida;
            MaxVida = maxVida;
            MinAtaque = minAtaque;
            MaxAtaque = maxAtaque;
        }

        public Evolucao(string nome, float peso, float altura, int minVida, int maxVida, int minAtaque, int maxAtaque, int minDefesa)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
            MinVida = minVida;
            MaxVida = maxVida;
            MinAtaque = minAtaque;
            MaxAtaque = maxAtaque;
            MinDefesa = minDefesa;
        }

        public Evolucao(string nome, float peso, float altura, int minVida, int maxVida, int minAtaque, int maxAtaque, int minDefesa, int maxDefesa)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
            MinVida = minVida;
            MaxVida = maxVida;
            MinAtaque = minAtaque;
            MaxAtaque = maxAtaque;
            MinDefesa = minDefesa;
            MaxDefesa = maxDefesa;
        }

        public Evolucao(string nome, float peso, float altura, int minVida, int maxVida, int minAtaque, int maxAtaque, int minDefesa, int maxDefesa, int minVelocidade)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
            MinVida = minVida;
            MaxVida = maxVida;
            MinAtaque = minAtaque;
            MaxAtaque = maxAtaque;
            MinDefesa = minDefesa;
            MaxDefesa = maxDefesa;
            MinVelocidade = minVelocidade;
        }

        public Evolucao(string nome, float peso, float altura, int minVida, int maxVida, int minAtaque, int maxAtaque, int minDefesa, int maxDefesa, int minVelocidade, int maxVelocidade)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
            MinVida = minVida;
            MaxVida = maxVida;
            MinAtaque = minAtaque;
            MaxAtaque = maxAtaque;
            MinDefesa = minDefesa;
            MaxDefesa = maxDefesa;
            MinVelocidade = minVelocidade;
            MaxVelocidade = maxVelocidade;
        }

        public Evolucao(string nome, float peso, float altura, int minVida, int maxVida, int minAtaque, int maxAtaque, int minDefesa, int maxDefesa, int minVelocidade, int maxVelocidade, Elemento elemento)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
            MinVida = minVida;
            MaxVida = maxVida;
            MinAtaque = minAtaque;
            MaxAtaque = maxAtaque;
            MinDefesa = minDefesa;
            MaxDefesa = maxDefesa;
            MinVelocidade = minVelocidade;
            MaxVelocidade = maxVelocidade;
            Elemento = elemento;
        }

        public Evolucao(string nome, float peso, float altura, int minVida, int maxVida, int minAtaque, int maxAtaque, int minDefesa, int maxDefesa, int minVelocidade, int maxVelocidade, Elemento elemento, SegundoElemento segundoElemento)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
            MinVida = minVida;
            MaxVida = maxVida;
            MinAtaque = minAtaque;
            MaxAtaque = maxAtaque;
            MinDefesa = minDefesa;
            MaxDefesa = maxDefesa;
            MinVelocidade = minVelocidade;
            MaxVelocidade = maxVelocidade;
            Elemento = elemento;
            SegundoElemento = segundoElemento;
        }

        public Evolucao(string nome, float peso, float altura, int minVida, int maxVida, int minAtaque, int maxAtaque, int minDefesa, int maxDefesa, int minVelocidade, int maxVelocidade, Elemento elemento, SegundoElemento segundoElemento, string codigo)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
            MinVida = minVida;
            MaxVida = maxVida;
            MinAtaque = minAtaque;
            MaxAtaque = maxAtaque;
            MinDefesa = minDefesa;
            MaxDefesa = maxDefesa;
            MinVelocidade = minVelocidade;
            MaxVelocidade = maxVelocidade;
            Elemento = elemento;
            SegundoElemento = segundoElemento;
            Codigo = codigo;
        }

        public Evolucao(string nome, float peso, float altura, int minVida, int maxVida, int minAtaque, int maxAtaque, int minDefesa, int maxDefesa, int minVelocidade, int maxVelocidade, Elemento elemento, SegundoElemento segundoElemento, string codigo, string descricao)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
            MinVida = minVida;
            MaxVida = maxVida;
            MinAtaque = minAtaque;
            MaxAtaque = maxAtaque;
            MinDefesa = minDefesa;
            MaxDefesa = maxDefesa;
            MinVelocidade = minVelocidade;
            MaxVelocidade = maxVelocidade;
            Elemento = elemento;
            SegundoElemento = segundoElemento;
            Codigo = codigo;
            Descricao = descricao;
        }

        public Evolucao(string nome, float peso, float altura, int minVida, int maxVida, int minAtaque, int maxAtaque, int minDefesa, int maxDefesa, int minVelocidade, int maxVelocidade, Elemento elemento, SegundoElemento segundoElemento, string codigo, string descricao, bool apanhado)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
            MinVida = minVida;
            MaxVida = maxVida;
            MinAtaque = minAtaque;
            MaxAtaque = maxAtaque;
            MinDefesa = minDefesa;
            MaxDefesa = maxDefesa;
            MinVelocidade = minVelocidade;
            MaxVelocidade = maxVelocidade;
            Elemento = elemento;
            SegundoElemento = segundoElemento;
            Codigo = codigo;
            Descricao = descricao;
            Apanhado = apanhado;
        }

        public EvolucaoDTO ToEvolucao()
        {
            EvolucaoDTO evolucaoDTO = new EvolucaoDTOBuilder()
                .WithNome(Nome)
                .WithPeso(Peso)
                .WithAltura(Altura)
                .WithMinVida(MinVida)
                .WithMaxVida(MaxVida)
                .WithMinAtaque(MinAtaque)
                .WithMaxAtaque(MaxAtaque)
                .WithMinDefesa(MinDefesa)
                .WithMaxDefesa(MaxDefesa)
                .WithMinVelocidade(MinVelocidade)
                .WithMaxVelocidade(MaxVelocidade)
                .WithCogido(Codigo)
                .WithElemento(Elemento)
                .WithSegundoElemento(SegundoElemento)
                .WithDescricao(Descricao)
                .WithApanhado(Apanhado)
                .Build();

            return evolucaoDTO;
        }


    }
}