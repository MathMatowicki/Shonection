using EFGetStarted;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shonection.DAL
{
    public class ShoppingContext : DbContext
    {
        public ShoppingContext() : base() { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Product> ProductTypes { get; set; }
        public DbSet<Product> ProductTypeMOptions { get; set; }
        public DbSet<Product> ProductMOptionValues { get; set; }
        public DbSet<Product> MOptionValues { get; set; }
        public DbSet<Product> MOptions { get; set; }
        public DbSet<Product> Categories { get; set; }
        public DbSet<Product> Shops { get; set; }
        public DbSet<Product> Markets { get; set; }
        public DbSet<Product> Admins { get; set; }
        public DbSet<Product> BrandModels { get; set; }
        public DbSet<Product> Brands { get; set; }
        public DbSet<Product> Options { get; set; }
        public DbSet<Product> OptionValues { get; set; }
        public DbSet<Shop> ProductOptionValues { get; set; }
        public DbSet<Shop> Countries { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=shop.db");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Product> productConstraints = modelBuilder.Entity<Product>();
            productConstraints
                .Property(p => p.Price)
                .HasPrecision(10, 2);
            productConstraints
                .Property(p => p.DiscountPrice)
                .HasPrecision(10, 2);
            productConstraints
                .Property(p => p.Discount)
                .HasPrecision(5, 2);
        }
    }
}
