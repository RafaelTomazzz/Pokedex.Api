﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pokedex.Api.Data;

#nullable disable

namespace Pokedex.Api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231216133146_AdicionandoEvolucaoHabilidade")]
    partial class AdicionandoEvolucaoHabilidade
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Pokedex.Api.Models.Evolucao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Elemento")
                        .HasColumnType("int")
                        .HasColumnName("Elemento");

                    b.Property<int>("IdPokemon")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Nome_Pokemon");

                    b.Property<string>("Peso")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)")
                        .HasColumnName("Peso_Pokemon");

                    b.Property<int>("PtAtaque")
                        .HasColumnType("int")
                        .HasColumnName("Pontos_Ataque");

                    b.Property<int>("PtDefesa")
                        .HasColumnType("int")
                        .HasColumnName("Pontos_Defesa");

                    b.Property<int>("PtVida")
                        .HasColumnType("int")
                        .HasColumnName("Pontos_Vida");

                    b.HasKey("Id");

                    b.HasIndex("IdPokemon");

                    b.ToTable("Evolucao");
                });

            modelBuilder.Entity("Pokedex.Api.Models.EvolucaoHabilidade", b =>
                {
                    b.Property<int>("IdHabilidade")
                        .HasColumnType("int");

                    b.Property<int?>("HabilidadeId")
                        .HasColumnType("int");

                    b.Property<int>("IdEvolucao")
                        .HasColumnType("int");

                    b.HasKey("IdHabilidade");

                    b.HasIndex("HabilidadeId");

                    b.ToTable("EvolucaoHabilidade");
                });

            modelBuilder.Entity("Pokedex.Api.Models.Habilidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("Descricao");

                    b.Property<int>("Elemento")
                        .HasColumnType("int")
                        .HasColumnName("Elemento");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("Nome_Habilidade");

                    b.Property<int>("Power")
                        .HasColumnType("int")
                        .HasColumnName("Power");

                    b.Property<int>("PtPower")
                        .HasColumnType("int")
                        .HasColumnName("Pontos_Power");

                    b.Property<int>("PtPrecisao")
                        .HasColumnType("int")
                        .HasColumnName("Pontos_Precisao");

                    b.HasKey("Id");

                    b.ToTable("Habilidade");
                });

            modelBuilder.Entity("Pokedex.Api.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Descricao");

                    b.Property<int?>("Elemento")
                        .HasColumnType("int")
                        .HasColumnName("Elemento");

                    b.Property<int>("IdTreinador")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Nome");

                    b.Property<int>("PtAtaque")
                        .HasColumnType("int")
                        .HasColumnName("Pontos_Ataque");

                    b.Property<int>("PtDefesa")
                        .HasColumnType("int")
                        .HasColumnName("Pontos_Defesa");

                    b.Property<int>("PtVida")
                        .HasColumnType("int")
                        .HasColumnName("Pontos_Vida");

                    b.HasKey("Id");

                    b.HasIndex("IdTreinador");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("Pokedex.Api.Models.Pokemon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("Altura")
                        .HasMaxLength(3)
                        .HasColumnType("real")
                        .HasColumnName("Altura_Pokemon");

                    b.Property<int>("Elemento")
                        .HasColumnType("int")
                        .HasColumnName("Elemento");

                    b.Property<int>("IdTreinador")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Nome_Pokemon");

                    b.Property<float>("Peso")
                        .HasMaxLength(3)
                        .HasColumnType("real")
                        .HasColumnName("Peso_Pokemon");

                    b.Property<int>("PtAtaque")
                        .HasColumnType("int")
                        .HasColumnName("Pontos_Ataque");

                    b.Property<int>("PtDefesa")
                        .HasColumnType("int")
                        .HasColumnName("Pontos_Defesa");

                    b.Property<int>("PtVelocidade")
                        .HasColumnType("int")
                        .HasColumnName("Pontos_Velocidade");

                    b.Property<int>("PtVida")
                        .HasColumnType("int")
                        .HasColumnName("Pontos_Vida");

                    b.HasKey("Id");

                    b.HasIndex("IdTreinador");

                    b.ToTable("Pokemon");
                });

            modelBuilder.Entity("Pokedex.Api.Models.PokemonHabilidade", b =>
                {
                    b.Property<int>("IdPokemon")
                        .HasColumnType("int");

                    b.Property<int>("IdHabilidade")
                        .HasColumnType("int");

                    b.HasKey("IdPokemon");

                    b.HasIndex("IdHabilidade");

                    b.ToTable("PokemonHabilidade");
                });

            modelBuilder.Entity("Pokedex.Api.Models.Treinador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DtNascimento")
                        .HasColumnType("datetime2")
                        .HasColumnName("Data_Nascimento");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("Login");

                    b.Property<string>("PNome")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Primeiro_Nome");

                    b.Property<string>("SNome")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Segundo_Nome");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("Senha");

                    b.HasKey("Id");

                    b.ToTable("Treinador");
                });

            modelBuilder.Entity("Pokedex.Api.Models.Evolucao", b =>
                {
                    b.HasOne("Pokedex.Api.Models.Pokemon", "Pokemon")
                        .WithMany("Evolucoes")
                        .HasForeignKey("IdPokemon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pokemon");
                });

            modelBuilder.Entity("Pokedex.Api.Models.EvolucaoHabilidade", b =>
                {
                    b.HasOne("Pokedex.Api.Models.Habilidade", null)
                        .WithMany("EvolucaoHabilidades")
                        .HasForeignKey("HabilidadeId");

                    b.HasOne("Pokedex.Api.Models.Evolucao", "Evolucao")
                        .WithMany("EvolucaoHabilidades")
                        .HasForeignKey("IdHabilidade")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Evolucao");
                });

            modelBuilder.Entity("Pokedex.Api.Models.Item", b =>
                {
                    b.HasOne("Pokedex.Api.Models.Treinador", "Treinador")
                        .WithMany("Itens")
                        .HasForeignKey("IdTreinador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Treinador");
                });

            modelBuilder.Entity("Pokedex.Api.Models.Pokemon", b =>
                {
                    b.HasOne("Pokedex.Api.Models.Treinador", "Treinador")
                        .WithMany("Pokemons")
                        .HasForeignKey("IdTreinador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Treinador");
                });

            modelBuilder.Entity("Pokedex.Api.Models.PokemonHabilidade", b =>
                {
                    b.HasOne("Pokedex.Api.Models.Habilidade", "Habilidade")
                        .WithMany("PokemonHabilidades")
                        .HasForeignKey("IdHabilidade")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pokedex.Api.Models.Pokemon", "Pokemon")
                        .WithMany("PokemonHabilidades")
                        .HasForeignKey("IdPokemon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Habilidade");

                    b.Navigation("Pokemon");
                });

            modelBuilder.Entity("Pokedex.Api.Models.Evolucao", b =>
                {
                    b.Navigation("EvolucaoHabilidades");
                });

            modelBuilder.Entity("Pokedex.Api.Models.Habilidade", b =>
                {
                    b.Navigation("EvolucaoHabilidades");

                    b.Navigation("PokemonHabilidades");
                });

            modelBuilder.Entity("Pokedex.Api.Models.Pokemon", b =>
                {
                    b.Navigation("Evolucoes");

                    b.Navigation("PokemonHabilidades");
                });

            modelBuilder.Entity("Pokedex.Api.Models.Treinador", b =>
                {
                    b.Navigation("Itens");

                    b.Navigation("Pokemons");
                });
#pragma warning restore 612, 618
        }
    }
}
