using Lesson3CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace Lesson3CodeFirst.Data
{
    class FoodyByteDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=STHQ0118-01;Initial Catalog=FoodyByteDb;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        //public DbSet<FavoritRestaurant> FavoritRestaurants { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Media>()
                        .HasOne(m => m.User)
                        .WithOne(u => u.Media)
                        .HasForeignKey<User>(u => u.MediaId)
                        .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Review>()
                        .HasOne(r => r.User)
                        .WithMany(u => u.Reviews)
                        .HasForeignKey(r => r.UserId)
                        .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Review>()
                        .HasOne(r => r.Restaurant)
                        .WithMany(r => r.Reviews)
                        .HasForeignKey(r => r.RestaurantId)
                        .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Restaurant>()
                        .HasOne(r => r.Address)
                        .WithOne(a => a.Restaurant)
                        .HasForeignKey<Restaurant>(r => r.AddressId)
                        .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Restaurant>()
                        .HasMany(r => r.Dishes)
                        .WithOne(d => d.Restaurant)
                        .HasForeignKey(d => d.RestaurantId)
                        .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Restaurant>()
                        .HasMany(r => r.PhoneNumbers)
                        .WithOne(pn => pn.Restaurant)
                        .HasForeignKey(pn => pn.RestaurantId)
                        .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Dish>()
                        .HasOne(d => d.Photo)
                        .WithOne(m => m.Dish)
                        .HasForeignKey<Dish>(d => d.MediaId)
                        .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Dish>()
                        .HasOne(d => d.Category)
                        .WithMany(c => c.Dishes)
                        .HasForeignKey(d => d.CategoryId)
                        .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<FavoritRestaurant>()
            //            .HasNoKey();

            //modelBuilder.Entity<FavoritRestaurant>()
            //            .HasOne(fr => fr.User)
            //            .WithMany(u => u.FavoritRestaurants)
            //            .HasForeignKey(fr => fr.UserId)
            //            .OnDelete(DeleteBehavior.NoAction);

        }



    }
}
