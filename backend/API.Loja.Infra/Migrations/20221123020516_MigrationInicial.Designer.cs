﻿// <auto-generated />
using API.Loja.Infra.Contextos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Loja.Infra.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20221123020516_MigrationInicial")]
    partial class MigrationInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("API.Loja.Dominio.Entidades.Categoria", b =>
                {
                    b.Property<int>("IdCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdCategoria");

                    b.Property<int>("CodigoCategoria")
                        .HasColumnType("int")
                        .HasColumnName("CodigoCategoria");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("Descricao");

                    b.HasKey("IdCategoria");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("API.Loja.Dominio.Entidades.Produtos", b =>
                {
                    b.Property<int>("IdProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdProduto");

                    b.Property<int>("CodigoProduto")
                        .HasColumnType("int")
                        .HasColumnName("CodigoProduto");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("Descricao");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal")
                        .HasColumnName("Preco");

                    b.HasKey("IdProduto");

                    b.ToTable("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
