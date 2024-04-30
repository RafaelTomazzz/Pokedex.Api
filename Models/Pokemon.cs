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
    [PrimaryKey(nameof(Id))]
    [Table("Pokemon")]
    public class Pokemon
    {
        public ICollection<Evolucao>? Evolucoes {get; set;}
        public ICollection<PokemonHabilidade>? PokemonHabilidades {get; set; }
        public ICollection<PokemonTreinador>? PokemonTreinadores {get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get; set; }

        [Required]
        [NotNull]
        [Column("Nome_Pokemon")]
        [StringLength(20)]
        public string Nome {get; set;}

        [Required]
        [NotNull]
        [Column("Peso_Pokemon")]
        public float Peso {get; set;}

        [Required]
        [NotNull]
        [Column("Altura_Pokemon")]
        public float Altura {get; set;}

        [Required]
        [NotNull]
        [Column("Codigo")]
        public int Codigo { get; set;}

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
        public string Descricao { get; set;}

        [Required]
        [NotNull]
        [Column("Imagem")]
        public string Imagem { get; set;}




        public Pokemon()
        {}

        public Pokemon(string nome)
        {
            Nome = nome;
        }

        public Pokemon(string nome, float peso)
        {
            Nome = nome;
            Peso = peso;
        }
        
        public Pokemon(string nome, float peso, float altura)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
        }

        public Pokemon(string nome, float peso, float altura, int minVida)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
            MinVida = minVida;
        }

        public Pokemon(string nome, float peso, float altura, int minVida, int maxVida)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
            MinVida = minVida;
            MaxVida = maxVida;
        }

        public Pokemon(string nome, float peso, float altura, int minVida, int maxVida, int minAtaque)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
            MinVida = minVida;
            MaxVida = maxVida;
            MinAtaque = minAtaque;
        }

        public Pokemon(string nome, float peso, float altura, int minVida, int maxVida, int minAtaque, int maxAtaque)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
            MinVida = minVida;
            MaxVida = maxVida;
            MinAtaque = minAtaque;
            MaxAtaque = maxAtaque;
        }

        public Pokemon(string nome, float peso, float altura, int minVida, int maxVida, int minAtaque, int maxAtaque, int minDefesa)
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

        public Pokemon(string nome, float peso, float altura, int minVida, int maxVida, int minAtaque, int maxAtaque, int minDefesa, int maxDefesa)
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

        public Pokemon(string nome, float peso, float altura, int minVida, int maxVida, int minAtaque, int maxAtaque, int minDefesa, int maxDefesa, int minVelocidade)
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

        public Pokemon(string nome, float peso, float altura, int minVida, int maxVida, int minAtaque, int maxAtaque, int minDefesa, int maxDefesa, int minVelocidade, int maxVelocidade)
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

        public Pokemon(string nome, float peso, float altura, int minVida, int maxVida, int minAtaque, int maxAtaque, int minDefesa, int maxDefesa, int minVelocidade, int maxVelocidade, Elemento elemento)
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

        public Pokemon(string nome, float peso, float altura, int minVida, int maxVida, int minAtaque, int maxAtaque, int minDefesa, int maxDefesa, int minVelocidade, int maxVelocidade, Elemento elemento, SegundoElemento segundoElemento)
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

        public Pokemon(string nome, float peso, float altura, int minVida, int maxVida, int minAtaque, int maxAtaque, int minDefesa, int maxDefesa, int minVelocidade, int maxVelocidade, Elemento elemento, SegundoElemento segundoElemento, int codigo)
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

        public Pokemon(string nome, float peso, float altura, int minVida, int maxVida, int minAtaque, int maxAtaque, int minDefesa, int maxDefesa, int minVelocidade, int maxVelocidade, Elemento elemento, SegundoElemento segundoElemento, int codigo, string imagem)
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
            Imagem = imagem;
        }


        
        

        public PokemonDTO ToPokemon()
        {
            PokemonDTO pokemonDTO = new PokemonDTOBuilder()
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
                .WithElemento(Elemento)
                .WithSegundoElemento(SegundoElemento)
                .WithCogido(Codigo)
                .WithImagem(Imagem)
                .Builder();

            return pokemonDTO;

        }
    }
}