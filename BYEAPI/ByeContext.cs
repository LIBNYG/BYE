using Microsoft.EntityFrameworkCore;
using ByeApi.Models;

namespace ByeApi.Context
{
    public class ByeApiContext : DbContext
    {
        public ByeApiContext(DbContextOptions<ByeApiContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Clothes> Clothes { get; set; }
        public DbSet<ClothesType> ClothesTypes { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Parameters> Parameters { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Sonny> Sonnies { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<SaleType> SaleTypes { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<SoldProduct> SoldProducts { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}