using Microsoft.EntityFrameworkCore;
using ShopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.Context
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Product> Products { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Name = "Корова", Description = "Белая корова", Cost = 1000 },
                new Product { Name = "Хлеб", Description = "Белый хлеб", Cost = 100 },
                new Product { Name = "Молоко", Description = "Коровье", Cost = 250 }
                );

            modelBuilder.Entity<Basket>().HasData(
                new Basket { Products = new List<Product>() });
        }
    }
}
