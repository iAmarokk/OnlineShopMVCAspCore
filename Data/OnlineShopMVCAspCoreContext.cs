using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineShopMVCAspCore.Models;

namespace OnlineShopMVCAspCore.Data
{
    public class OnlineShopMVCAspCoreContext : DbContext
    {
        public OnlineShopMVCAspCoreContext (DbContextOptions<OnlineShopMVCAspCoreContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Rating>().ToTable("Rating");
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Order>().ToTable("Order");
        }
    }
}
