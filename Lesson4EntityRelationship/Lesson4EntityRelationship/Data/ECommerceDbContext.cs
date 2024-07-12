using Lesson4EntityRelationship.Models;
using Microsoft.EntityFrameworkCore;

namespace Lesson4EntityRelationship.Data
{
    public class ECommerceDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Provider
            // LazyLoading
            // Sql
            // and so on
            optionsBuilder.UseSqlServer("Data Source=STHQ0118-01;Initial Catalog=ECommerceDb;User ID=admin;Password=admin;Trust Server Certificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>().HasKey(u => u.Id);
            #region OneToOne FluentApi

            modelBuilder.Entity<User>()
                        .HasOne(u => u.Role)
                        .WithOne(r => r.User)
                        .HasForeignKey<Role>(r => r.Id);

            #endregion

            #region OneToMany FluentApi

            modelBuilder.Entity<Category>()
                     .HasMany(c => c.Products)
                     .WithOne(p => p.Category)
                     .HasForeignKey(p => p.CategoryId);

            #endregion

            #region ManyToMany

            modelBuilder.Entity<AuthorBook>()
                        .HasKey(ab => new { ab.AuhtorId, ab.BookId });

            modelBuilder.Entity<AuthorBook>()
                        .HasOne(ab => ab.Book)
                        .WithMany(b => b.Authors)
                        .HasForeignKey(ab => ab.BookId);

            modelBuilder.Entity<AuthorBook>()
                        .HasOne(ab => ab.Author)
                        .WithMany(ab => ab.Books)
                        .HasForeignKey(ab => ab.AuhtorId);

            #endregion

        }
    }
}
