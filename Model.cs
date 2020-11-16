using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFGetStarted
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=blogging.db");
    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }

        public List<Post> Posts { get; } = new List<Post>();
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }

    public class Product 
    {
        public int ProductId { get; set; }
        public int TypeProductId { get; set; }
        public int CategoryId { get; set; }
        public int MarketId { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }
        public float Price  { get; set; }
        public float PriceDiscount { get; set; }
        public int Quantity { get; set; }
        public int Views { get; set; }
        public int Likes { get; set; }
        public int Status { get; set; }
    }

    public class Shop
    {
        public int ShopId { get; set; }
        public string Name  { get; set; }
        public string Address { get; set; }
        public string Img { get; set; }
        public int ProductCount { get; set; }
        public int status { get; set; }
    }

}