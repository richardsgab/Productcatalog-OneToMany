using Microsoft.EntityFrameworkCore;
using Productcatalog.Models;

namespace Productcatalog.Data
{
    public class SeedData
    {
        public static void AddRecords(ModelBuilder modelBuilder)
        {
            //seeding data
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId=1, Name="Body Care"},
                new Category { CategoryId=2, Name="Food"},
                new Category { CategoryId=3, Name="Decoration"}                
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId=1, Name="Aloe Body Cream", Price=7.50m, CategoryId=1},
                new Product { ProductId=2, Name="Aloe Toothpaste", Price=2.60m, CategoryId=1},
                new Product { ProductId=3, Name="Seaweed Jam", Price=5.50m, CategoryId=2},
                new Product { ProductId=4, Name="Chia seed brownie", Price=1.80m, CategoryId=2},
                new Product { ProductId=5, Name="Cactus euphorbia", Price=6.80m, CategoryId=3},
                new Product { ProductId=6, Name="Essential oil diffuser ", Price=1.80m, CategoryId=3}
                );
        }
    }
}
