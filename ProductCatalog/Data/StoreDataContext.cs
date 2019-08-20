using Microsoft.EntityFrameworkCore;
using ProductCatalog.Models;
using ProductCatalog.Data.Maps;

namespace ProductCatalog.Data
{
    public class StoreDataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Incluido este comentarrio para poder usar no Mac e Linux com facilidade.
            // optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=prodcat;User Id=SA;Password=reallyStrongPwd123");
            optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=prodcat;User Id=SA;Password=SqlServer2017!");

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.ApplyConfiguration(new ProductMap());
            builder.ApplyConfiguration(new CategoryMap());
        }
    }
}
