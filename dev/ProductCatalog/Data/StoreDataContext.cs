using Microsoft.EntityFrameworkCore;
using ProductCatalog.Data;
using ProductCatalog.Data.Maps;
using ProductCatalog.Models;

namespace ProductCatalog.Data
{ 
    public  class StoreDataContext : DbContext
    {
        public DbSet<Product> Products {get; set;}
        public DbSet<Category> Categories {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=pdtctl;User ID=sa;Password=casa0907;");
        }

        /*Aplica as configuração das tabelas do BD */
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ProductMap());
            builder.ApplyConfiguration(new CategoryMap());
        } 
    }
}