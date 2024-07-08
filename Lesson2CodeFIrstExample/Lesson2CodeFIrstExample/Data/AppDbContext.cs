using Lesson2CodeFIrstExample.Models.Concretes;
using Microsoft.EntityFrameworkCore;

namespace Lesson2CodeFIrstExample.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=27001;Database=ForMirtalib;User Id=postgres;Password=postgres;");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
