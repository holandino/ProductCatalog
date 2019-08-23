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
            // Incluido este comentario para poder usar no Mac , Linux e Windows com facilidade.
            //Para o MAc
            // optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=prodcat;User Id=SA;Password=reallyStrongPwd123");

            //Para o Ubuntu
            //optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=prodcat;User Id=SA;Password=SqlServer2017!");

            //Para o Windows
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;Database=prodcat;");

            //Server=(localdb)\MSSQLLocalDB;Integrated Security=true

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.ApplyConfiguration(new ProductMap());
            builder.ApplyConfiguration(new CategoryMap());
        }
    }
}
