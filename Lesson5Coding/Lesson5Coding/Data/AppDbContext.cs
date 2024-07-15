using Lesson5Coding.Models;
using Microsoft.EntityFrameworkCore;

namespace Lesson5Coding.Data;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseLazyLoadingProxies()
                        .UseSqlServer("Data Source=STHQ0118-01;Initial Catalog=TestDb;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False")
                        .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }


    public override int SaveChanges()
    {
        var datas = ChangeTracker.Entries<BaseEntity>();

        foreach (var data in datas)
        {
            _ = data.State switch
            {
                EntityState.Added => data.Entity.CreatedTime = DateTime.Now,
                EntityState.Modified => data.Entity.UpdatedTime = DateTime.Now,
                _ => DateTime.Now
            };
        }
        return base.SaveChanges();
    }
}
