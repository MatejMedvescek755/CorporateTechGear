using Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Returns> Returns { get; set; }
        



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Orders>().ToTable("Orders");
            modelBuilder.Entity<CartItem>().ToTable("CartItem");
            modelBuilder.Entity<Brand>().ToTable("Brand");
            modelBuilder.Entity<Cart>().ToTable("Cart");
            modelBuilder.Entity<Categories>().ToTable("Categories");
            modelBuilder.Entity<Roles>().ToTable("Roles");
            modelBuilder.Entity<Returns>().ToTable("Returns");
        }
    }
}