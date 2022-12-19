using DesafioDuett.Data.Map;
using DesafioDuett.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace DesafioDuett.Data
{
    public class DesafioDuettDbContext : DbContext
    {
        public DesafioDuettDbContext(DbContextOptions<DesafioDuettDbContext> options)
          : base(options)
        {
        }

        public DbSet<Fruit> Fruits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FruitMap());
            base.OnModelCreating(modelBuilder); 
            //   modelBuilder.Entity<Fruit>().ToTable("tblProduto");
            //   modelBuilder.Entity<Tarefa>().ToTable("tblCategoria");
        }
    }
}
