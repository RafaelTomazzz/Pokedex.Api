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
        public DbSet<EvolucaoTreinador> EvolucaoTreinadores {get; set;}
        public DbSet<ItemTreinador> ItemTreinadores {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Evolucao>()
                .HasOne(e => e.Pokemon)
                .WithMany(p => p.Evolucoes)
                .HasForeignKey(e => e.IdPokemon)
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

            modelBuilder.Entity<EvolucaoTreinador>()
                .HasOne(e => e.Evolucao)
                .WithMany(e => e.EvolucaoTreinadores)
                .HasForeignKey(e => e.IdEvolucao)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<EvolucaoTreinador>()
                .HasOne(e => e.Treinador)
                .WithMany(e => e.EvolucaoTreinadores)
                .HasForeignKey(e => e.IdTreinador)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ItemTreinador>()
                .HasOne(e => e.Item)
                .WithMany(e => e.ItemTreinadores)
                .HasForeignKey(e => e.IdItem)
                .OnDelete(DeleteBehavior.Cascade);
                
            modelBuilder.Entity<ItemTreinador>()
                .HasOne(e => e.Treinador)
                .WithMany(e => e.ItemTreinadores)
                .HasForeignKey(e => e.IdTreinador)
                .OnDelete(DeleteBehavior.Cascade);

            
           
           
            modelBuilder.Entity<Pokemon>().HasData
            (
                new Pokemon() {Id = 1, Nome = "Bulbasaur", Peso = 6.9F, Altura = 0.7F, Codigo = 001, MinVida = 45, MaxVida  = 290, 
                MinAtaque = 49, MaxAtaque = 216, MinDefesa = 49, MaxDefesa = 216, MinVelocidade = 45, MaxVelocidade = 207, Elemento = Elemento.Grama, 
                SegundoElemento = SegundoElemento.Veneno, 
                Descricao = "Bulbasaur is a small, mainly turquoise amphibian Pokémon with red eyes and a green bulb on its back. It is based on a frog/toad, with the bulb resembling a plant bulb that grows into a flower as it evolves.", 
                Imagem = "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/001.png"},

                new Pokemon() {Id = 2, Nome = "Charmander", Peso = 8.5F, Altura = 0.6F, Codigo = 004, MinVida = 39, MaxVida  = 282, 
                MinAtaque = 52, MaxAtaque = 223, MinDefesa = 43, MaxDefesa = 203, MinVelocidade = 65, MaxVelocidade = 251, Elemento = Elemento.Fogo, 
                SegundoElemento = SegundoElemento.Nenhum ,
                Descricao = "Charmander is a bipedal, reptilian Pokémon. Most of its body is colored orange, while its underbelly is light yellow and it has blue eyes. It has a flame at the end of its tail, which is said to signify its health.", 
                Imagem = "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/004.png"},

                new Pokemon() {Id = 3, Nome = "Squirtle", Peso = 9.0F, Altura = 0.5F, Codigo = 007, MinVida = 44, MaxVida  = 292, 
                MinAtaque = 48, MaxAtaque = 214, MinDefesa = 65, MaxDefesa = 251, MinVelocidade = 43, MaxVelocidade = 203, Elemento = Elemento.Agua, 
                SegundoElemento = SegundoElemento.Nenhum ,
                Descricao = "Charmander is a bipedal, reptilian Pokémon. Most of its body is colored orange, while its underbelly is light yellow and it has blue eyes. It has a flame at the end of its tail, which is said to signify its health.", 
                Imagem = "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/007.png"},

                new Pokemon() {Id = 4, Nome = "Caterpie", Peso = 2.9F, Altura = 0.3F, Codigo = 010, MinVida = 45, MaxVida = 294,
                MinAtaque = 30, MaxAtaque = 174, MinDefesa = 35, MaxDefesa = 185, MinVelocidade = 45, MaxVelocidade = 207, Elemento = Elemento.Inseto,
                SegundoElemento = SegundoElemento.Nenhum,
                Descricao = "Its short feet are tipped with suction pads that enable it to tirelessly climb slopes and walls.",
                Imagem = "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/010.png"},

                new Pokemon() {Id = 5, Nome = "Weedle", Peso = 3.2F, Altura = 0.3F, Codigo = 013, MinVida = 40, MaxVida = 284,
                MinAtaque = 35, MaxAtaque = 185, MinDefesa = 30, MaxDefesa = 174, MinVelocidade = 50, MaxVelocidade = 218, Elemento = Elemento.Inseto,
                SegundoElemento = SegundoElemento.Veneno,
                Descricao = "Often found in forests, eating leaves. It has a sharp venomous stinger on its head.",
                Imagem = "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/013.png"},

                new Pokemon() {Id = 6, Nome = "Pidgey", Peso = 1.8F, Altura = 0.3F, Codigo = 016, MinVida = 40, MaxVida = 284,
                MinAtaque = 45, MaxAtaque = 207, MinDefesa = 40, MaxDefesa = 196, MinVelocidade = 56, MaxVelocidade = 232, Elemento = Elemento.Normal,
                SegundoElemento = SegundoElemento.Voador,
                Descricao = "A common sight in forests and woods. It flaps its wings at ground level to kick up blinding sand.",
                Imagem = "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/016.png"}

            );

            modelBuilder.Entity<Evolucao>().HasData
            (
                new Evolucao() {Id = 1, IdPokemon = 1, Nome = "Ivysaur", Peso = 13.0F, Altura = 1.0F, Codigo = 002, MinVida = 60, MaxVida  = 324, 
                MinAtaque = 62, MaxAtaque = 245, MinDefesa = 63, MaxDefesa = 247, MinVelocidade = 60, MaxVelocidade = 240, Elemento = Elemento.Grama, 
                SegundoElemento = SegundoElemento.Veneno ,
                Descricao = "Ivysaur's appearance is very similar to that of its pre-evolved form, Bulbasaur. It still retains the turquoise skin and spots, along with its red eyes.", 
                Imagem = "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/002.png"},

                new Evolucao() {Id = 2, IdPokemon = 1, Nome = "Venusaur", Peso = 100.0F, Altura = 2.0F, Codigo = 003, MinVida = 80, MaxVida  = 364, 
                MinAtaque = 82, MaxAtaque = 289, MinDefesa = 83, MaxDefesa = 291, MinVelocidade = 80, MaxVelocidade = 284, Elemento = Elemento.Grama, 
                SegundoElemento = SegundoElemento.Veneno , 
                Descricao = "Venusaur is a large, quadrupedal Pokémon with a turquoise body. It has small red eyes and several large ferns on its back and head. The plant bulb that was on the back of its previous evolutions, Bulbasaur and Ivysaur, has now bloomed into a large flower with large pink petals and a yellow center. The female has a seed in the center.", 
                Imagem = "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/003.png"},

                new Evolucao() {Id = 3, IdPokemon = 2, Nome = "Charmeleon", Peso = 19.0F, Altura = 1.1F, Codigo = 005, MinVida = 58, MaxVida  = 320, 
                MinAtaque = 64, MaxAtaque = 249, MinDefesa = 58, MaxDefesa = 236, MinVelocidade = 80, MaxVelocidade = 284, Elemento = Elemento.Fogo, 
                SegundoElemento = SegundoElemento.Nenhum , 
                Descricao = "When it swings its burning tail, the temperature around it rises higher and higher, tormenting its opponents.", 
                Imagem = "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/005.png"},

                new Evolucao() {Id = 4, IdPokemon = 2, Nome = "Charizard", Peso = 90.5F, Altura = 1.7F, Codigo = 006, MinVida = 78, MaxVida  = 360, 
                MinAtaque = 84, MaxAtaque = 293, MinDefesa = 78, MaxDefesa = 280, MinVelocidade = 100, MaxVelocidade = 328, Elemento = Elemento.Fogo, 
                SegundoElemento = SegundoElemento.Voador , 
                Descricao = "Charizard is a large dragon-like Pokémon, mainly orange in color. It has two large wings, the underside of which are turquoise. Like Charmander and Charmeleon, it has a flame at the end of its tail.", 
                Imagem = "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/006.png"},

                new Evolucao() {Id = 5, IdPokemon = 3, Nome = "Wartortle", Peso = 22.5F, Altura = 1.0F, Codigo = 008, MinVida = 59, MaxVida  = 322, 
                MinAtaque = 63, MaxAtaque = 247, MinDefesa = 80, MaxDefesa = 284, MinVelocidade = 58, MaxVelocidade = 236, Elemento = Elemento.Agua, 
                SegundoElemento = SegundoElemento.Nenhum , 
                Descricao = "Wartortle is a small, bipedal, turtle-like Pokémon with a similar appearance to that of its pre-evolved form, Squirtle. Some differences are that Wartortle have developed sharper and larger claws and teeth, and that their tails are larger and fluffier than those of Squirtle's.", 
                Imagem = "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/008.png"},

                new Evolucao() {Id = 6, IdPokemon = 3, Nome = "Blastoise", Peso = 85.5F, Altura = 1.6F, Codigo = 009, MinVida = 79, MaxVida  = 362, 
                MinAtaque = 83, MaxAtaque = 291, MinDefesa = 100, MaxDefesa = 328, MinVelocidade = 78, MaxVelocidade = 280, Elemento = Elemento.Agua, 
                SegundoElemento = SegundoElemento.Nenhum , 
                Descricao = "Blastoise is a large, bipedal, reptilian Pokémon. It has a blue body with small purple eyes, a light brown belly, and a stubby tail. It has a large brown shell with two powerful water cannons on either side, which can be withdrawn.", 
                Imagem = "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/009.png"},

                new Evolucao() {Id = 7, IdPokemon = 4, Nome = "Metapod", Peso = 9.9F, Altura = 0.7F, Codigo = 011, MinVida = 50, MaxVida  = 304, 
                MinAtaque = 20, MaxAtaque = 152, MinDefesa = 55, MaxDefesa = 229, MinVelocidade = 30, MaxVelocidade = 174, Elemento = Elemento.Inseto, 
                SegundoElemento = SegundoElemento.Nenhum,
                Descricao = "This POKéMON is vulnerable to attack while its shell is soft, exposing its weak and tender body.", 
                Imagem = "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/011.png"},

                new Evolucao() {Id = 8, IdPokemon = 4, Nome = "Butterfree", Peso = 32F, Altura = 1.1F, Codigo = 012, MinVida = 60, MaxVida = 324, 
                MinAtaque = 45, MaxAtaque = 207, MinDefesa = 50, MaxDefesa = 218, MinVelocidade = 70, MaxVelocidade = 262, Elemento = Elemento.Inseto, 
                SegundoElemento = SegundoElemento.Voador,
                Descricao = "In battle, it flaps its wings at high speed to release highly toxic dust into the air.", 
                Imagem = "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/012.png"},

                new Evolucao() {Id = 9, IdPokemon = 5, Nome = "Kakuna", Peso = 10F, Altura = 0.6F, Codigo = 014, MinVida = 45, MaxVida  = 294, 
                MinAtaque = 25, MaxAtaque = 163, MinDefesa = 50, MaxDefesa = 218, MinVelocidade = 35, MaxVelocidade = 67, Elemento = Elemento.Inseto, 
                SegundoElemento = SegundoElemento.Veneno,
                Descricao = "Almost incapable of moving, this POKéMON can only harden its shell to protect itself from predators.", 
                Imagem = "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/014.png"},

                new Evolucao() {Id = 10, IdPokemon = 5, Nome = "Beedrill", Peso = 29.5F, Altura = 1F, Codigo = 015, MinVida = 65, MaxVida  = 334, 
                MinAtaque = 90, MaxAtaque = 306, MinDefesa = 50, MaxDefesa = 196, MinVelocidade = 75, MaxVelocidade = 273, Elemento = Elemento.Inseto, 
                SegundoElemento = SegundoElemento.Veneno,
                Descricao = "Flies at high speed and attacks using its large venomous stingers on its forelegs and tail.", 
                Imagem = "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/015.png"},

                new Evolucao() {Id = 11, IdPokemon = 6, Nome = "Pidgeotto", Peso = 30F, Altura = 1.1F, Codigo = 017, MinVida = 63, MaxVida  = 330, 
                MinAtaque = 60, MaxAtaque = 240, MinDefesa = 55, MaxDefesa = 229, MinVelocidade = 71, MaxVelocidade = 218, Elemento = Elemento.Normal, 
                SegundoElemento = SegundoElemento.Voador,
                Descricao = "Very protective of its sprawling territorial area, this POKéMON will fiercely peck at any intruder.", 
                Imagem = "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/017.png"},

                new Evolucao() {Id = 12, IdPokemon = 6, Nome = "Pidgeot", Peso = 39.5F, Altura = 1.5F, Codigo = 018, MinVida = 83, MaxVida = 370, 
                MinAtaque = 80, MaxAtaque = 284, MinDefesa = 75, MaxDefesa = 273, MinVelocidade = 101, MaxVelocidade = 331, Elemento = Elemento.Normal, 
                SegundoElemento = SegundoElemento.Voador,
                Descricao = "When hunting, it skims the surface of water at high speed to pick off unwary prey such as MAGIKARP.", 
                Imagem = "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/018.png"}
            );

            modelBuilder.Entity<Treinador>().HasData
            (
                new Treinador() {Id = 1, PNome = "Rafael", SNome = "Tomaz", DtNascimento = new DateTime(2006, 01, 27), Login = "Rafael", Senha = "senha"},
                new Treinador() {Id = 2, PNome = "Kayne", SNome = "West", DtNascimento = new DateTime(1977, 06, 08), Login = "Ye", Senha = "senha"},
                new Treinador() {Id = 3, PNome = "Shark", SNome = "Boy", DtNascimento = new DateTime(2014, 09, 12), Login = "SharkBoy", Senha = "senha"},
                new Treinador() {Id = 4, PNome = "Lava", SNome = "Girl", DtNascimento = new DateTime(2014, 04, 02), Login = "LavaGirl", Senha= "senha"}
            );

            modelBuilder.Entity<PokemonTreinador>().HasData
            (
                new PokemonTreinador() {IdPokemon = 2, IdTreinador = 1},
                new PokemonTreinador() {IdPokemon = 1, IdTreinador = 2},
                new PokemonTreinador() {IdPokemon = 3, IdTreinador = 3},
                new PokemonTreinador() {IdPokemon = 2, IdTreinador = 4}
            );

            modelBuilder.Entity<EvolucaoTreinador>().HasData
            (
                new EvolucaoTreinador() {IdEvolucao = 1, IdTreinador = 2},
                new EvolucaoTreinador() {IdEvolucao = 5, IdTreinador = 3},
                new EvolucaoTreinador() {IdEvolucao = 3, IdTreinador = 4},
                new EvolucaoTreinador() {IdEvolucao = 3, IdTreinador = 1},
                new EvolucaoTreinador() {IdEvolucao = 4, IdTreinador = 1}
            );

            modelBuilder.Entity<Item>().HasData
            (
                new Item() {Id = 1, Nome = "Potion", PtVida = 20, PtAtaque = 0, PtDefesa = 0, 
                Descricao = "Restaura 20 pontos de vida", Elemento = null }
            );

            modelBuilder.Entity<ItemTreinador>().HasData
            (
                new ItemTreinador() {IdItem = 1, IdTreinador = 1},
                new ItemTreinador() {IdItem = 1, IdTreinador = 2},
                new ItemTreinador() {IdItem = 1, IdTreinador = 3},
                new ItemTreinador() {IdItem = 1, IdTreinador = 4}
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