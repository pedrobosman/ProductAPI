using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProduto.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { 
        
        }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Produto>()
                .Property(p => p.Nome)
                .HasMaxLength(80);

            modelBuilder.Entity<Produto>()
                .Property(p => p.Preco)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Produto>()
                .HasData(
                    new Produto() { Id=1,Nome="Caneta",Preco = 1.29M,Estoque=10 },
                    new Produto() { Id = 2, Nome = "Café", Preco = 5.99M, Estoque = 300 },
                    new Produto() { Id = 3, Nome = "Alexa", Preco = 189.90M, Estoque = 1000 }
                );
        }

    }
}
