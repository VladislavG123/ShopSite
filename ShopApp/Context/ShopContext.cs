using Microsoft.EntityFrameworkCore;
using ShopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.Context
{
    public class ShopContext: DbContext
    {
        public ShopContext(DbContextOptions options): base(options)
        { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Basket> Baskets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Products.Add(new Product { Name = "Корова", Description = "Белая корова", Cost = 1000 });
        }
    }
}
