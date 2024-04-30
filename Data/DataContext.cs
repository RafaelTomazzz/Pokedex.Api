using Microsoft.EntityFrameworkCore;
using Pokedex.Api.Models;
using Pokedex.Api.Models.Enuns;

namespace Pokedex.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public DbSet<Pokemon> Pokemons {get; set;}
        public DbSet<Treinador> Treinadores {get; set;}
        public DbSet<Evolucao> Evolucoes {get; set;}
        public DbSet<Item> Itens {get; set;}
        public DbSet<Habilidade> Habilidades {get; set;}
        public DbSet<PokemonHabilidade> PokemonHabilidades {get; set;}
        public DbSet<EvolucaoHabilidade> EvolucaoHabilidades {get; set;}
        public DbSet<PokemonTreinador> PokemonTreinadores {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Evolucao>()
                .HasOne(e => e.Pokemon)
                .WithMany(p => p.Evolucoes)
                .HasForeignKey(e => e.IdPokemon)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Item>()
                .HasOne(e => e.Treinador)
                .WithMany(p => p.Itens)
                .HasForeignKey(e => e.IdTreinador)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PokemonHabilidade>()
                .HasOne(e => e.Habilidade)
                .WithMany(p => p.PokemonHabilidades)
                .HasForeignKey(e => e.IdHabilidade)
                .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<PokemonHabilidade>()
                .HasOne(e => e.Pokemon)
                .WithMany(p => p.PokemonHabilidades)
                .HasForeignKey(e => e.IdPokemon)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<EvolucaoHabilidade>()
                .HasOne(e => e.Habilidade)
                .WithMany(p => p.EvolucaoHabilidades)
                .HasForeignKey(e => e.IdHabilidade)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<EvolucaoHabilidade>()
                .HasOne(e => e.Evolucao)
                .WithMany(p => p.EvolucaoHabilidades)
                .HasForeignKey(e => e.IdEvolucao)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PokemonTreinador>()
                .HasOne(e => e.Pokemon)
                .WithMany(e => e.PokemonTreinadores)
                .HasForeignKey(e => e.IdPokemon)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PokemonTreinador>()
                .HasOne(e => e.Treinador)
                .WithMany(e => e.PokemonTreinadores)
                .HasForeignKey(e => e.IdTreinador)
                .OnDelete(DeleteBehavior.Cascade);

            
           
           
            modelBuilder.Entity<Pokemon>().HasData
            (
                new Pokemon() {Id = 1, Nome = "Bulbasaur", Peso = 6.9F, Altura = 0.7F, Codigo = 001, MinVida = 45, MaxVida  = 290, 
                MinAtaque = 49, MaxAtaque = 216, MinDefesa = 49, MaxDefesa = 216, MinVelocidade = 45, MaxVelocidade = 207, Elemento = Elemento.Grama, 
                SegundoElemento = SegundoElemento.Veneno , Apanhado = false, 
                Descricao = "Bulbasaur is a small, mainly turquoise amphibian Pokémon with red eyes and a green bulb on its back. It is based on a frog/toad, with the bulb resembling a plant bulb that grows into a flower as it evolves.", 
                Imagem = "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/001.png"},

                new Pokemon() {Id = 2, Nome = "Charmander", Peso = 8.5F, Altura = 0.6F, Codigo = 004, MinVida = 39, MaxVida  = 282, 
                MinAtaque = 52, MaxAtaque = 223, MinDefesa = 43, MaxDefesa = 203, MinVelocidade = 65, MaxVelocidade = 251, Elemento = Elemento.Fogo, 
                SegundoElemento = SegundoElemento.Nenhum , Apanhado = false, 
                Descricao = "Charmander is a bipedal, reptilian Pokémon. Most of its body is colored orange, while its underbelly is light yellow and it has blue eyes. It has a flame at the end of its tail, which is said to signify its health.", 
                Imagem = "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/004.png"},

                new Pokemon() {Id = 3, Nome = "Squirtle", Peso = 9.0F, Altura = 0.5F, Codigo = 007, MinVida = 44, MaxVida  = 292, 
                MinAtaque = 48, MaxAtaque = 214, MinDefesa = 65, MaxDefesa = 251, MinVelocidade = 43, MaxVelocidade = 203, Elemento = Elemento.Agua, 
                SegundoElemento = SegundoElemento.Nenhum , Apanhado = false, 
                Descricao = "Charmander is a bipedal, reptilian Pokémon. Most of its body is colored orange, while its underbelly is light yellow and it has blue eyes. It has a flame at the end of its tail, which is said to signify its health.", 
                Imagem = "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/007.png"}
            );

            modelBuilder.Entity<Evolucao>().HasData
            (
                new Evolucao() {Id = 1, IdPokemon = 1, Nome = "Ivysaur", Peso = 13.0F, Altura = 1.0F, Codigo = 002, MinVida = 60, MaxVida  = 324, 
                MinAtaque = 62, MaxAtaque = 245, MinDefesa = 63, MaxDefesa = 247, MinVelocidade = 60, MaxVelocidade = 240, Elemento = Elemento.Grama, 
                SegundoElemento = SegundoElemento.Veneno , Apanhado = false, 
                Descricao = "Ivysaur's appearance is very similar to that of its pre-evolved form, Bulbasaur. It still retains the turquoise skin and spots, along with its red eyes.", 
                Imagem = "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/002.png"},

                new Evolucao() {Id = 2, IdPokemon = 1, Nome = "Venusaur", Peso = 100.0F, Altura = 2.0F, Codigo = 003, MinVida = 80, MaxVida  = 364, 
                MinAtaque = 82, MaxAtaque = 289, MinDefesa = 83, MaxDefesa = 291, MinVelocidade = 80, MaxVelocidade = 284, Elemento = Elemento.Grama, 
                SegundoElemento = SegundoElemento.Veneno , Apanhado = false, 
                Descricao = "Venusaur is a large, quadrupedal Pokémon with a turquoise body. It has small red eyes and several large ferns on its back and head. The plant bulb that was on the back of its previous evolutions, Bulbasaur and Ivysaur, has now bloomed into a large flower with large pink petals and a yellow center. The female has a seed in the center.", 
                Imagem = "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/003.png"},

                new Evolucao() {Id = 3, IdPokemon = 2, Nome = "Charmeleon", Peso = 19.0F, Altura = 1.1F, Codigo = 005, MinVida = 58, MaxVida  = 320, 
                MinAtaque = 64, MaxAtaque = 249, MinDefesa = 58, MaxDefesa = 236, MinVelocidade = 80, MaxVelocidade = 284, Elemento = Elemento.Fogo, 
                SegundoElemento = SegundoElemento.Nenhum , Apanhado = false, 
                Descricao = "When it swings its burning tail, the temperature around it rises higher and higher, tormenting its opponents.", 
                Imagem = "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/005.png"},

                new Evolucao() {Id = 4, IdPokemon = 2, Nome = "Charizard", Peso = 90.5F, Altura = 1.7F, Codigo = 006, MinVida = 78, MaxVida  = 360, 
                MinAtaque = 84, MaxAtaque = 293, MinDefesa = 78, MaxDefesa = 280, MinVelocidade = 100, MaxVelocidade = 328, Elemento = Elemento.Fogo, 
                SegundoElemento = SegundoElemento.Voador , Apanhado = false, 
                Descricao = "Charizard is a large dragon-like Pokémon, mainly orange in color. It has two large wings, the underside of which are turquoise. Like Charmander and Charmeleon, it has a flame at the end of its tail.", 
                Imagem = "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/006.png"},

                new Evolucao() {Id = 5, IdPokemon = 3, Nome = "Wartortle", Peso = 22.5F, Altura = 1.0F, Codigo = 008, MinVida = 59, MaxVida  = 322, 
                MinAtaque = 63, MaxAtaque = 247, MinDefesa = 80, MaxDefesa = 284, MinVelocidade = 58, MaxVelocidade = 236, Elemento = Elemento.Agua, 
                SegundoElemento = SegundoElemento.Nenhum , Apanhado = false, 
                Descricao = "Wartortle is a small, bipedal, turtle-like Pokémon with a similar appearance to that of its pre-evolved form, Squirtle. Some differences are that Wartortle have developed sharper and larger claws and teeth, and that their tails are larger and fluffier than those of Squirtle's.", 
                Imagem = "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/008.png"},

                new Evolucao() {Id = 6, IdPokemon = 3, Nome = "Blastoise", Peso = 85.5F, Altura = 1.6F, Codigo = 009, MinVida = 79, MaxVida  = 362, 
                MinAtaque = 83, MaxAtaque = 291, MinDefesa = 100, MaxDefesa = 328, MinVelocidade = 78, MaxVelocidade = 280, Elemento = Elemento.Agua, 
                SegundoElemento = SegundoElemento.Nenhum , Apanhado = false, 
                Descricao = "Blastoise is a large, bipedal, reptilian Pokémon. It has a blue body with small purple eyes, a light brown belly, and a stubby tail. It has a large brown shell with two powerful water cannons on either side, which can be withdrawn.", 
                Imagem = "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/009.png"}                
            );

            modelBuilder.Entity<Treinador>().HasData
            (
                new Treinador() {Id = 1, PNome = "Rafael", SNome = "Tomaz", DtNascimento = new DateTime(2006, 01, 27), Login = "Rafael", Senha = "senha"},
                new Treinador() {Id = 2, PNome = "Kayne", SNome = "West", DtNascimento = new DateTime(1977, 06, 08), Login = "Ye", Senha = "senha"},
                new Treinador() {Id = 3, PNome = "Shark", SNome = "Boy", DtNascimento = new DateTime(2014, 09, 12), Login = "SharkBoy", Senha = "senha"},
                new Treinador() {Id= 4, PNome = "Lava", SNome = "Girl", DtNascimento = new DateTime(2014, 04, 02), Login = "LavaGirl", Senha= "senha"}
            );

            modelBuilder.Entity<Item>().HasData
            (
                new Item() {Id = 1, Nome = "Potion", IdTreinador = 1, PtVida = 20, PtAtaque = 0, PtDefesa = 0, 
                Descricao = "Restaura 20 pontos de vida", Elemento = null }
            );

            modelBuilder.Entity<Habilidade>().HasData
            (
                new Habilidade() {Id = 1, Nome = "Tackle", Elemento = Elemento.Normal, Power = 40, PtPrecisao = 100, PtPower = 35,
                Descricao = "A physical attack in which the user charges and slams into the foe with its whole body."},

                new Habilidade() {Id = 2, Nome = "Vine Whip", Elemento = Elemento.Grama, Power = 45, PtPrecisao = 100, PtPower = 25,
                Descricao = "The foe is struck with slender, whiplike vines to inflict damage."},

                new Habilidade() {Id = 3, Nome = "Razor Leaf", Elemento = Elemento.Grama, Power = 55, PtPrecisao = 95, PtPower = 25,
                Descricao = "A sharp-edged leaf is launched to slash at the foe. It has a high critical-hit ratio."},

                new Habilidade() {Id = 4, Nome = "Scratch", Elemento = Elemento.Normal, Power = 40, PtPrecisao = 100, PtPower = 35,
                Descricao = "Hard, pointed, and sharp claws rake the foe to inflict damage."},

                new Habilidade() {Id = 5, Nome = "Ember", Elemento = Elemento.Fogo, Power = 40, PtPrecisao = 100, PtPower = 25,
                Descricao = "The target is attacked with small flames. It may also leave the target with a burn."},

                new Habilidade() {Id = 6, Nome = "Fire Fang", Elemento = Elemento.Fogo, Power = 65, PtPrecisao = 95, PtPower = 15,
                Descricao = "The user bites with flame-cloaked fangs. This may also make the target flinch or leave it with a burn."},

                new Habilidade() {Id = 7, Nome = "Dragon Claw", Elemento = Elemento.Dragao, Power = 80, PtPrecisao = 100, PtPower = 15,
                Descricao = "Sharp, huge claws hook and slash the foe quickly and with great power."},

                new Habilidade() {Id = 8, Nome = "Water Gun", Elemento = Elemento.Agua, Power = 40, PtPrecisao = 100, PtPower = 25,
                Descricao = "The foe is struck with a lot of water expelled forcibly from the mouth."},

                new Habilidade() {Id = 9, Nome = "Water Pulse", Elemento = Elemento.Agua, Power = 60, PtPrecisao = 100, PtPower = 20,
                Descricao = "The user attacks the foe with a pulsing blast of water. It may also confuse the foe."}
            );

            modelBuilder.Entity<PokemonHabilidade>().HasData
            (
                new PokemonHabilidade {IdHabilidade = 1, IdPokemon = 1},
                new PokemonHabilidade {IdHabilidade = 2, IdPokemon = 1},
                new PokemonHabilidade {IdHabilidade = 4, IdPokemon = 2},
                new PokemonHabilidade {IdHabilidade = 5, IdPokemon = 2},
                new PokemonHabilidade {IdHabilidade = 1, IdPokemon = 3},
                new PokemonHabilidade {IdHabilidade = 8, IdPokemon = 3}
            );

            modelBuilder.Entity<EvolucaoHabilidade>().HasData
            (
                new EvolucaoHabilidade { IdHabilidade = 1, IdEvolucao = 1},
                new EvolucaoHabilidade { IdHabilidade = 2, IdEvolucao = 1},
                new EvolucaoHabilidade { IdHabilidade = 2, IdEvolucao = 2},
                new EvolucaoHabilidade { IdHabilidade = 3, IdEvolucao = 2},
                new EvolucaoHabilidade { IdHabilidade = 4, IdEvolucao = 3},
                new EvolucaoHabilidade { IdHabilidade = 6, IdEvolucao = 3},
                new EvolucaoHabilidade { IdHabilidade = 6, IdEvolucao = 4},
                new EvolucaoHabilidade { IdHabilidade = 7, IdEvolucao = 4},
                new EvolucaoHabilidade { IdHabilidade = 1, IdEvolucao = 5},
                new EvolucaoHabilidade { IdHabilidade = 9, IdEvolucao = 5},
                new EvolucaoHabilidade { IdHabilidade = 8, IdEvolucao = 6},
                new EvolucaoHabilidade { IdHabilidade = 9, IdEvolucao = 6}
            );


            
            
            
            base.OnModelCreating(modelBuilder); 
        }
    }
}