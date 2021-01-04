﻿// <auto-generated />
using ApiProduto.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiProduto.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20210104183402_PuttingDecimal")]
    partial class PuttingDecimal
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("ApiProduto.Data.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Estoque")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80) CHARACTER SET utf8mb4");

                    b.Property<decimal>("Preco")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.ToTable("Produtos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Estoque = 10,
                            Nome = "Caneta",
                            Preco = 1.29m
                        },
                        new
                        {
                            Id = 2,
                            Estoque = 300,
                            Nome = "Café",
                            Preco = 5.99m
                        },
                        new
                        {
                            Id = 3,
                            Estoque = 1000,
                            Nome = "Alexa",
                            Preco = 189.90m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}