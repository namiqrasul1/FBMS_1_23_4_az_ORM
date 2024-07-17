using Microsoft.EntityFrameworkCore;
using MyApp.Data.Models;

namespace MyApp.Data.Data;

internal class MyAppContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=STHQ0118-01;Initial Catalog=MyAppDb;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False")
            .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
}
