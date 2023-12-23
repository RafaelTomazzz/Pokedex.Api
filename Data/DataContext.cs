using Microsoft.EntityFrameworkCore;
using Pokedex.Api.Models;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pokemon>()
                .HasOne(p => p.Treinador)
                .WithMany(t => t.Pokemons)
                .HasForeignKey(p => p.IdTreinador)
                .OnDelete(DeleteBehavior.Cascade);
            
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

            modelBuilder.Entity<PokemonHabilidade>()
                .HasKey(p => p.IdHabilidade);

                
            modelBuilder.Entity<PokemonHabilidade>()
                .HasKey(p => p.IdPokemon);

            modelBuilder.Entity<EvolucaoHabilidade>()
                .HasOne(e => e.Evolucao)
                .WithMany(p => p.EvolucaoHabilidades)
                .HasForeignKey(e => e.IdEvolucao)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<EvolucaoHabilidade>()
                .HasOne(e => e.Evolucao)
                .WithMany(p => p.EvolucaoHabilidades)
                .HasForeignKey(e => e.IdHabilidade)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<EvolucaoHabilidade>()
                .HasKey(p => p.IdEvolucao);
            
            modelBuilder.Entity<EvolucaoHabilidade>()
                .HasKey(p => p.IdHabilidade);

            base.OnModelCreating(modelBuilder);
        }
    }
}