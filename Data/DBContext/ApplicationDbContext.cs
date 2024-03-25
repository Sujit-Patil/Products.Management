using Microsoft.EntityFrameworkCore;
using ProductsManagement.Data.Models;

namespace ProductsManagement.Data.DBContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
               .Property(p => p.Name)
               .IsRequired()
               .HasMaxLength(50);

            modelBuilder.Entity<Product>()
                .Property(p => p.Description)
                .HasMaxLength(140);

            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(10,2)");

            modelBuilder.Entity<Product>()
                .Property(p => p.Availability)
                .HasDefaultValue(true);

        }
    }
}
