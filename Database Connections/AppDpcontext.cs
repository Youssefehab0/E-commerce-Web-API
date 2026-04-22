using E_commerce_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace E_commerce_Api.Database_Connections
{
    public class AppDpcontext : DbContext 
    {
        public AppDpcontext(DbContextOptions<AppDpcontext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerProfile> CustomerProfile { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Order> Order { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasOne(x=> x.profile).WithOne(c=>c.Customer).HasForeignKey<CustomerProfile>(c=>c.CustomerId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Category>().HasMany(x=>x.Products).WithOne(c=>c.Category).HasForeignKey(c=>c.CategoryId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Customer>().HasMany(x=>x.orders).WithOne(c=>c.Customer).HasForeignKey(c=>c.CustemorId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Order>().HasMany(x => x.Products).WithMany(c => c.orders);
        }
    }
}
