using Lesson8SeedDataQueryFilterTypeConvention.Data.Configurations;
using Lesson8SeedDataQueryFilterTypeConvention.Models;
using Microsoft.EntityFrameworkCore;

namespace Lesson8SeedDataQueryFilterTypeConvention.Data;

public class AppDbContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=STHQ0118-01;Initial Catalog=MyAppDb2;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Keyler elan etmek
        modelBuilder.Entity<Customer>().HasKey(c => c.Id);

        // Table Relationships
        modelBuilder.Entity<Order>()
                    .HasOne(o => o.Customer)
                    .WithMany(c => c.Orders)
                    .HasForeignKey(o => o.CustomerId)
                    .OnDelete(DeleteBehavior.SetNull);


        modelBuilder.ApplyConfiguration(new ProductConfiguration());

       

        // context.Products.ToList();
        /*
         Select * From (Select * From Products Where IsDelete != true)
         */


        // Table Naming
        modelBuilder.Entity<Customer>().ToTable("MyCustomers");

        // Composite Key (new {PId, OId})
    }
}
