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
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductTypeMOption> ProductTypeMOptions { get; set; }
        public DbSet<ProductMOptionValue> ProductMOptionValues { get; set; }
        public DbSet<MOptionValue> MOptionValues { get; set; }
        public DbSet<MOption> MOptions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Market> Markets { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<BrandModel> BrandModels { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<OptionValue> OptionValues { get; set; }
        public DbSet<ProductOptionValue> ProductOptionValues { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartProduct> CartProducts { get; set; }
        
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
            modelBuilder.Entity<Shop>()
                .HasIndex(u => u.Name)
                .IsUnique(true);
            modelBuilder.Entity<Login>()
                .HasIndex(u => u.Username)
                .IsUnique(true);
            modelBuilder.Entity<Login>()
                .HasIndex(u => u.Phone)
                .IsUnique(true);
            modelBuilder.Entity<Login>()
                .HasIndex(u => u.Email)
                .IsUnique(true);
            modelBuilder.Entity<Cart>()
                .HasIndex(u => u.UserId)
                .IsUnique(true);
            modelBuilder.Entity<MOption>()
                .HasIndex(u => u.Name)
                .IsUnique(true);
            modelBuilder.Entity<ProductType>()
                .HasIndex(u => u.Name)
                .IsUnique(true);
            modelBuilder.Entity<BrandModel>()
                .HasIndex(u => u.Name)
                .IsUnique(true);
            modelBuilder.Entity<Brand>()
                .HasIndex(u => u.Name)
                .IsUnique(true);
            modelBuilder.Entity<Option>()
                .HasIndex(u => u.Name)
                .IsUnique(true);
            modelBuilder.Entity<Country>()
                .HasIndex(u => u.Name)
                .IsUnique(true);
            modelBuilder.Entity<CartProduct>()
                .HasKey(c => new { c.ProductId, c.CartId });
        }
    }
}
