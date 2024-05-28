using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Productcatalog.Models;

namespace Productcatalog.Data
{
    public class ProductenDBContext: DbContext
    {
        public ProductenDBContext(DbContextOptions<ProductenDBContext> options) : base(options) { }
        public DbSet<Category>Categories { get; set; }
        public DbSet<Product>Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //configure Category entity - ONE to Many
            modelBuilder.Entity<Category>()
                .HasKey(c => c.CategoryId);
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);

            // configure Product entity - One to MANY
            modelBuilder.Entity<Product>()
                .HasKey(p => p.ProductId);
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c =>c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);

            SeedData.AddRecords(modelBuilder);

        }
        public DbSet<Productcatalog.Models.ViewModels.ProductenViewModel> ProductenViewModels { get; set; } = default!;

    }
}
