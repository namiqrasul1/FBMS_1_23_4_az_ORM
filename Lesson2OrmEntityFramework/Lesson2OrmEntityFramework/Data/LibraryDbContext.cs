using Lesson2OrmEntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Lesson2OrmEntityFramework.Data
{
    public class LibraryDbContext  : DbContext
    {
        //public LibraryDbContext(DbContextOptions options) :base(options)
        //{
            
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        }

        public DbSet<Author> Authors { get; set; }
    }
}
