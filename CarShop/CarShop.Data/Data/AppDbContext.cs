using CarShop.Models;
using Microsoft.EntityFrameworkCore;

namespace CarShop.Data.Data;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=tcp:fbmstest.database.windows.net,1433;Initial Catalog=CarDb;Persist Security Info=False;User ID=fbmsadmin;Password=Admin12!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;").UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    }

    public DbSet<Tag> Tags { get; set; }
    public DbSet<Car> Cars { get; set; }
}
